namespace Joyeria2._0
{
    partial class Frmapartado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.btnaceptar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblnamfecha = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date2 = new DevExpress.XtraEditors.DateEdit();
            this.date1 = new DevExpress.XtraEditors.DateEdit();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnaceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.btnaceptar);
            this.bunifuShadowPanel1.Controls.Add(this.lblnamfecha);
            this.bunifuShadowPanel1.Controls.Add(this.labelControl2);
            this.bunifuShadowPanel1.Controls.Add(this.labelControl1);
            this.bunifuShadowPanel1.Controls.Add(this.date2);
            this.bunifuShadowPanel1.Controls.Add(this.date1);
            this.bunifuShadowPanel1.Controls.Add(this.btneliminar);
            this.bunifuShadowPanel1.Controls.Add(this.btneditar);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(845, 49);
            this.bunifuShadowPanel1.TabIndex = 4;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = global::Joyeria2._0.Properties.Resources.accepted_notes_icon_icons_com_71535;
            this.btnaceptar.ImageActive = null;
            this.btnaceptar.Location = new System.Drawing.Point(691, 5);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(34, 34);
            this.btnaceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnaceptar.TabIndex = 9;
            this.btnaceptar.TabStop = false;
            this.toolTipController1.SetTitle(this.btnaceptar, "Concretar Apartado");
            this.btnaceptar.Zoom = 10;
            // 
            // lblnamfecha
            // 
            this.lblnamfecha.AutoSize = true;
            this.lblnamfecha.Location = new System.Drawing.Point(89, 3);
            this.lblnamfecha.Name = "lblnamfecha";
            this.lblnamfecha.Size = new System.Drawing.Size(103, 13);
            this.lblnamfecha.TabIndex = 8;
            this.lblnamfecha.Text = "Busqueda por fecha";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(148, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "A";
            this.labelControl2.ToolTipTitle = "A";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "De";
            this.labelControl1.ToolTipTitle = "De";
            // 
            // date2
            // 
            this.date2.EditValue = null;
            this.date2.Location = new System.Drawing.Point(161, 17);
            this.date2.Name = "date2";
            this.date2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Properties.Appearance.Options.UseFont = true;
            this.date2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2.Size = new System.Drawing.Size(100, 22);
            this.date2.TabIndex = 5;
            this.date2.ToolTipTitle = "Fecha 2";
            // 
            // date1
            // 
            this.date1.EditValue = null;
            this.date1.Location = new System.Drawing.Point(31, 17);
            this.date1.Name = "date1";
            this.date1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Properties.Appearance.Options.UseFont = true;
            this.date1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date1.Size = new System.Drawing.Size(100, 22);
            this.date1.TabIndex = 4;
            this.date1.ToolTipTitle = "Fecha 1";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Joyeria2._0.Properties.Resources.delete_4219__1_;
            this.btneliminar.ImageActive = null;
            this.btneliminar.Location = new System.Drawing.Point(799, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(34, 34);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneliminar.TabIndex = 3;
            this.btneliminar.TabStop = false;
            this.toolTipController1.SetTitle(this.btneliminar, "Eliminar Apartado");
            this.btneliminar.Zoom = 10;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Joyeria2._0.Properties.Resources.circle_edit_article_icon_icons_com_66938;
            this.btneditar.ImageActive = null;
            this.btneditar.Location = new System.Drawing.Point(745, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(34, 34);
            this.btneditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneditar.TabIndex = 2;
            this.btneditar.TabStop = false;
            this.toolTipController1.SetTitle(this.btneditar, "Editar Apartado");
            this.btneditar.Zoom = 10;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 49);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(845, 401);
            this.bunifuCustomDataGrid1.TabIndex = 5;
            // 
            // Frmapartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmapartado";
            this.Text = "Frmapartado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnaceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label lblnamfecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit date2;
        private DevExpress.XtraEditors.DateEdit date1;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private Bunifu.Framework.UI.BunifuImageButton btneditar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private Bunifu.Framework.UI.BunifuImageButton btnaceptar;
    }
}