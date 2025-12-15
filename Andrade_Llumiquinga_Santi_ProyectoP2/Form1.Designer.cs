namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.glControl = new OpenTK.GLControl();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnToggleDarkMode = new System.Windows.Forms.Button();
            this.grpTrans = new System.Windows.Forms.GroupBox();
            this.lblScaleValue = new System.Windows.Forms.Label();
            this.trackScale = new System.Windows.Forms.TrackBar();
            this.lblEscGen = new System.Windows.Forms.Label();
            this.lblEscala = new System.Windows.Forms.Label();
            this.lblRotZValue = new System.Windows.Forms.Label();
            this.trackRotZ = new System.Windows.Forms.TrackBar();
            this.lblRotZ = new System.Windows.Forms.Label();
            this.lblRotYValue = new System.Windows.Forms.Label();
            this.trackRotY = new System.Windows.Forms.TrackBar();
            this.lblRotY = new System.Windows.Forms.Label();
            this.lblRotXValue = new System.Windows.Forms.Label();
            this.trackRotX = new System.Windows.Forms.TrackBar();
            this.lblRotX = new System.Windows.Forms.Label();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.lblPosZValue = new System.Windows.Forms.Label();
            this.trackPosZ = new System.Windows.Forms.TrackBar();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblPosYValue = new System.Windows.Forms.Label();
            this.trackPosY = new System.Windows.Forms.TrackBar();
            this.lblY = new System.Windows.Forms.Label();
            this.lblPosXValue = new System.Windows.Forms.Label();
            this.trackPosX = new System.Windows.Forms.TrackBar();
            this.lblX = new System.Windows.Forms.Label();
            this.lblTraslacion = new System.Windows.Forms.Label();
            this.grpObjeto = new System.Windows.Forms.GroupBox();
            this.lblMaterialInfo = new System.Windows.Forms.Label();
            this.chkWireframe = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbFiguras = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.grpEscena = new System.Windows.Forms.GroupBox();
            this.lblLightingInfo = new System.Windows.Forms.Label();
            this.cmbIluminacion = new System.Windows.Forms.ComboBox();
            this.lblIluminacion = new System.Windows.Forms.Label();
            this.trackLight = new System.Windows.Forms.TrackBar();
            this.lblLuz = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.lblCamara = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.grpTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPosX)).BeginInit();
            this.grpObjeto.SuspendLayout();
            this.grpEscena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(1230, 900);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = true;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            this.glControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseWheel);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 20;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panelMenu.Controls.Add(this.grpEscena);
            this.panelMenu.Controls.Add(this.grpObjeto);
            this.panelMenu.Controls.Add(this.grpTrans);
            this.panelMenu.Controls.Add(this.btnToggleDarkMode);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1230, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(15);
            this.panelMenu.Size = new System.Drawing.Size(420, 900);
            this.panelMenu.TabIndex = 1;
            // 
            // btnToggleDarkMode
            // 
            this.btnToggleDarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnToggleDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleDarkMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnToggleDarkMode.ForeColor = System.Drawing.Color.White;
            this.btnToggleDarkMode.Location = new System.Drawing.Point(18, 15);
            this.btnToggleDarkMode.Name = "btnToggleDarkMode";
            this.btnToggleDarkMode.Size = new System.Drawing.Size(380, 45);
            this.btnToggleDarkMode.TabIndex = 5;
            this.btnToggleDarkMode.Text = "☀ Modo Claro";
            this.btnToggleDarkMode.UseVisualStyleBackColor = false;
            this.btnToggleDarkMode.Click += new System.EventHandler(this.btnToggleDarkMode_Click);
            // 
            // grpEscena
            // 
            this.grpEscena.Controls.Add(this.lblTitulo);
            this.grpEscena.Controls.Add(this.lblCamara);
            this.grpEscena.Controls.Add(this.cmbCamara);
            this.grpEscena.Controls.Add(this.lblLuz);
            this.grpEscena.Controls.Add(this.trackLight);
            this.grpEscena.Controls.Add(this.lblIluminacion);
            this.grpEscena.Controls.Add(this.cmbIluminacion);
            this.grpEscena.Controls.Add(this.lblLightingInfo);
            this.grpEscena.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpEscena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.grpEscena.Location = new System.Drawing.Point(18, 70);
            this.grpEscena.Name = "grpEscena";
            this.grpEscena.Size = new System.Drawing.Size(380, 255);
            this.grpEscena.TabIndex = 2;
            this.grpEscena.TabStop = false;
            this.grpEscena.Text = "🌍 Configuración de Escena";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visualizador 3D - Proyecto Final";
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCamara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblCamara.Location = new System.Drawing.Point(13, 60);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(107, 15);
            this.lblCamara.TabIndex = 1;
            this.lblCamara.Text = "Modo de Cámara";
            // 
            // cmbCamara
            // 
            this.cmbCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamara.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCamara.ForeColor = System.Drawing.Color.White;
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(13, 80);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(350, 23);
            this.cmbCamara.TabIndex = 2;
            this.cmbCamara.SelectedIndexChanged += new System.EventHandler(this.cmbCamara_SelectedIndexChanged);
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLuz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblLuz.Location = new System.Drawing.Point(13, 115);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(118, 15);
            this.lblLuz.TabIndex = 3;
            this.lblLuz.Text = "Intensidad de Luz: ";
            // 
            // trackLight
            // 
            this.trackLight.Location = new System.Drawing.Point(13, 135);
            this.trackLight.Maximum = 150;
            this.trackLight.Minimum = 10;
            this.trackLight.Name = "trackLight";
            this.trackLight.Size = new System.Drawing.Size(350, 45);
            this.trackLight.TabIndex = 4;
            this.trackLight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackLight.Value = 100;
            // 
            // lblIluminacion
            // 
            this.lblIluminacion.AutoSize = true;
            this.lblIluminacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIluminacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblIluminacion.Location = new System.Drawing.Point(13, 175);
            this.lblIluminacion.Name = "lblIluminacion";
            this.lblIluminacion.Size = new System.Drawing.Size(130, 15);
            this.lblIluminacion.TabIndex = 5;
            this.lblIluminacion.Text = "Modo de Iluminación";
            // 
            // cmbIluminacion
            // 
            this.cmbIluminacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbIluminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIluminacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIluminacion.ForeColor = System.Drawing.Color.White;
            this.cmbIluminacion.FormattingEnabled = true;
            this.cmbIluminacion.Location = new System.Drawing.Point(13, 195);
            this.cmbIluminacion.Name = "cmbIluminacion";
            this.cmbIluminacion.Size = new System.Drawing.Size(350, 23);
            this.cmbIluminacion.TabIndex = 6;
            this.cmbIluminacion.SelectedIndexChanged += new System.EventHandler(this.cmbIluminacion_SelectedIndexChanged);
            // 
            // lblLightingInfo
            // 
            this.lblLightingInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblLightingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(160)))));
            this.lblLightingInfo.Location = new System.Drawing.Point(13, 220);
            this.lblLightingInfo.Name = "lblLightingInfo";
            this.lblLightingInfo.Size = new System.Drawing.Size(350, 30);
            this.lblLightingInfo.TabIndex = 7;
            this.lblLightingInfo.Text = "Día: Luz solar brillante";
            // 
            // grpObjeto
            // 
            this.grpObjeto.Controls.Add(this.lblFigura);
            this.grpObjeto.Controls.Add(this.cmbFiguras);
            this.grpObjeto.Controls.Add(this.lblMaterial);
            this.grpObjeto.Controls.Add(this.cmbMaterial);
            this.grpObjeto.Controls.Add(this.btnColor);
            this.grpObjeto.Controls.Add(this.chkWireframe);
            this.grpObjeto.Controls.Add(this.lblMaterialInfo);
            this.grpObjeto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpObjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.grpObjeto.Location = new System.Drawing.Point(18, 335);
            this.grpObjeto.Name = "grpObjeto";
            this.grpObjeto.Size = new System.Drawing.Size(380, 235);
            this.grpObjeto.TabIndex = 3;
            this.grpObjeto.TabStop = false;
            this.grpObjeto.Text = "🎨 Apariencia del Objeto";
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFigura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblFigura.Location = new System.Drawing.Point(13, 30);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(90, 15);
            this.lblFigura.TabIndex = 0;
            this.lblFigura.Text = "Tipo de Figura";
            // 
            // cmbFiguras
            // 
            this.cmbFiguras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiguras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFiguras.ForeColor = System.Drawing.Color.White;
            this.cmbFiguras.FormattingEnabled = true;
            this.cmbFiguras.Location = new System.Drawing.Point(13, 50);
            this.cmbFiguras.Name = "cmbFiguras";
            this.cmbFiguras.Size = new System.Drawing.Size(350, 23);
            this.cmbFiguras.TabIndex = 1;
            this.cmbFiguras.SelectedIndexChanged += new System.EventHandler(this.cmbFiguras_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblMaterial.Location = new System.Drawing.Point(13, 85);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(54, 15);
            this.lblMaterial.TabIndex = 2;
            this.lblMaterial.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMaterial.ForeColor = System.Drawing.Color.White;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(13, 105);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(350, 23);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // lblMaterialInfo
            // 
            this.lblMaterialInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblMaterialInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(160)))));
            this.lblMaterialInfo.Location = new System.Drawing.Point(13, 135);
            this.lblMaterialInfo.Name = "lblMaterialInfo";
            this.lblMaterialInfo.Size = new System.Drawing.Size(350, 40);
            this.lblMaterialInfo.TabIndex = 4;
            this.lblMaterialInfo.Text = "Plástico: Material brillante estándar";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(13, 180);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(350, 35);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "🎨 Elegir Color Base...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // chkWireframe
            // 
            this.chkWireframe.AutoSize = true;
            this.chkWireframe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkWireframe.ForeColor = System.Drawing.Color.White;
            this.chkWireframe.Location = new System.Drawing.Point(190, 187);
            this.chkWireframe.Name = "chkWireframe";
            this.chkWireframe.Size = new System.Drawing.Size(173, 19);
            this.chkWireframe.TabIndex = 6;
            this.chkWireframe.Text = "Ver Estructura (Wireframe)";
            this.chkWireframe.UseVisualStyleBackColor = true;
            this.chkWireframe.CheckedChanged += new System.EventHandler(this.chkWireframe_CheckedChanged);
            // 
            // grpTrans
            // 
            this.grpTrans.Controls.Add(this.lblTraslacion);
            this.grpTrans.Controls.Add(this.lblX);
            this.grpTrans.Controls.Add(this.trackPosX);
            this.grpTrans.Controls.Add(this.lblPosXValue);
            this.grpTrans.Controls.Add(this.lblY);
            this.grpTrans.Controls.Add(this.trackPosY);
            this.grpTrans.Controls.Add(this.lblPosYValue);
            this.grpTrans.Controls.Add(this.lblZ);
            this.grpTrans.Controls.Add(this.trackPosZ);
            this.grpTrans.Controls.Add(this.lblPosZValue);
            this.grpTrans.Controls.Add(this.lblRotacion);
            this.grpTrans.Controls.Add(this.lblRotX);
            this.grpTrans.Controls.Add(this.trackRotX);
            this.grpTrans.Controls.Add(this.lblRotXValue);
            this.grpTrans.Controls.Add(this.lblRotY);
            this.grpTrans.Controls.Add(this.trackRotY);
            this.grpTrans.Controls.Add(this.lblRotYValue);
            this.grpTrans.Controls.Add(this.lblRotZ);
            this.grpTrans.Controls.Add(this.trackRotZ);
            this.grpTrans.Controls.Add(this.lblRotZValue);
            this.grpTrans.Controls.Add(this.lblEscala);
            this.grpTrans.Controls.Add(this.lblEscGen);
            this.grpTrans.Controls.Add(this.trackScale);
            this.grpTrans.Controls.Add(this.lblScaleValue);
            this.grpTrans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.grpTrans.Location = new System.Drawing.Point(18, 580);
            this.grpTrans.Name = "grpTrans";
            this.grpTrans.Size = new System.Drawing.Size(380, 750);
            this.grpTrans.TabIndex = 4;
            this.grpTrans.TabStop = false;
            this.grpTrans.Text = "⚙ Transformaciones";
            // 
            // lblTraslacion
            // 
            this.lblTraslacion.AutoSize = true;
            this.lblTraslacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTraslacion.ForeColor = System.Drawing.Color.White;
            this.lblTraslacion.Location = new System.Drawing.Point(15, 30);
            this.lblTraslacion.Name = "lblTraslacion";
            this.lblTraslacion.Size = new System.Drawing.Size(149, 19);
            this.lblTraslacion.TabIndex = 0;
            this.lblTraslacion.Text = "--- TRASLACIÓN ---";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblX.Location = new System.Drawing.Point(15, 60);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(156, 15);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "Eje X (Izquierda/Derecha)";
            // 
            // trackPosX
            // 
            this.trackPosX.Location = new System.Drawing.Point(15, 80);
            this.trackPosX.Maximum = 50;
            this.trackPosX.Minimum = -50;
            this.trackPosX.Name = "trackPosX";
            this.trackPosX.Size = new System.Drawing.Size(350, 45);
            this.trackPosX.TabIndex = 2;
            this.trackPosX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackPosX.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblPosXValue
            // 
            this.lblPosXValue.AutoSize = true;
            this.lblPosXValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosXValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblPosXValue.Location = new System.Drawing.Point(320, 60);
            this.lblPosXValue.Name = "lblPosXValue";
            this.lblPosXValue.Size = new System.Drawing.Size(24, 15);
            this.lblPosXValue.TabIndex = 3;
            this.lblPosXValue.Text = "0.0";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblY.Location = new System.Drawing.Point(15, 140);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(124, 15);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Eje Y (Arriba/Abajo)";
            // 
            // trackPosY
            // 
            this.trackPosY.Location = new System.Drawing.Point(15, 160);
            this.trackPosY.Maximum = 50;
            this.trackPosY.Minimum = -50;
            this.trackPosY.Name = "trackPosY";
            this.trackPosY.Size = new System.Drawing.Size(350, 45);
            this.trackPosY.TabIndex = 5;
            this.trackPosY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackPosY.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblPosYValue
            // 
            this.lblPosYValue.AutoSize = true;
            this.lblPosYValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosYValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblPosYValue.Location = new System.Drawing.Point(320, 140);
            this.lblPosYValue.Name = "lblPosYValue";
            this.lblPosYValue.Size = new System.Drawing.Size(24, 15);
            this.lblPosYValue.TabIndex = 6;
            this.lblPosYValue.Text = "0.0";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblZ.Location = new System.Drawing.Point(15, 220);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(115, 15);
            this.lblZ.TabIndex = 7;
            this.lblZ.Text = "Eje Z (Cerca/Lejos)";
            // 
            // trackPosZ
            // 
            this.trackPosZ.Location = new System.Drawing.Point(15, 240);
            this.trackPosZ.Maximum = 50;
            this.trackPosZ.Minimum = -50;
            this.trackPosZ.Name = "trackPosZ";
            this.trackPosZ.Size = new System.Drawing.Size(350, 45);
            this.trackPosZ.TabIndex = 8;
            this.trackPosZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackPosZ.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblPosZValue
            // 
            this.lblPosZValue.AutoSize = true;
            this.lblPosZValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosZValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblPosZValue.Location = new System.Drawing.Point(320, 220);
            this.lblPosZValue.Name = "lblPosZValue";
            this.lblPosZValue.Size = new System.Drawing.Size(24, 15);
            this.lblPosZValue.TabIndex = 9;
            this.lblPosZValue.Text = "0.0";
            // 
            // lblRotacion
            // 
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRotacion.ForeColor = System.Drawing.Color.White;
            this.lblRotacion.Location = new System.Drawing.Point(15, 300);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(132, 19);
            this.lblRotacion.TabIndex = 10;
            this.lblRotacion.Text = "--- ROTACIÓN ---";
            // 
            // lblRotX
            // 
            this.lblRotX.AutoSize = true;
            this.lblRotX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblRotX.Location = new System.Drawing.Point(15, 330);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(89, 15);
            this.lblRotX.TabIndex = 11;
            this.lblRotX.Text = "Rotar en Eje X";
            // 
            // trackRotX
            // 
            this.trackRotX.Location = new System.Drawing.Point(15, 350);
            this.trackRotX.Maximum = 360;
            this.trackRotX.Name = "trackRotX";
            this.trackRotX.Size = new System.Drawing.Size(350, 45);
            this.trackRotX.TabIndex = 12;
            this.trackRotX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRotX.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblRotXValue
            // 
            this.lblRotXValue.AutoSize = true;
            this.lblRotXValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotXValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblRotXValue.Location = new System.Drawing.Point(320, 330);
            this.lblRotXValue.Name = "lblRotXValue";
            this.lblRotXValue.Size = new System.Drawing.Size(24, 15);
            this.lblRotXValue.TabIndex = 13;
            this.lblRotXValue.Text = "0°";
            // 
            // lblRotY
            // 
            this.lblRotY.AutoSize = true;
            this.lblRotY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblRotY.Location = new System.Drawing.Point(15, 410);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(88, 15);
            this.lblRotY.TabIndex = 14;
            this.lblRotY.Text = "Rotar en Eje Y";
            // 
            // trackRotY
            // 
            this.trackRotY.Location = new System.Drawing.Point(15, 430);
            this.trackRotY.Maximum = 360;
            this.trackRotY.Name = "trackRotY";
            this.trackRotY.Size = new System.Drawing.Size(350, 45);
            this.trackRotY.TabIndex = 15;
            this.trackRotY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRotY.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblRotYValue
            // 
            this.lblRotYValue.AutoSize = true;
            this.lblRotYValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotYValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblRotYValue.Location = new System.Drawing.Point(320, 410);
            this.lblRotYValue.Name = "lblRotYValue";
            this.lblRotYValue.Size = new System.Drawing.Size(24, 15);
            this.lblRotYValue.TabIndex = 16;
            this.lblRotYValue.Text = "0°";
            // 
            // lblRotZ
            // 
            this.lblRotZ.AutoSize = true;
            this.lblRotZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblRotZ.Location = new System.Drawing.Point(15, 490);
            this.lblRotZ.Name = "lblRotZ";
            this.lblRotZ.Size = new System.Drawing.Size(88, 15);
            this.lblRotZ.TabIndex = 17;
            this.lblRotZ.Text = "Rotar en Eje Z";
            // 
            // trackRotZ
            // 
            this.trackRotZ.Location = new System.Drawing.Point(15, 510);
            this.trackRotZ.Maximum = 360;
            this.trackRotZ.Name = "trackRotZ";
            this.trackRotZ.Size = new System.Drawing.Size(350, 45);
            this.trackRotZ.TabIndex = 18;
            this.trackRotZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRotZ.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblRotZValue
            // 
            this.lblRotZValue.AutoSize = true;
            this.lblRotZValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotZValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblRotZValue.Location = new System.Drawing.Point(320, 490);
            this.lblRotZValue.Name = "lblRotZValue";
            this.lblRotZValue.Size = new System.Drawing.Size(24, 15);
            this.lblRotZValue.TabIndex = 19;
            this.lblRotZValue.Text = "0°";
            // 
            // lblEscala
            // 
            this.lblEscala.AutoSize = true;
            this.lblEscala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEscala.ForeColor = System.Drawing.Color.White;
            this.lblEscala.Location = new System.Drawing.Point(15, 570);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(121, 19);
            this.lblEscala.TabIndex = 20;
            this.lblEscala.Text = "--- TAMAÑO ---";
            // 
            // lblEscGen
            // 
            this.lblEscGen.AutoSize = true;
            this.lblEscGen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEscGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblEscGen.Location = new System.Drawing.Point(15, 600);
            this.lblEscGen.Name = "lblEscGen";
            this.lblEscGen.Size = new System.Drawing.Size(88, 15);
            this.lblEscGen.TabIndex = 21;
            this.lblEscGen.Text = "Escala General";
            // 
            // trackScale
            // 
            this.trackScale.Location = new System.Drawing.Point(15, 620);
            this.trackScale.Maximum = 50;
            this.trackScale.Minimum = 1;
            this.trackScale.Name = "trackScale";
            this.trackScale.Size = new System.Drawing.Size(350, 45);
            this.trackScale.TabIndex = 22;
            this.trackScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackScale.Value = 10;
            this.trackScale.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblScaleValue
            // 
            this.lblScaleValue.AutoSize = true;
            this.lblScaleValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblScaleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblScaleValue.Location = new System.Drawing.Point(320, 600);
            this.lblScaleValue.Name = "lblScaleValue";
            this.lblScaleValue.Size = new System.Drawing.Size(36, 15);
            this.lblScaleValue.TabIndex = 23;
            this.lblScaleValue.Text = "1.00x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 900);
            this.Controls.Add(this.glControl);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Visualizador 3D - Proyecto Final";
            this.panelMenu.ResumeLayout(false);
            this.grpTrans.ResumeLayout(false);
            this.grpTrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPosX)).EndInit();
            this.grpObjeto.ResumeLayout(false);
            this.grpObjeto.PerformLayout();
            this.grpEscena.ResumeLayout(false);
            this.grpEscena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnToggleDarkMode;
        private System.Windows.Forms.GroupBox grpEscena;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.TrackBar trackLight;
        private System.Windows.Forms.Label lblIluminacion;
        private System.Windows.Forms.ComboBox cmbIluminacion;
        private System.Windows.Forms.Label lblLightingInfo;
        private System.Windows.Forms.GroupBox grpObjeto;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.ComboBox cmbFiguras;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblMaterialInfo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chkWireframe;
        private System.Windows.Forms.GroupBox grpTrans;
        private System.Windows.Forms.Label lblTraslacion;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TrackBar trackPosX;
        private System.Windows.Forms.Label lblPosXValue;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TrackBar trackPosY;
        private System.Windows.Forms.Label lblPosYValue;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TrackBar trackPosZ;
        private System.Windows.Forms.Label lblPosZValue;
        private System.Windows.Forms.Label lblRotacion;
        private System.Windows.Forms.Label lblRotX;
        private System.Windows.Forms.TrackBar trackRotX;
        private System.Windows.Forms.Label lblRotXValue;
        private System.Windows.Forms.Label lblRotY;
        private System.Windows.Forms.TrackBar trackRotY;
        private System.Windows.Forms.Label lblRotYValue;
        private System.Windows.Forms.Label lblRotZ;
        private System.Windows.Forms.TrackBar trackRotZ;
        private System.Windows.Forms.Label lblRotZValue;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.Label lblEscGen;
        private System.Windows.Forms.TrackBar trackScale;
        private System.Windows.Forms.Label lblScaleValue;
    }
}