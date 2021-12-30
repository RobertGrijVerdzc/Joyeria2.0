namespace Joyeria2._0
{
    partial class frmaddempleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddempleado));
            this.lbltitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbldire = new System.Windows.Forms.Label();
            this.lblapell = new System.Windows.Forms.Label();
            this.txtcorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtdireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtapellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnaddimage = new System.Windows.Forms.Button();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.lblesta = new System.Windows.Forms.Label();
            this.txtestado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblmun = new System.Windows.Forms.Label();
            this.txtmunicipio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblfec = new System.Windows.Forms.Label();
            this.lblnamesexo = new System.Windows.Forms.Label();
            this.btnradioMasculino = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuRadioButton2 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.lblnamehom = new System.Windows.Forms.Label();
            this.lblnamese = new System.Windows.Forms.Label();
            this.lblnamecur = new System.Windows.Forms.Label();
            this.lblrfc = new System.Windows.Forms.Label();
            this.txtcurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtrfc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidempresa = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(361, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(99, 29);
            this.lbltitle.TabIndex = 37;
            this.lbltitle.Text = "Agregar";
            this.toolTipController1.SetTitle(this.lbltitle, "Nuevo empleado");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Correo:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(16, 210);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(65, 16);
            this.lbltel.TabIndex = 33;
            this.lbltel.Text = "Telefono:";
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldire.Location = new System.Drawing.Point(16, 140);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(68, 16);
            this.lbldire.TabIndex = 32;
            this.lbldire.Text = "Direccion:";
            // 
            // lblapell
            // 
            this.lblapell.AutoSize = true;
            this.lblapell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapell.Location = new System.Drawing.Point(432, 63);
            this.lblapell.Name = "lblapell";
            this.lblapell.Size = new System.Drawing.Size(61, 16);
            this.lblapell.TabIndex = 31;
            this.lblapell.Text = "Apellido:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcorreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcorreo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtcorreo.HintText = "Correo";
            this.txtcorreo.isPassword = false;
            this.txtcorreo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcorreo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcorreo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcorreo.LineThickness = 3;
            this.txtcorreo.Location = new System.Drawing.Point(435, 160);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.MaxLength = 50;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(391, 33);
            this.txtcorreo.TabIndex = 30;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtcorreo, "Correo");
            this.toolTipController1.SetToolTip(this.txtcorreo, "Correo empleado");
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(16, 63);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(60, 16);
            this.lblname.TabIndex = 29;
            this.lblname.Text = "Nombre:";
            // 
            // txtelefono
            // 
            this.txtelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtelefono.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtelefono.HintText = "Telefono";
            this.txtelefono.isPassword = false;
            this.txtelefono.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtelefono.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtelefono.LineThickness = 3;
            this.txtelefono.Location = new System.Drawing.Point(19, 239);
            this.txtelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtelefono.MaxLength = 12;
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(301, 33);
            this.txtelefono.TabIndex = 28;
            this.txtelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtelefono, "Telefono");
            this.toolTipController1.SetToolTip(this.txtelefono, "Numero Telefonico del empleado");
            this.txtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtelefono_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtdireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtdireccion.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdireccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtdireccion.HintText = "Direccion";
            this.txtdireccion.isPassword = false;
            this.txtdireccion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdireccion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdireccion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdireccion.LineThickness = 3;
            this.txtdireccion.Location = new System.Drawing.Point(19, 160);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.MaxLength = 100;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(363, 33);
            this.txtdireccion.TabIndex = 27;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtdireccion, "Direccion");
            this.toolTipController1.SetToolTip(this.txtdireccion, "Direcion del empleado");
            // 
            // txtapellido
            // 
            this.txtapellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtapellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtapellido.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtapellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtapellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtapellido.HintText = "Apellido";
            this.txtapellido.isPassword = false;
            this.txtapellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtapellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txtapellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtapellido.LineThickness = 3;
            this.txtapellido.Location = new System.Drawing.Point(435, 83);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.MaxLength = 50;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(391, 33);
            this.txtapellido.TabIndex = 26;
            this.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtapellido, "Apellido");
            this.toolTipController1.SetToolTip(this.txtapellido, "Apellido Empleado");
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombre.HintText = "Nombre";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombre.LineThickness = 3;
            this.txtnombre.Location = new System.Drawing.Point(19, 83);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(363, 33);
            this.txtnombre.TabIndex = 25;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtnombre, "Nombre");
            this.toolTipController1.SetToolTip(this.txtnombre, "Nombre Empleado");
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // btnaddimage
            // 
            this.btnaddimage.Location = new System.Drawing.Point(927, 118);
            this.btnaddimage.Name = "btnaddimage";
            this.btnaddimage.Size = new System.Drawing.Size(51, 23);
            this.btnaddimage.TabIndex = 38;
            this.btnaddimage.Text = "...";
            this.toolTipController1.SetTitle(this.btnaddimage, "Explorer image");
            this.toolTipController1.SetToolTip(this.btnaddimage, "Agregar foto empleado");
            this.btnaddimage.UseVisualStyleBackColor = true;
            this.btnaddimage.Click += new System.EventHandler(this.btnaddimage_Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.dateEdit1);
            this.bunifuShadowPanel1.Controls.Add(this.lblesta);
            this.bunifuShadowPanel1.Controls.Add(this.txtestado);
            this.bunifuShadowPanel1.Controls.Add(this.lblmun);
            this.bunifuShadowPanel1.Controls.Add(this.txtmunicipio);
            this.bunifuShadowPanel1.Controls.Add(this.btnguardar);
            this.bunifuShadowPanel1.Controls.Add(this.lblfec);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 405);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1011, 87);
            this.bunifuShadowPanel1.TabIndex = 39;
            // 
            // lblesta
            // 
            this.lblesta.AutoSize = true;
            this.lblesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblesta.Location = new System.Drawing.Point(602, 21);
            this.lblesta.Name = "lblesta";
            this.lblesta.Size = new System.Drawing.Size(56, 16);
            this.lblesta.TabIndex = 52;
            this.lblesta.Text = "Estado*";
            this.toolTipController1.SetTitle(this.lblesta, "Estado");
            // 
            // txtestado
            // 
            this.txtestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtestado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtestado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtestado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtestado.HintForeColor = System.Drawing.Color.Empty;
            this.txtestado.HintText = "Municipio";
            this.txtestado.isPassword = false;
            this.txtestado.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtestado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtestado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtestado.LineThickness = 3;
            this.txtestado.Location = new System.Drawing.Point(605, 41);
            this.txtestado.Margin = new System.Windows.Forms.Padding(4);
            this.txtestado.MaxLength = 30;
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(208, 33);
            this.txtestado.TabIndex = 51;
            this.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtestado, "Estado");
            this.toolTipController1.SetToolTip(this.txtestado, "Estado de nacimiento");
            this.txtestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox4_KeyPress);
            // 
            // lblmun
            // 
            this.lblmun.AutoSize = true;
            this.lblmun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmun.Location = new System.Drawing.Point(370, 21);
            this.lblmun.Name = "lblmun";
            this.lblmun.Size = new System.Drawing.Size(70, 16);
            this.lblmun.TabIndex = 50;
            this.lblmun.Text = "Municipio*";
            this.toolTipController1.SetTitle(this.lblmun, "Municipio");
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmunicipio.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmunicipio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmunicipio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmunicipio.HintForeColor = System.Drawing.Color.Empty;
            this.txtmunicipio.HintText = "Municipio";
            this.txtmunicipio.isPassword = false;
            this.txtmunicipio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtmunicipio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtmunicipio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtmunicipio.LineThickness = 3;
            this.txtmunicipio.Location = new System.Drawing.Point(373, 41);
            this.txtmunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtmunicipio.MaxLength = 30;
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(208, 33);
            this.txtmunicipio.TabIndex = 49;
            this.txtmunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtmunicipio, "Municipio");
            this.toolTipController1.SetToolTip(this.txtmunicipio, "Ciudad de Nacimiento");
            this.txtmunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox3_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Active = false;
            this.btnguardar.Activecolor = System.Drawing.Color.Gray;
            this.btnguardar.BackColor = System.Drawing.Color.Silver;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = -20;
            this.btnguardar.ButtonText = "      Guardar";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnguardar.Iconimage")));
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 90D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(833, 25);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.Silver;
            this.btnguardar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(166, 48);
            this.btnguardar.TabIndex = 36;
            this.btnguardar.Text = "      Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.SetTitle(this.btnguardar, "Guardar");
            this.toolTipController1.SetToolTip(this.btnguardar, "Guardar Empleado");
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblfec
            // 
            this.lblfec.AutoSize = true;
            this.lblfec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfec.Location = new System.Drawing.Point(16, 21);
            this.lblfec.Name = "lblfec";
            this.lblfec.Size = new System.Drawing.Size(122, 16);
            this.lblfec.TabIndex = 49;
            this.lblfec.Text = "Fecha Nacimiento*";
            this.toolTipController1.SetTitle(this.lblfec, "Fecha Nacimiento");
            // 
            // lblnamesexo
            // 
            this.lblnamesexo.AutoSize = true;
            this.lblnamesexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamesexo.Location = new System.Drawing.Point(437, 219);
            this.lblnamesexo.Name = "lblnamesexo";
            this.lblnamesexo.Size = new System.Drawing.Size(42, 16);
            this.lblnamesexo.TabIndex = 40;
            this.lblnamesexo.Text = "Sexo:";
            // 
            // btnradioMasculino
            // 
            this.btnradioMasculino.Checked = true;
            this.btnradioMasculino.Location = new System.Drawing.Point(435, 247);
            this.btnradioMasculino.Name = "btnradioMasculino";
            this.btnradioMasculino.OutlineColor = System.Drawing.Color.Purple;
            this.btnradioMasculino.RadioColor = System.Drawing.Color.Purple;
            this.btnradioMasculino.Size = new System.Drawing.Size(25, 25);
            this.btnradioMasculino.TabIndex = 41;
            this.btnradioMasculino.Text = null;
            this.toolTipController1.SetTitle(this.btnradioMasculino, "Hombre");
            // 
            // bunifuRadioButton2
            // 
            this.bunifuRadioButton2.Checked = false;
            this.bunifuRadioButton2.Location = new System.Drawing.Point(562, 246);
            this.bunifuRadioButton2.Name = "bunifuRadioButton2";
            this.bunifuRadioButton2.OutlineColor = System.Drawing.Color.Purple;
            this.bunifuRadioButton2.RadioColor = System.Drawing.Color.Purple;
            this.bunifuRadioButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuRadioButton2.TabIndex = 42;
            this.bunifuRadioButton2.Text = null;
            this.toolTipController1.SetTitle(this.bunifuRadioButton2, "Mujer");
            // 
            // lblnamehom
            // 
            this.lblnamehom.AutoSize = true;
            this.lblnamehom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamehom.Location = new System.Drawing.Point(468, 249);
            this.lblnamehom.Name = "lblnamehom";
            this.lblnamehom.Size = new System.Drawing.Size(57, 16);
            this.lblnamehom.TabIndex = 43;
            this.lblnamehom.Text = "Hombre";
            this.toolTipController1.SetTitle(this.lblnamehom, "Hombre");
            this.toolTipController1.SetToolTip(this.lblnamehom, "Sexo Masculino");
            // 
            // lblnamese
            // 
            this.lblnamese.AutoSize = true;
            this.lblnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamese.Location = new System.Drawing.Point(593, 249);
            this.lblnamese.Name = "lblnamese";
            this.lblnamese.Size = new System.Drawing.Size(41, 16);
            this.lblnamese.TabIndex = 44;
            this.lblnamese.Text = "Mujer";
            this.toolTipController1.SetTitle(this.lblnamese, "Mujer");
            this.toolTipController1.SetToolTip(this.lblnamese, "Sexo Femenino");
            // 
            // lblnamecur
            // 
            this.lblnamecur.AutoSize = true;
            this.lblnamecur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamecur.Location = new System.Drawing.Point(437, 291);
            this.lblnamecur.Name = "lblnamecur";
            this.lblnamecur.Size = new System.Drawing.Size(49, 16);
            this.lblnamecur.TabIndex = 48;
            this.lblnamecur.Text = "CURP:";
            // 
            // lblrfc
            // 
            this.lblrfc.AutoSize = true;
            this.lblrfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrfc.Location = new System.Drawing.Point(16, 299);
            this.lblrfc.Name = "lblrfc";
            this.lblrfc.Size = new System.Drawing.Size(38, 16);
            this.lblrfc.TabIndex = 47;
            this.lblrfc.Text = "RFC:";
            // 
            // txtcurp
            // 
            this.txtcurp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcurp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcurp.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcurp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcurp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcurp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcurp.HintForeColor = System.Drawing.Color.Empty;
            this.txtcurp.HintText = "CURP";
            this.txtcurp.isPassword = false;
            this.txtcurp.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcurp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcurp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcurp.LineThickness = 3;
            this.txtcurp.Location = new System.Drawing.Point(435, 311);
            this.txtcurp.Margin = new System.Windows.Forms.Padding(4);
            this.txtcurp.MaxLength = 18;
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(323, 33);
            this.txtcurp.TabIndex = 46;
            this.txtcurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtrfc
            // 
            this.txtrfc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtrfc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtrfc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtrfc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrfc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtrfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrfc.HintForeColor = System.Drawing.Color.Empty;
            this.txtrfc.HintText = "RFC";
            this.txtrfc.isPassword = false;
            this.txtrfc.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtrfc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtrfc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtrfc.LineThickness = 3;
            this.txtrfc.Location = new System.Drawing.Point(19, 311);
            this.txtrfc.Margin = new System.Windows.Forms.Padding(4);
            this.txtrfc.MaxLength = 13;
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(301, 33);
            this.txtrfc.TabIndex = 45;
            this.txtrfc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtrfc, "RFC");
            this.toolTipController1.SetToolTip(this.txtrfc, "RFC del empleado");
            this.txtrfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrfc_KeyPress);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(899, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 35;
            this.bunifuPictureBox1.TabStop = false;
            this.toolTipController1.SetTitle(this.bunifuPictureBox1, "Image empleado");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(12, 12);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(56, 13);
            this.lblidcliente.TabIndex = 49;
            this.lblidcliente.Text = "ID Cliente:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(84, 12);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Puesto:";
            // 
            // lblidempresa
            // 
            this.lblidempresa.AutoSize = true;
            this.lblidempresa.Location = new System.Drawing.Point(19, 29);
            this.lblidempresa.Name = "lblidempresa";
            this.lblidempresa.Size = new System.Drawing.Size(35, 13);
            this.lblidempresa.TabIndex = 53;
            this.lblidempresa.Text = "label2";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(22, 379);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 54;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(22, 53);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 53;
            // 
            // frmaddempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 492);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.lblidempresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.lblnamecur);
            this.Controls.Add(this.lblrfc);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.lblnamese);
            this.Controls.Add(this.lblnamehom);
            this.Controls.Add(this.bunifuRadioButton2);
            this.Controls.Add(this.btnradioMasculino);
            this.Controls.Add(this.lblnamesexo);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.btnaddimage);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lbldire);
            this.Controls.Add(this.lblapell);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmaddempleado";
            this.Text = "Agregar Empleado";
            this.Load += new System.EventHandler(this.frmaddempleado_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Button btnaddimage;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label lbltitle;
        public Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbltel;
        public System.Windows.Forms.Label lbldire;
        public System.Windows.Forms.Label lblapell;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcorreo;
        public System.Windows.Forms.Label lblname;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtdireccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtapellido;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        public Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        public System.Windows.Forms.Label lblnamesexo;
        public Bunifu.UI.WinForms.BunifuRadioButton btnradioMasculino;
        public Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton2;
        public System.Windows.Forms.Label lblnamehom;
        public System.Windows.Forms.Label lblnamese;
        public System.Windows.Forms.Label lblnamecur;
        public System.Windows.Forms.Label lblrfc;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcurp;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtrfc;
        public System.Windows.Forms.Label lblmun;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtmunicipio;
        public System.Windows.Forms.Label lblfec;
        public System.Windows.Forms.Label lblesta;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtestado;
        public System.Windows.Forms.Label lblidcliente;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidempresa;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}