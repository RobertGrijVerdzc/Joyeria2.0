namespace Joyeria2._0
{
    partial class Frmventasadmin
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
            this.lblid = new System.Windows.Forms.Label();
            this.btnnewfrmventas = new System.Windows.Forms.Button();
            this.btnewfrmgrafica = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.bunifuShadowPanel1.Controls.Add(this.lblid);
            this.bunifuShadowPanel1.Controls.Add(this.btnnewfrmventas);
            this.bunifuShadowPanel1.Controls.Add(this.btnewfrmgrafica);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.Controls.Add(this.labelControl2);
            this.bunifuShadowPanel1.Controls.Add(this.labelControl1);
            this.bunifuShadowPanel1.Controls.Add(this.dateEdit2);
            this.bunifuShadowPanel1.Controls.Add(this.dateEdit1);
            this.bunifuShadowPanel1.Controls.Add(this.btneliminar);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(851, 49);
            this.bunifuShadowPanel1.TabIndex = 3;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(512, 12);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 11;
            this.lblid.Text = "label2";
            // 
            // btnnewfrmventas
            // 
            this.btnnewfrmventas.Location = new System.Drawing.Point(356, 12);
            this.btnnewfrmventas.Name = "btnnewfrmventas";
            this.btnnewfrmventas.Size = new System.Drawing.Size(112, 23);
            this.btnnewfrmventas.TabIndex = 10;
            this.btnnewfrmventas.Text = "Punto de venta";
            this.toolTipController1.SetTitle(this.btnnewfrmventas, "Ventana Ventas");
            this.toolTipController1.SetToolTip(this.btnnewfrmventas, "Se habrira la ventana de Ventas");
            this.btnnewfrmventas.UseVisualStyleBackColor = true;
            this.btnnewfrmventas.Click += new System.EventHandler(this.btnnewfrmventas_Click);
            // 
            // btnewfrmgrafica
            // 
            this.btnewfrmgrafica.Location = new System.Drawing.Point(663, 12);
            this.btnewfrmgrafica.Name = "btnewfrmgrafica";
            this.btnewfrmgrafica.Size = new System.Drawing.Size(75, 23);
            this.btnewfrmgrafica.TabIndex = 9;
            this.btnewfrmgrafica.Text = "Grafica";
            this.btnewfrmgrafica.ToolTip = "Graficas de ventas";
            this.btnewfrmgrafica.Click += new System.EventHandler(this.btnewfrmgrafica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busqueda por fecha";
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
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(161, 17);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 22);
            this.dateEdit2.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(31, 17);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 22);
            this.dateEdit1.TabIndex = 4;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Joyeria2._0.Properties.Resources.delete_4219__1_;
            this.btneliminar.ImageActive = null;
            this.btneliminar.Location = new System.Drawing.Point(754, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(34, 34);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneliminar.TabIndex = 3;
            this.btneliminar.TabStop = false;
            this.toolTipController1.SetTitle(this.btneliminar, "Eliminar Venta");
            this.btneliminar.Zoom = 10;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::Joyeria2._0.Properties.Resources.circle_edit_article_icon_icons_com_66938;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(805, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.toolTipController1.SetTitle(this.bunifuImageButton1, "Editar Venta");
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.LightCyan;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(851, 49);
            this.bunifuCustomDataGrid1.TabIndex = 12;
            // 
            // Frmventasadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmventasadmin";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmventasadmin_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnewfrmgrafica;
        private System.Windows.Forms.Button btnnewfrmventas;
        private System.Windows.Forms.Label lblid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}