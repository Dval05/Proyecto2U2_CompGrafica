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
            this.grpTrans = new System.Windows.Forms.GroupBox();
            this.trackScale = new System.Windows.Forms.TrackBar();
            this.lblEscGen = new System.Windows.Forms.Label();
            this.lblEscala = new System.Windows.Forms.Label();
            this.trackRotZ = new System.Windows.Forms.TrackBar();
            this.lblRotZ = new System.Windows.Forms.Label();
            this.trackRotY = new System.Windows.Forms.TrackBar();
            this.lblRotY = new System.Windows.Forms.Label();
            this.trackRotX = new System.Windows.Forms.TrackBar();
            this.lblRotX = new System.Windows.Forms.Label();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.trackPosZ = new System.Windows.Forms.TrackBar();
            this.lblZ = new System.Windows.Forms.Label();
            this.trackPosY = new System.Windows.Forms.TrackBar();
            this.lblY = new System.Windows.Forms.Label();
            this.trackPosX = new System.Windows.Forms.TrackBar();
            this.lblX = new System.Windows.Forms.Label();
            this.lblTraslacion = new System.Windows.Forms.Label();
            this.grpObjeto = new System.Windows.Forms.GroupBox();
            this.chkWireframe = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbFiguras = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.grpEscena = new System.Windows.Forms.GroupBox();
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
            this.glControl.BackColor = System.Drawing.Color.White;
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(1230, 1385);
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
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMenu.Controls.Add(this.grpTrans);
            this.panelMenu.Controls.Add(this.grpObjeto);
            this.panelMenu.Controls.Add(this.grpEscena);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1230, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelMenu.Size = new System.Drawing.Size(570, 1385);
            this.panelMenu.TabIndex = 1;
            // 
            // grpTrans
            // 
            this.grpTrans.Controls.Add(this.trackScale);
            this.grpTrans.Controls.Add(this.lblEscGen);
            this.grpTrans.Controls.Add(this.lblEscala);
            this.grpTrans.Controls.Add(this.trackRotZ);
            this.grpTrans.Controls.Add(this.lblRotZ);
            this.grpTrans.Controls.Add(this.trackRotY);
            this.grpTrans.Controls.Add(this.lblRotY);
            this.grpTrans.Controls.Add(this.trackRotX);
            this.grpTrans.Controls.Add(this.lblRotX);
            this.grpTrans.Controls.Add(this.lblRotacion);
            this.grpTrans.Controls.Add(this.trackPosZ);
            this.grpTrans.Controls.Add(this.lblZ);
            this.grpTrans.Controls.Add(this.trackPosY);
            this.grpTrans.Controls.Add(this.lblY);
            this.grpTrans.Controls.Add(this.trackPosX);
            this.grpTrans.Controls.Add(this.lblX);
            this.grpTrans.Controls.Add(this.lblTraslacion);
            this.grpTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpTrans.Location = new System.Drawing.Point(22, 690);
            this.grpTrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTrans.Name = "grpTrans";
            this.grpTrans.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTrans.Size = new System.Drawing.Size(510, 859);
            this.grpTrans.TabIndex = 3;
            this.grpTrans.TabStop = false;
            this.grpTrans.Text = "Transformaciones";
            // 
            // trackScale
            // 
            this.trackScale.Location = new System.Drawing.Point(15, 762);
            this.trackScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackScale.Maximum = 50;
            this.trackScale.Minimum = 1;
            this.trackScale.Name = "trackScale";
            this.trackScale.Size = new System.Drawing.Size(465, 69);
            this.trackScale.TabIndex = 0;
            this.trackScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackScale.Value = 10;
            this.trackScale.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblEscGen
            // 
            this.lblEscGen.AutoSize = true;
            this.lblEscGen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEscGen.ForeColor = System.Drawing.Color.DimGray;
            this.lblEscGen.Location = new System.Drawing.Point(22, 731);
            this.lblEscGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscGen.Name = "lblEscGen";
            this.lblEscGen.Size = new System.Drawing.Size(135, 25);
            this.lblEscGen.TabIndex = 1;
            this.lblEscGen.Text = "Escala General";
            // 
            // lblEscala
            // 
            this.lblEscala.AutoSize = true;
            this.lblEscala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEscala.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEscala.Location = new System.Drawing.Point(15, 684);
            this.lblEscala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(153, 28);
            this.lblEscala.TabIndex = 2;
            this.lblEscala.Text = "--- TAMAÑO ---";
            // 
            // trackRotZ
            // 
            this.trackRotZ.Location = new System.Drawing.Point(15, 634);
            this.trackRotZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackRotZ.Maximum = 360;
            this.trackRotZ.Name = "trackRotZ";
            this.trackRotZ.Size = new System.Drawing.Size(465, 69);
            this.trackRotZ.TabIndex = 3;
            this.trackRotZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRotZ.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblRotZ
            // 
            this.lblRotZ.AutoSize = true;
            this.lblRotZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotZ.ForeColor = System.Drawing.Color.DimGray;
            this.lblRotZ.Location = new System.Drawing.Point(22, 603);
            this.lblRotZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotZ.Name = "lblRotZ";
            this.lblRotZ.Size = new System.Drawing.Size(131, 25);
            this.lblRotZ.TabIndex = 4;
            this.lblRotZ.Text = "Rotar en Eje Z";
            // 
            // trackRotY
            // 
            this.trackRotY.Location = new System.Drawing.Point(15, 534);
            this.trackRotY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackRotY.Maximum = 360;
            this.trackRotY.Name = "trackRotY";
            this.trackRotY.Size = new System.Drawing.Size(465, 69);
            this.trackRotY.TabIndex = 5;
            this.trackRotY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRotY.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblRotY
            // 
            this.lblRotY.AutoSize = true;
            this.lblRotY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotY.ForeColor = System.Drawing.Color.DimGray;
            this.lblRotY.Location = new System.Drawing.Point(22, 503);
            this.lblRotY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(131, 25);
            this.lblRotY.TabIndex = 6;
            this.lblRotY.Text = "Rotar en Eje Y";
            // 
            // trackRotX
            // 
            this.trackRotX.Location = new System.Drawing.Point(15, 434);
            this.trackRotX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackRotX.Maximum = 360;
            this.trackRotX.Name = "trackRotX";
            this.trackRotX.Size = new System.Drawing.Size(465, 69);
            this.trackRotX.TabIndex = 7;
            this.trackRotX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRotX.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblRotX
            // 
            this.lblRotX.AutoSize = true;
            this.lblRotX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotX.ForeColor = System.Drawing.Color.DimGray;
            this.lblRotX.Location = new System.Drawing.Point(22, 403);
            this.lblRotX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(132, 25);
            this.lblRotX.TabIndex = 8;
            this.lblRotX.Text = "Rotar en Eje X";
            // 
            // lblRotacion
            // 
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRotacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRotacion.Location = new System.Drawing.Point(15, 361);
            this.lblRotacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(165, 28);
            this.lblRotacion.TabIndex = 9;
            this.lblRotacion.Text = "--- ROTACIÓN ---";
            // 
            // trackPosZ
            // 
            this.trackPosZ.Location = new System.Drawing.Point(15, 315);
            this.trackPosZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackPosZ.Maximum = 50;
            this.trackPosZ.Minimum = -50;
            this.trackPosZ.Name = "trackPosZ";
            this.trackPosZ.Size = new System.Drawing.Size(465, 69);
            this.trackPosZ.TabIndex = 10;
            this.trackPosZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackPosZ.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblZ.ForeColor = System.Drawing.Color.DimGray;
            this.lblZ.Location = new System.Drawing.Point(22, 285);
            this.lblZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(170, 25);
            this.lblZ.TabIndex = 11;
            this.lblZ.Text = "Eje Z (Cerca/Lejos)";
            // 
            // trackPosY
            // 
            this.trackPosY.Location = new System.Drawing.Point(15, 215);
            this.trackPosY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackPosY.Maximum = 50;
            this.trackPosY.Minimum = -50;
            this.trackPosY.Name = "trackPosY";
            this.trackPosY.Size = new System.Drawing.Size(465, 69);
            this.trackPosY.TabIndex = 12;
            this.trackPosY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackPosY.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblY.ForeColor = System.Drawing.Color.DimGray;
            this.lblY.Location = new System.Drawing.Point(22, 185);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(183, 25);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "Eje Y (Arriba/Abajo)";
            // 
            // trackPosX
            // 
            this.trackPosX.Location = new System.Drawing.Point(15, 115);
            this.trackPosX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackPosX.Maximum = 50;
            this.trackPosX.Minimum = -50;
            this.trackPosX.Name = "trackPosX";
            this.trackPosX.Size = new System.Drawing.Size(465, 69);
            this.trackPosX.TabIndex = 14;
            this.trackPosX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackPosX.Scroll += new System.EventHandler(this.UpdateTransforms);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblX.ForeColor = System.Drawing.Color.DimGray;
            this.lblX.Location = new System.Drawing.Point(22, 85);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(231, 25);
            this.lblX.TabIndex = 15;
            this.lblX.Text = "Eje X (Izquierda/Derecha)";
            // 
            // lblTraslacion
            // 
            this.lblTraslacion.AutoSize = true;
            this.lblTraslacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTraslacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTraslacion.Location = new System.Drawing.Point(15, 46);
            this.lblTraslacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraslacion.Name = "lblTraslacion";
            this.lblTraslacion.Size = new System.Drawing.Size(186, 28);
            this.lblTraslacion.TabIndex = 16;
            this.lblTraslacion.Text = "--- TRASLACIÓN ---";
            // 
            // grpObjeto
            // 
            this.grpObjeto.Controls.Add(this.chkWireframe);
            this.grpObjeto.Controls.Add(this.btnColor);
            this.grpObjeto.Controls.Add(this.cmbMaterial);
            this.grpObjeto.Controls.Add(this.lblMaterial);
            this.grpObjeto.Controls.Add(this.cmbFiguras);
            this.grpObjeto.Controls.Add(this.lblFigura);
            this.grpObjeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpObjeto.Location = new System.Drawing.Point(22, 299);
            this.grpObjeto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpObjeto.Name = "grpObjeto";
            this.grpObjeto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpObjeto.Size = new System.Drawing.Size(510, 362);
            this.grpObjeto.TabIndex = 2;
            this.grpObjeto.TabStop = false;
            this.grpObjeto.Text = "Apariencia Objeto";
            // 
            // chkWireframe
            // 
            this.chkWireframe.AutoSize = true;
            this.chkWireframe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkWireframe.Location = new System.Drawing.Point(22, 308);
            this.chkWireframe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWireframe.Name = "chkWireframe";
            this.chkWireframe.Size = new System.Drawing.Size(266, 32);
            this.chkWireframe.TabIndex = 0;
            this.chkWireframe.Text = "Ver Estructura (Wireframe)";
            this.chkWireframe.UseVisualStyleBackColor = true;
            this.chkWireframe.CheckedChanged += new System.EventHandler(this.chkWireframe_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnColor.Location = new System.Drawing.Point(22, 231);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(450, 54);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Elegir Color Base...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(22, 177);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(448, 36);
            this.cmbMaterial.TabIndex = 2;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaterial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMaterial.Location = new System.Drawing.Point(15, 138);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(158, 28);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "Material (Preset):";
            // 
            // cmbFiguras
            // 
            this.cmbFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiguras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiguras.FormattingEnabled = true;
            this.cmbFiguras.Location = new System.Drawing.Point(22, 85);
            this.cmbFiguras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiguras.Name = "cmbFiguras";
            this.cmbFiguras.Size = new System.Drawing.Size(448, 36);
            this.cmbFiguras.TabIndex = 4;
            this.cmbFiguras.SelectedIndexChanged += new System.EventHandler(this.cmbFiguras_SelectedIndexChanged);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFigura.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFigura.Location = new System.Drawing.Point(15, 46);
            this.lblFigura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(108, 28);
            this.lblFigura.TabIndex = 5;
            this.lblFigura.Text = "Geometría:";
            // 
            // grpEscena
            // 
            this.grpEscena.Controls.Add(this.trackLight);
            this.grpEscena.Controls.Add(this.lblLuz);
            this.grpEscena.Controls.Add(this.cmbCamara);
            this.grpEscena.Controls.Add(this.lblCamara);
            this.grpEscena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpEscena.Location = new System.Drawing.Point(19, 20);
            this.grpEscena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEscena.Name = "grpEscena";
            this.grpEscena.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEscena.Size = new System.Drawing.Size(510, 258);
            this.grpEscena.TabIndex = 1;
            this.grpEscena.TabStop = false;
            this.grpEscena.Text = "Escena y Luz";
            // 
            // trackLight
            // 
            this.trackLight.Location = new System.Drawing.Point(15, 177);
            this.trackLight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackLight.Maximum = 200;
            this.trackLight.Name = "trackLight";
            this.trackLight.Size = new System.Drawing.Size(465, 69);
            this.trackLight.TabIndex = 3;
            this.trackLight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackLight.Value = 100;
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLuz.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLuz.Location = new System.Drawing.Point(15, 138);
            this.lblLuz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(196, 28);
            this.lblLuz.TabIndex = 4;
            this.lblLuz.Text = "Potencia de Luz (Sol):";
            // 
            // cmbCamara
            // 
            this.cmbCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamara.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(22, 85);
            this.cmbCamara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(448, 36);
            this.cmbCamara.TabIndex = 5;
            this.cmbCamara.SelectedIndexChanged += new System.EventHandler(this.cmbCamara_SelectedIndexChanged);
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCamara.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCamara.Location = new System.Drawing.Point(15, 46);
            this.lblCamara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(153, 28);
            this.lblCamara.TabIndex = 6;
            this.lblCamara.Text = "Tipo de Cámara:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(29, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(869, 45);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Proyecto 2 - Figuras en 3D con difrentes configuraciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1385);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.glControl);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Herramienta 3D - Andrade Danna, Llumiquinga Ariel, Santi Jeancarlo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.PerformLayout();

        }

        #endregion

        // Declaraciones
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Panel panelMenu;

        private System.Windows.Forms.GroupBox grpEscena, grpObjeto, grpTrans;

        private System.Windows.Forms.Label lblCamara, lblLuz;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.TrackBar trackLight;

        private System.Windows.Forms.Label lblFigura, lblMaterial;
        private System.Windows.Forms.ComboBox cmbFiguras, cmbMaterial;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chkWireframe;

        private System.Windows.Forms.Label lblTraslacion, lblX, lblY, lblZ;
        private System.Windows.Forms.TrackBar trackPosX, trackPosY, trackPosZ;

        private System.Windows.Forms.Label lblRotacion, lblRotX, lblRotY, lblRotZ;
        private System.Windows.Forms.TrackBar trackRotX, trackRotY, trackRotZ;

        private System.Windows.Forms.Label lblEscala, lblEscGen;
        private System.Windows.Forms.TrackBar trackScale;
        private System.Windows.Forms.Label lblTitulo;
    }
}