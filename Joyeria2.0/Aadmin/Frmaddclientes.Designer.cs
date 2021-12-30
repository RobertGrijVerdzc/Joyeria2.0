namespace Joyeria2._0
{
    partial class Frmaddclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaddclientes));
            this.lblcor = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbldire = new System.Windows.Forms.Label();
            this.lblapell = new System.Windows.Forms.Label();
            this.txtcorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtdireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtapellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.lblid = new System.Windows.Forms.Label();
            this.lbldatos = new System.Windows.Forms.Label();
            this.btnguardarclientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcor.Location = new System.Drawing.Point(41, 275);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(52, 16);
            this.lblcor.TabIndex = 21;
            this.lblcor.Text = "Correo:";
            this.toolTipController1.SetTitle(this.lblcor, "Correo");
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(28, 344);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(65, 16);
            this.lbltel.TabIndex = 20;
            this.lbltel.Text = "Telefono:";
            this.toolTipController1.SetTitle(this.lbltel, "Telefono");
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldire.Location = new System.Drawing.Point(33, 202);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(68, 16);
            this.lbldire.TabIndex = 19;
            this.lbldire.Text = "Direccion:";
            this.toolTipController1.SetTitle(this.lbldire, "Direccion");
            // 
            // lblapell
            // 
            this.lblapell.AutoSize = true;
            this.lblapell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapell.Location = new System.Drawing.Point(41, 134);
            this.lblapell.Name = "lblapell";
            this.lblapell.Size = new System.Drawing.Size(61, 16);
            this.lblapell.TabIndex = 18;
            this.lblapell.Text = "Apellido:";
            this.toolTipController1.SetTitle(this.lblapell, "Apellido");
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
            this.txtcorreo.Location = new System.Drawing.Point(120, 258);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.MaxLength = 30;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(364, 33);
            this.txtcorreo.TabIndex = 17;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtcorreo, "E-mail");
            this.toolTipController1.SetToolTip(this.txtcorreo, "Correo electronico");
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(41, 68);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(60, 16);
            this.lblname.TabIndex = 16;
            this.lblname.Text = "Nombre:";
            this.toolTipController1.SetTitle(this.lblname, "Nombre");
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
            this.txtelefono.Location = new System.Drawing.Point(120, 327);
            this.txtelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtelefono.MaxLength = 12;
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(259, 33);
            this.txtelefono.TabIndex = 18;
            this.txtelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtelefono, "Telefono");
            this.toolTipController1.SetToolTip(this.txtelefono, "Numero Telefonico cliente");
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
            this.txtdireccion.Location = new System.Drawing.Point(120, 185);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.MaxLength = 30;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(364, 33);
            this.txtdireccion.TabIndex = 14;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetToolTip(this.txtdireccion, "Direccion Cliente");
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
            this.txtapellido.Location = new System.Drawing.Point(120, 117);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.MaxLength = 30;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(364, 33);
            this.txtapellido.TabIndex = 13;
            this.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetToolTip(this.txtapellido, "Apellido Cliente");
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
            this.txtnombre.Location = new System.Drawing.Point(120, 51);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(364, 33);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetToolTip(this.txtnombre, "Nombre Cliente");
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(217, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(99, 29);
            this.lbltitle.TabIndex = 24;
            this.lbltitle.Text = "Agregar";
            this.toolTipController1.SetToolTip(this.lbltitle, "Nuevo Cliente");
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(66, 25);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 25;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(12, 9);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(56, 13);
            this.lbldatos.TabIndex = 26;
            this.lbldatos.Text = "ID Cliente:";
            this.lbldatos.Visible = false;
            // 
            // btnguardarclientes
            // 
            this.btnguardarclientes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnguardarclientes.Location = new System.Drawing.Point(167, 398);
            this.btnguardarclientes.Name = "btnguardarclientes";
            this.btnguardarclientes.Size = new System.Drawing.Size(198, 40);
            this.btnguardarclientes.TabIndex = 27;
            this.btnguardarclientes.Text = "Guardar";
            this.toolTipController1.SetTitle(this.btnguardarclientes, "Guardar");
            this.btnguardarclientes.UseVisualStyleBackColor = true;
            this.btnguardarclientes.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Frmaddclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnguardarclientes);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lbldire);
            this.Controls.Add(this.lblapell);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmaddclientes";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.Frmaddclientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.Label lblapell;
        private System.Windows.Forms.Label lblname;
        private DevExpress.Utils.ToolTipController toolTipController1;
        public System.Windows.Forms.Label lbltitle;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.Label lbldatos;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcorreo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtdireccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtapellido;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        public System.Windows.Forms.Button btnguardarclientes;
    }
}