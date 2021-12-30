namespace Joyeria2._0
{
    partial class Frmcrysclientes
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
            this.cryreportecliente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportclientes1 = new Joyeria2._0.CrystalReportclientes();
            this.SuspendLayout();
            // 
            // cryreportecliente
            // 
            this.cryreportecliente.ActiveViewIndex = 0;
            this.cryreportecliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryreportecliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryreportecliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryreportecliente.Location = new System.Drawing.Point(0, 0);
            this.cryreportecliente.Name = "cryreportecliente";
            this.cryreportecliente.ReportSource = this.CrystalReportclientes1;
            this.cryreportecliente.Size = new System.Drawing.Size(800, 450);
            this.cryreportecliente.TabIndex = 0;
            // 
            // Frmcrysclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryreportecliente);
            this.Name = "Frmcrysclientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryreportecliente;
        private CrystalReportclientes CrystalReportclientes1;
    }
}