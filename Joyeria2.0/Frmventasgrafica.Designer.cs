namespace Joyeria2._0
{
    partial class Frmventasgrafica
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
            this.dtaegra = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.DGCrafic = new DevExpress.XtraDiagram.DiagramControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtaegra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaegra.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCrafic)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaegra
            // 
            this.dtaegra.EditValue = null;
            this.dtaegra.Location = new System.Drawing.Point(240, 28);
            this.dtaegra.Name = "dtaegra";
            this.dtaegra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaegra.Properties.Appearance.Options.UseFont = true;
            this.dtaegra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaegra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaegra.Size = new System.Drawing.Size(204, 22);
            this.dtaegra.TabIndex = 0;
            this.dtaegra.ToolTipTitle = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(309, 9);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(46, 16);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha";
            this.toolTipController1.SetTitle(this.lblfecha, "Fecha");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGCrafic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 243);
            this.panel1.TabIndex = 3;
            // 
            // DGCrafic
            // 
            this.DGCrafic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCrafic.Location = new System.Drawing.Point(0, 0);
            this.DGCrafic.Name = "DGCrafic";
            this.DGCrafic.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.DGCrafic.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.DGCrafic.Size = new System.Drawing.Size(702, 241);
            this.DGCrafic.TabIndex = 0;
            this.DGCrafic.ToolTip = "Grafica";
            // 
            // Frmventasgrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaegra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmventasgrafica";
            this.Text = "Grafica Ventas";
            this.toolTipController1.SetTitle(this, "Ventas");
            ((System.ComponentModel.ISupportInitialize)(this.dtaegra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaegra.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGCrafic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtaegra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraDiagram.DiagramControl DGCrafic;
    }
}