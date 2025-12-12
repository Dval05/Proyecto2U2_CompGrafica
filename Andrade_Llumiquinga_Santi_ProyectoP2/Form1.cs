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

        // Variables para el control del Mouse
        private bool _isDragging = false;
        private Point _lastMousePos;

        public Form1()
        {
            InitializeComponent();
            _camera = new Camera();
            _currentFigure = new Figure3D();

            // Llenar listas desplegables
            cmbFiguras.DataSource = Enum.GetValues(typeof(ShapeType));
            cmbMaterial.DataSource = Enum.GetValues(typeof(MaterialType));
            cmbCamara.DataSource = Enum.GetValues(typeof(CameraMode));

            // Valores iniciales seguros
            if (trackScale != null) trackScale.Value = 10;
            if (trackLight != null) trackLight.Value = 100;
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            _loaded = true;
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f); // Fondo Blanco
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);

            // Configuración inicial de luz
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 1f, 1f, 1f, 1f });

            SetupViewport();
        }

        private void SetupViewport()
        {
            if (glControl.Width == 0 || glControl.Height == 0) return; // Evitar división por cero

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
            // PROTECCIÓN CONTRA EL ERROR DE "REFERENCIA A OBJETO"
            if (!_loaded) return;
            if (trackLight == null) return; // Si la barra de luz no existe aún, no dibujar

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // 1. Configurar Cámara
            Matrix4 view = _camera.GetViewMatrix();
            GL.LoadMatrix(ref view);

            // 2. Configurar Iluminación
            float intensity = trackLight.Value / 100f * 1.5f;

            GL.Light(LightName.Light0, LightParameter.Position, new float[] { 10f, 15f, 10f, 1f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] { intensity, intensity, intensity, 1f });
            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.2f, 0.2f, 0.2f, 1f });

            // 3. Dibujar
            Figure3D.DrawGrid(20);
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
            // Solo redibujar si todo está cargado
            if (_loaded) glControl.Invalidate();
        }

        // --- Controles de la Interfaz ---
        private void cmbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFigure != null) _currentFigure.Type = (ShapeType)cmbFiguras.SelectedItem;
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFigure != null) _currentFigure.Material = (MaterialType)cmbMaterial.SelectedItem;
        }

        private void cmbCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_camera != null) _camera.Mode = (CameraMode)cmbCamara.SelectedItem;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                _currentFigure.Color = cd.Color;
        }

        private void UpdateTransforms(object sender, EventArgs e)
        {
            // PROTECCIÓN IMPORTANTE: Si los controles no existen, no hacer nada
            if (trackPosX == null || trackPosY == null || trackPosZ == null ||
                trackRotX == null || trackRotY == null || trackRotZ == null ||
                trackScale == null || _currentFigure == null) return;

            _currentFigure.Position = new Vector3(trackPosX.Value / 5f, trackPosY.Value / 5f, trackPosZ.Value / 5f);
            _currentFigure.Rotation = new Vector3(trackRotX.Value, trackRotY.Value, trackRotZ.Value);

            float s = trackScale.Value / 10f;
            _currentFigure.Scale = new Vector3(s, s, s);

            if (_loaded) glControl.Invalidate();
        }

        private void chkWireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentFigure != null) _currentFigure.IsWireframe = chkWireframe.Checked;
        }
    }
}