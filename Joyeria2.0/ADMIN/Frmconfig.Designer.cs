namespace Joyeria2._0
{
    partial class Frmconfig
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
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.btnfrmcondifg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnfrmcondifg
            // 
            this.btnfrmcondifg.Active = false;
            this.btnfrmcondifg.Activecolor = System.Drawing.Color.Gray;
            this.btnfrmcondifg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnfrmcondifg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfrmcondifg.BorderRadius = -20;
            this.btnfrmcondifg.ButtonText = "    Reportes de Logins";
            this.btnfrmcondifg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfrmcondifg.DisabledColor = System.Drawing.Color.Gray;
            this.btnfrmcondifg.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfrmcondifg.Iconimage = global::Joyeria2._0.Properties.Resources.periodico1;
            this.btnfrmcondifg.Iconimage_right = null;
            this.btnfrmcondifg.Iconimage_right_Selected = null;
            this.btnfrmcondifg.Iconimage_Selected = null;
            this.btnfrmcondifg.IconMarginLeft = 0;
            this.btnfrmcondifg.IconMarginRight = 0;
            this.btnfrmcondifg.IconRightVisible = true;
            this.btnfrmcondifg.IconRightZoom = 0D;
            this.btnfrmcondifg.IconVisible = true;
            this.btnfrmcondifg.IconZoom = 40D;
            this.btnfrmcondifg.IsTab = false;
            this.btnfrmcondifg.Location = new System.Drawing.Point(12, 12);
            this.btnfrmcondifg.Name = "btnfrmcondifg";
            this.btnfrmcondifg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnfrmcondifg.OnHovercolor = System.Drawing.Color.Silver;
            this.btnfrmcondifg.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnfrmcondifg.selected = false;
            this.btnfrmcondifg.Size = new System.Drawing.Size(190, 48);
            this.btnfrmcondifg.TabIndex = 12;
            this.btnfrmcondifg.Text = "    Reportes de Logins";
            this.btnfrmcondifg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmcondifg.Textcolor = System.Drawing.Color.Black;
            this.btnfrmcondifg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.SetTitle(this.btnfrmcondifg, "Configuraciones");
            this.btnfrmcondifg.Click += new System.EventHandler(this.btnfrmcondifg_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 266);
            this.panel1.TabIndex = 13;
            // 
            // Frmconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnfrmcondifg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmconfig";
            this.Text = "Configuracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ToolTipController toolTipController1;
        private Bunifu.Framework.UI.BunifuFlatButton btnfrmcondifg;
        private System.Windows.Forms.Panel panel1;
    }
}