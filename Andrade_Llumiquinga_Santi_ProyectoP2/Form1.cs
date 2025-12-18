using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    public partial class Form1 : Form
    {
        private bool _loaded = false;

        // Lista principal de figuras
        private List<Figure3D> _figures = new List<Figure3D>();
        private Figure3D _currentFigure;
        private int _figureCounter = 0;

        private Camera _camera;
        private LightingSystem _lightingSystem;

        // Variables para el control del Mouse
        private bool _isDragging = false;
        private Point _lastMousePos;

        // BANDERA DE SEGURIDAD: Evita que la interfaz modifique objetos mientras cargamos datos
        private bool _suspendGuiEvents = false;

        private bool _darkMode = true;
        private ThemeManager _themeManager;

        public Form1()
        {
            InitializeComponent();

            _camera = new Camera();
            _lightingSystem = new LightingSystem();
            _themeManager = new ThemeManager();

            // Configurar fuentes de datos
            cmbFiguras.DataSource = Enum.GetValues(typeof(ShapeType));
            cmbMaterial.DataSource = Enum.GetValues(typeof(MaterialType));
            cmbCamara.DataSource = Enum.GetValues(typeof(CameraMode));

            if (cmbIluminacion != null)
                cmbIluminacion.DataSource = Enum.GetValues(typeof(LightingMode));

            // Valores iniciales de la UI
            if (trackScale != null) trackScale.Value = 10;
            if (trackLight != null) trackLight.Value = 100;

            // 1. Crear la figura base (Cubo) al inicio para que sea la primera en la lista
            AgregarNuevaFigura(ShapeType.Cubo);

            ApplyDarkMode(_darkMode);
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            _loaded = true;
            Color bgColor = _darkMode ? Color.FromArgb(25, 25, 30) : Color.FromArgb(250, 250, 250);
            GL.ClearColor(bgColor.R / 255f, bgColor.G / 255f, bgColor.B / 255f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);

            _lightingSystem.Setup();
            _lightingSystem.Intensity = trackLight.Value / 100f;

            SetupViewport();
        }

        // ... [El código de SetupViewport, glControl_Paint y eventos del Mouse se mantiene igual] ...
        private void SetupViewport()
        {
            if (glControl.Width == 0 || glControl.Height == 0) return;
            int w = glControl.Width;
            int h = glControl.Height;
            GL.Viewport(0, 0, w, h);
            float aspect = w / (float)h;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45), aspect, 1, 100);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (!_loaded || trackLight == null) return;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 view = _camera.GetViewMatrix();
            GL.LoadMatrix(ref view);

            _lightingSystem.Intensity = trackLight.Value / 100f;
            _lightingSystem.Update();

            Figure3D.DrawGrid(20, _darkMode);

            // Dibujar figuras en orden
            foreach (var figura in _figures)
            {
                figura.Draw();
            }

            glControl.SwapBuffers();
        }

        private void glControl_MouseDown(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { _isDragging = true; _lastMousePos = e.Location; } }
        private void glControl_MouseUp(object sender, MouseEventArgs e) { _isDragging = false; }
        private void glControl_MouseMove(object sender, MouseEventArgs e) { if (_isDragging) { _camera.HandleMouseDrag(e.X - _lastMousePos.X, e.Y - _lastMousePos.Y); _lastMousePos = e.Location; glControl.Invalidate(); } }
        private void glControl_MouseWheel(object sender, MouseEventArgs e) { _camera.Zoom(e.Delta); glControl.Invalidate(); }
        private void glControl_Resize(object sender, EventArgs e) { if (_loaded) SetupViewport(); }
        private void renderTimer_Tick(object sender, EventArgs e) { if (_loaded) { foreach (var f in _figures) f.Update(0.016f); glControl.Invalidate(); } }

        // =========================================================
        // LÓGICA CORE CORREGIDA (AGREGAR Y LISTBOX)
        // =========================================================

        private void btnAgregarFigura_Click(object sender, EventArgs e)
        {
            // SOLUCIÓN CLAVE: Siempre agregar un Cubo por defecto.
            // Esto evita modificar la figura anterior al intentar seleccionar un tipo antes de agregar.
            // La nueva figura aparecerá seleccionada y en el origen (0,0,0).
            AgregarNuevaFigura(ShapeType.Cubo);
        }

        private void AgregarNuevaFigura(ShapeType tipo)
        {
            _figureCounter++;

            // Crear figura explícitamente en el origen
            var nuevaFigura = new Figure3D
            {
                Type = tipo,
                Name = $"{GetShapeIcon(tipo)} {GetShapeName(tipo)} {_figureCounter}",
                Position = Vector3.Zero,  // Asegurar origen
                Rotation = Vector3.Zero,
                Scale = Vector3.One,
                Color = Color.DodgerBlue // Color por defecto
            };

            // Añadir a la lista de datos
            _figures.Add(nuevaFigura);

            // Añadir al ListBox (siempre irá al final, respetando el orden de creación)
            lstFiguras.Items.Add(nuevaFigura.Name);

            // Seleccionar automáticamente la nueva figura
            // Esto disparará lstFiguras_SelectedIndexChanged, que actualizará la UI
            lstFiguras.SelectedIndex = lstFiguras.Items.Count - 1;

            // Foco al control GL para poder rotar la cámara inmediatamente
            glControl.Focus();
        }

        private void lstFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay selección válida, salir
            if (lstFiguras.SelectedIndex < 0 || lstFiguras.SelectedIndex >= _figures.Count)
            {
                _currentFigure = null;
                return;
            }

            // ACTIVAR ESCUDO: Evitar que los controles disparen eventos de actualización hacia la figura vieja
            _suspendGuiEvents = true;

            try
            {
                // 1. Cambiar el puntero a la nueva figura
                _currentFigure = _figures[lstFiguras.SelectedIndex];

                // 2. Cargar los valores de la nueva figura en los controles
                // (Como _suspendGuiEvents es true, estos cambios NO dispararán UpdateTransforms)
                CargarValoresFiguraActual();
            }
            finally
            {
                // DESACTIVAR ESCUDO: Ahora la UI ya refleja la nueva figura
                _suspendGuiEvents = false;
            }

            if (_loaded) glControl.Invalidate();
        }

        private void CargarValoresFiguraActual()
        {
            if (_currentFigure == null) return;

            // Tipos y Materiales
            cmbFiguras.SelectedItem = _currentFigure.Type;
            cmbMaterial.SelectedItem = _currentFigure.Material;
            chkWireframe.Checked = _currentFigure.IsWireframe;

            // Transformaciones - Convertimos vectores a valores de TrackBar
            trackPosX.Value = Clamp(trackPosX, (int)(_currentFigure.Position.X * 5f));
            trackPosY.Value = Clamp(trackPosY, (int)(_currentFigure.Position.Y * 5f));
            trackPosZ.Value = Clamp(trackPosZ, (int)(_currentFigure.Position.Z * 5f));

            trackRotX.Value = Clamp(trackRotX, (int)_currentFigure.Rotation.X);
            trackRotY.Value = Clamp(trackRotY, (int)_currentFigure.Rotation.Y);
            trackRotZ.Value = Clamp(trackRotZ, (int)_currentFigure.Rotation.Z);

            trackScale.Value = Clamp(trackScale, (int)(_currentFigure.Scale.X * 10f));

            UpdateTransformLabels();
            UpdateMaterialInfo();
        }

        // Método auxiliar para evitar errores de rango en trackbars
        private int Clamp(TrackBar track, int value)
        {
            if (value < track.Minimum) return track.Minimum;
            if (value > track.Maximum) return track.Maximum;
            return value;
        }

        // =========================================================
        // CONTROLADORES DE EVENTOS DE UI (Con protección)
        // =========================================================

        private void cmbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suspendGuiEvents || _currentFigure == null) return;

            // Lógica para cambiar el TIPO de la figura seleccionada
            if (cmbFiguras.SelectedItem != null)
            {
                ShapeType nuevoTipo = (ShapeType)cmbFiguras.SelectedItem;

                // Solo actualizar si realmente cambió el tipo
                if (_currentFigure.Type != nuevoTipo)
                {
                    _currentFigure.Type = nuevoTipo;

                    // Actualizar nombre conservando el número ID
                    string[] partes = _currentFigure.Name.Split(' ');
                    string id = partes.Length > 0 ? partes[partes.Length - 1] : "";
                    _currentFigure.Name = $"{GetShapeIcon(nuevoTipo)} {GetShapeName(nuevoTipo)} {id}";

                    // Refrescar el texto en el ListBox sin disparar eventos recursivos
                    bool estadoPrevio = _suspendGuiEvents;
                    _suspendGuiEvents = true;
                    lstFiguras.Items[lstFiguras.SelectedIndex] = _currentFigure.Name;
                    _suspendGuiEvents = estadoPrevio;

                    UpdateMaterialInfo();
                    if (_loaded) glControl.Invalidate();
                }
            }
        }

        private void UpdateTransforms(object sender, EventArgs e)
        {
            // IMPORTANTE: Si estamos cargando datos (_suspendGuiEvents), NO aplicar cambios.
            // Esto evita que al cambiar de selección, la posición 0,0,0 de la nueva figura 
            // se escriba accidentalmente en la figura anterior.
            if (_suspendGuiEvents || _currentFigure == null) return;

            // Aplicar valores de los sliders a la figura actual
            _currentFigure.Position = new Vector3(
                trackPosX.Value / 5f,
                trackPosY.Value / 5f,
                trackPosZ.Value / 5f
            );

            _currentFigure.Rotation = new Vector3(
                trackRotX.Value,
                trackRotY.Value,
                trackRotZ.Value
            );

            float s = trackScale.Value / 10f;
            _currentFigure.Scale = new Vector3(s, s, s);

            UpdateTransformLabels();
            if (_loaded) glControl.Invalidate();
        }

        private void btnEliminarFigura_Click(object sender, EventArgs e)
        {
            if (lstFiguras.SelectedIndex >= 0 && _figures.Count > 1)
            {
                int index = lstFiguras.SelectedIndex;

                // Remover de ambas listas
                _figures.RemoveAt(index);
                lstFiguras.Items.RemoveAt(index);

                // Seleccionar un elemento válido cercano
                if (lstFiguras.Items.Count > 0)
                {
                    // Intentar mantener el mismo índice o ir al último
                    int nuevoIndex = (index >= lstFiguras.Items.Count) ? lstFiguras.Items.Count - 1 : index;
                    lstFiguras.SelectedIndex = nuevoIndex;
                }

                if (_loaded) glControl.Invalidate();
            }
            else if (_figures.Count <= 1)
            {
                MessageBox.Show("Debe haber al menos una figura en la escena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ... [Resto de métodos auxiliares: cmbMaterial, cmbCamara, btnColor, etc. se mantienen igual pero respetando _suspendGuiEvents] ...

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suspendGuiEvents || _currentFigure == null) return;
            _currentFigure.Material = (MaterialType)cmbMaterial.SelectedItem;
            UpdateMaterialInfo();
            if (_loaded) glControl.Invalidate();
        }

        private void chkWireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (_suspendGuiEvents || _currentFigure == null) return;
            _currentFigure.IsWireframe = chkWireframe.Checked;
            if (_loaded) glControl.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_currentFigure == null) return;

            _suspendGuiEvents = true;
            trackPosX.Value = 0; trackPosY.Value = 0; trackPosZ.Value = 0;
            trackRotX.Value = 0; trackRotY.Value = 0; trackRotZ.Value = 0;
            trackScale.Value = 10;
            _suspendGuiEvents = false;

            // Forzar actualización manual
            UpdateTransforms(sender, e);
            _camera.Reset();
            trackLight.Value = 100;
            if (_loaded) glControl.Invalidate();
        }

        // Helpers de UI y lógica varia
        private void cmbCamara_SelectedIndexChanged(object sender, EventArgs e) { if (_camera != null) _camera.Mode = (CameraMode)cmbCamara.SelectedItem; if (_loaded) glControl.Invalidate(); }
        private void cmbIluminacion_SelectedIndexChanged(object sender, EventArgs e) { if (_lightingSystem != null) _lightingSystem.Mode = (LightingMode)cmbIluminacion.SelectedItem; UpdateLightingInfo(); if (_loaded) glControl.Invalidate(); }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            if (_currentFigure != null) cd.Color = _currentFigure.Color;
            if (cd.ShowDialog() == DialogResult.OK && _currentFigure != null) { _currentFigure.Color = cd.Color; if (_loaded) glControl.Invalidate(); }
        }

        private void btnToggleDarkMode_Click(object sender, EventArgs e)
        {
            _darkMode = !_darkMode;
            ApplyDarkMode(_darkMode);
            if (_loaded) { Color c = _darkMode ? Color.FromArgb(25, 25, 30) : Color.FromArgb(250, 250, 250); GL.ClearColor(c.R / 255f, c.G / 255f, c.B / 255f, 1.0f); glControl.Invalidate(); }
        }

        private void UpdateMaterialInfo() { if (lblMaterialInfo != null && _currentFigure != null) lblMaterialInfo.Text = MaterialManager.GetMaterialDescription(_currentFigure.Material); }
        private void UpdateLightingInfo() { if (lblLightingInfo != null && _lightingSystem != null) lblLightingInfo.Text = _lightingSystem.GetModeDescription(); }

        private void UpdateTransformLabels()
        {
            if (_currentFigure == null) return;
            if (lblPosXValue != null) lblPosXValue.Text = $"{_currentFigure.Position.X:F1}";
            if (lblPosYValue != null) lblPosYValue.Text = $"{_currentFigure.Position.Y:F1}";
            if (lblPosZValue != null) lblPosZValue.Text = $"{_currentFigure.Position.Z:F1}";
            if (lblRotXValue != null) lblRotXValue.Text = $"{_currentFigure.Rotation.X:F0}°";
            if (lblRotYValue != null) lblRotYValue.Text = $"{_currentFigure.Rotation.Y:F0}°";
            if (lblRotZValue != null) lblRotZValue.Text = $"{_currentFigure.Rotation.Z:F0}°";
            if (lblScaleValue != null) lblScaleValue.Text = $"{_currentFigure.Scale.X:F2}x";
        }

        private void ApplyDarkMode(bool darkMode) { _themeManager.ApplyTheme(this, darkMode); if (btnToggleDarkMode != null) btnToggleDarkMode.Text = darkMode ? "☀ Modo Claro" : "🌙 Modo Oscuro"; }

        private string GetShapeIcon(ShapeType type)
        {
            switch (type) { case ShapeType.Cubo: return "📦"; case ShapeType.Esfera: return "🔵"; case ShapeType.Cilindro: return "🛢"; case ShapeType.Cono: return "🔺"; case ShapeType.Piramide: return "🔻"; case ShapeType.Torus: return "⭕"; case ShapeType.Octaedro: return "💎"; default: return "📦"; }
        }
        private string GetShapeName(ShapeType type)
        {
            switch (type) { case ShapeType.Cubo: return "Cubo"; case ShapeType.Esfera: return "Esfera"; case ShapeType.Cilindro: return "Cilindro"; case ShapeType.Cono: return "Cono"; case ShapeType.Piramide: return "Pirámide"; case ShapeType.Torus: return "Torus"; case ShapeType.Octaedro: return "Octaedro"; default: return "Figura"; }
        }
    }
}