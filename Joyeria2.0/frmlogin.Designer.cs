namespace Joyeria2._0
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.txtuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbluser = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblpass = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnsesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtuser.AutoSize = true;
            this.txtuser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuser.HintForeColor = System.Drawing.Color.Empty;
            this.txtuser.HintText = "Usuario";
            this.txtuser.isPassword = false;
            this.txtuser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtuser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtuser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtuser.LineThickness = 3;
            this.txtuser.Location = new System.Drawing.Point(126, 92);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.MaxLength = 15;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(239, 33);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtuser, "Usuario");
            // 
            // txtpass
            // 
            this.txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpass.AutoSize = true;
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
            this.txtpass.Location = new System.Drawing.Point(127, 168);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 15;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(238, 33);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtpass, "Contraseña");
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // lbluser
            // 
            this.lbluser.AutoEllipsis = false;
            this.lbluser.CursorType = null;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(44, 107);
            this.lbluser.Name = "lbluser";
            this.lbluser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbluser.Size = new System.Drawing.Size(53, 18);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "Usuario:";
            this.lbluser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.lbluser, "Usuario");
            // 
            // lblpass
            // 
            this.lblpass.AutoEllipsis = false;
            this.lblpass.CursorType = null;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(22, 183);
            this.lblpass.Name = "lblpass";
            this.lblpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblpass.Size = new System.Drawing.Size(75, 18);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "Contraseña:";
            this.lblpass.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.lblpass, "Contraseña");
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 40;
            this.bunifuPictureBox1.Image = global::Joyeria2._0.Properties.Resources.desprotegido__2_;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(198, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(81, 81);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 5;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // btnsesion
            // 
            this.btnsesion.ActiveBorderThickness = 1;
            this.btnsesion.ActiveCornerRadius = 20;
            this.btnsesion.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnsesion.ActiveForecolor = System.Drawing.Color.White;
            this.btnsesion.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnsesion.AutoSize = true;
            this.btnsesion.BackColor = System.Drawing.SystemColors.Control;
            this.btnsesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsesion.BackgroundImage")));
            this.btnsesion.ButtonText = "Iniciar sesion";
            this.btnsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsesion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnsesion.IdleBorderThickness = 1;
            this.btnsesion.IdleCornerRadius = 20;
            this.btnsesion.IdleFillColor = System.Drawing.Color.White;
            this.btnsesion.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnsesion.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnsesion.Location = new System.Drawing.Point(142, 210);
            this.btnsesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnsesion.Name = "btnsesion";
            this.btnsesion.Size = new System.Drawing.Size(181, 41);
            this.btnsesion.TabIndex = 4;
            this.btnsesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnsesion, "Iniciar Sesion");
            this.btnsesion.Click += new System.EventHandler(this.btnsesion_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 280);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btnsesion);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmlogin";
            this.Text = "Login Joyeria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtuser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private Bunifu.UI.WinForms.BunifuLabel lbluser;
        private Bunifu.UI.WinForms.BunifuLabel lblpass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsesion;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tmr;
    }
}