namespace Joyeria2._0
{
    partial class Frmaddacceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaddacceso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(80, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 20);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "idempleado";
            this.toolTipController1.SetTitle(this.lblid, "ID Empleado");
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(81, 68);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 20);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "lblname";
            this.toolTipController1.SetTitle(this.lblname, "Nombre Empleado");
            // 
            // txtpass
            // 
            this.txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.HintForeColor = System.Drawing.Color.Empty;
            this.txtpass.HintText = "Contraseña";
            this.txtpass.isPassword = true;
            this.txtpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpass.LineThickness = 3;
            this.txtpass.Location = new System.Drawing.Point(82, 160);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 10;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(155, 33);
            this.txtpass.TabIndex = 6;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtpass, "Contraseña");
            // 
            // btnguardar
            // 
            this.btnguardar.Active = false;
            this.btnguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = -10;
            this.btnguardar.ButtonText = "Guardar";
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
            this.btnguardar.Location = new System.Drawing.Point(116, 212);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(121, 48);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.SetTitle(this.btnguardar, "Guardar");
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbtipo.Location = new System.Drawing.Point(82, 112);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 21);
            this.cmbtipo.TabIndex = 9;
            this.toolTipController1.SetTitle(this.cmbtipo, "Tipo de Acceso");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "1: Admin";
            this.toolTipController1.SetTitle(this.label5, "Admin");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "2: Ventas";
            this.toolTipController1.SetTitle(this.label6, "Ventas");
            // 
            // Frmaddacceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 272);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmaddacceso";
            this.Text = "Agregar Acceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmaddacceso_FormClosing);
            this.Load += new System.EventHandler(this.Frmaddacceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}