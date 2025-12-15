using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    public partial class Form1 : Form
    {
        private bool _loaded = false;
        private Figure3D _currentFigure;
        private Camera _camera;
        private LightingSystem _lightingSystem;

        // Variables para el control del Mouse
        private bool _isDragging = false;
        private Point _lastMousePos;

        // Modo oscuro
        private bool _darkMode = true;
        private ThemeManager _themeManager;

        public Form1()
        {
            InitializeComponent();

            _camera = new Camera();
            _currentFigure = new Figure3D();
            _lightingSystem = new LightingSystem();
            _themeManager = new ThemeManager();

            // Llenar listas desplegables
            cmbFiguras.DataSource = Enum.GetValues(typeof(ShapeType));
            cmbMaterial.DataSource = Enum.GetValues(typeof(MaterialType));
            cmbCamara.DataSource = Enum.GetValues(typeof(CameraMode));

            // Agregar ComboBox para modo de iluminación
            if (cmbIluminacion != null)
            {
                cmbIluminacion.DataSource = Enum.GetValues(typeof(LightingMode));
            }

            // Valores iniciales
            if (trackScale != null) trackScale.Value = 10;
            if (trackLight != null) trackLight.Value = 100;

            // Aplicar tema oscuro inicial
            ApplyDarkMode(_darkMode);
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            _loaded = true;

            // Configurar fondo según modo oscuro
            Color bgColor = _darkMode ? Color.FromArgb(25, 25, 30) : Color.FromArgb(250, 250, 250);
            GL.ClearColor(bgColor.R / 255f, bgColor.G / 255f, bgColor.B / 255f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);

            // Configurar iluminación usando el sistema
            _lightingSystem.Setup();
            _lightingSystem.Intensity = trackLight.Value / 100f;

            SetupViewport();
        }

        private void SetupViewport()
        {
            if (glControl.Width == 0 || glControl.Height == 0) return;

            int w = glControl.Width;
            int h = glControl.Height;
            GL.Viewport(0, 0, w, h);

            float aspect = w / (float)h;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45), aspect, 1, 100);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (!_loaded || trackLight == null) return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // 1. Configurar Cámara
            Matrix4 view = _camera.GetViewMatrix();
            GL.LoadMatrix(ref view);

            // 2. Actualizar sistema de iluminación
            _lightingSystem.Intensity = trackLight.Value / 100f;
            _lightingSystem.Update();

            // 3. Dibujar escena
            Figure3D.DrawGrid(20, _darkMode);
            _currentFigure.Draw();

            glControl.SwapBuffers();
        }

        // --- Eventos del Mouse ---
        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _lastMousePos = e.Location;
            }
        }

        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void glControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                _camera.HandleMouseDrag(e.X - _lastMousePos.X, e.Y - _lastMousePos.Y);
                _lastMousePos = e.Location;
                glControl.Invalidate();
            }
        }

        private void glControl_MouseWheel(object sender, MouseEventArgs e)
        {
            _camera.Zoom(e.Delta);
            glControl.Invalidate();
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            if (_loaded) SetupViewport();
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (_loaded)
            {
                _currentFigure.Update(0.016f);
                glControl.Invalidate();
            }
        }

        // --- Controles de la Interfaz ---
        private void cmbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFigure != null && cmbFiguras.SelectedItem != null)
            {
                _currentFigure.Type = (ShapeType)cmbFiguras.SelectedItem;
                UpdateMaterialInfo();
            }
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFigure != null && cmbMaterial.SelectedItem != null)
            {
                _currentFigure.Material = (MaterialType)cmbMaterial.SelectedItem;
                UpdateMaterialInfo();
            }
        }

        private void cmbCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_camera != null && cmbCamara.SelectedItem != null)
            {
                _camera.Mode = (CameraMode)cmbCamara.SelectedItem;
            }
        }

        private void cmbIluminacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lightingSystem != null && cmbIluminacion.SelectedItem != null)
            {
                _lightingSystem.Mode = (LightingMode)cmbIluminacion.SelectedItem;
                UpdateLightingInfo();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.Color = _currentFigure.Color; // Mostrar el color actual
            
            if (cd.ShowDialog() == DialogResult.OK)
            {
                // SOLO cambiar el color de la figura 3D
                _currentFigure.Color = cd.Color;
                
                // Forzar redibujado de la escena
                if (_loaded)
                {
                    glControl.Invalidate();
                    glControl.Refresh();
                }
            }
        }

        private void btnToggleDarkMode_Click(object sender, EventArgs e)
        {
            _darkMode = !_darkMode;
            ApplyDarkMode(_darkMode);

            // Actualizar color de fondo de OpenGL
            if (_loaded)
            {
                Color bgColor = _darkMode ? Color.FromArgb(25, 25, 30) : Color.FromArgb(250, 250, 250);
                GL.ClearColor(bgColor.R / 255f, bgColor.G / 255f, bgColor.B / 255f, 1.0f);
                glControl.Invalidate();
            }
        }

        private void UpdateTransforms(object sender, EventArgs e)
        {
            if (trackPosX == null || trackPosY == null || trackPosZ == null ||
                trackRotX == null || trackRotY == null || trackRotZ == null ||
                trackScale == null || _currentFigure == null) return;

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

            // Actualizar labels con valores
            UpdateTransformLabels();

            if (_loaded) glControl.Invalidate();
        }

        private void chkWireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentFigure != null)
            {
                _currentFigure.IsWireframe = chkWireframe.Checked;
            }
        }

        // --- Métodos auxiliares ---
        private void UpdateMaterialInfo()
        {
            if (lblMaterialInfo != null && _currentFigure != null)
            {
                lblMaterialInfo.Text = MaterialManager.GetMaterialDescription(_currentFigure.Material);
            }
        }

        private void UpdateLightingInfo()
        {
            if (lblLightingInfo != null && _lightingSystem != null)
            {
                lblLightingInfo.Text = _lightingSystem.GetModeDescription();
            }
        }

        private void UpdateTransformLabels()
        {
            if (lblPosXValue != null) lblPosXValue.Text = $"{_currentFigure.Position.X:F1}";
            if (lblPosYValue != null) lblPosYValue.Text = $"{_currentFigure.Position.Y:F1}";
            if (lblPosZValue != null) lblPosZValue.Text = $"{_currentFigure.Position.Z:F1}";

            if (lblRotXValue != null) lblRotXValue.Text = $"{_currentFigure.Rotation.X:F0}°";
            if (lblRotYValue != null) lblRotYValue.Text = $"{_currentFigure.Rotation.Y:F0}°";
            if (lblRotZValue != null) lblRotZValue.Text = $"{_currentFigure.Rotation.Z:F0}°";

            if (lblScaleValue != null) lblScaleValue.Text = $"{_currentFigure.Scale.X:F2}x";
        }

        private void ApplyDarkMode(bool darkMode)
        {
            _themeManager.ApplyTheme(this, darkMode);

            // Actualizar texto del botón
            if (btnToggleDarkMode != null)
            {
                btnToggleDarkMode.Text = darkMode ? "☀ Modo Claro" : "🌙 Modo Oscuro";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial completa
            UpdateMaterialInfo();
            UpdateLightingInfo();
            UpdateTransformLabels();
        }
    }
}