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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.lblhoras = new System.Windows.Forms.Label();
            this.lblprimerafecha = new System.Windows.Forms.Label();
            this.btnreporte = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnaceptar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tmrss = new System.Windows.Forms.Timer(this.components);
            this.date1 = new DevExpress.XtraEditors.DateEdit();
            this.date2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.tmriniciar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnreporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties.CalendarTimeProperties)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblhoras
            // 
            this.lblhoras.AutoSize = true;
            this.lblhoras.Location = new System.Drawing.Point(397, 13);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(62, 13);
            this.lblhoras.TabIndex = 11;
            this.lblhoras.Text = "FechaInicio";
            this.toolTipController1.SetTitle(this.lblhoras, "FechaIncio");
            this.lblhoras.Visible = false;
            // 
            // lblprimerafecha
            // 
            this.lblprimerafecha.AutoSize = true;
            this.lblprimerafecha.Location = new System.Drawing.Point(465, 13);
            this.lblprimerafecha.Name = "lblprimerafecha";
            this.lblprimerafecha.Size = new System.Drawing.Size(59, 13);
            this.lblprimerafecha.TabIndex = 12;
            this.lblprimerafecha.Text = "FechaFinal";
            this.toolTipController1.SetTitle(this.lblprimerafecha, "Fecha Final");
            this.lblprimerafecha.Visible = false;
            // 
            // btnreporte
            // 
            this.btnreporte.Image = global::Joyeria2._0.Properties.Resources.informe_seo;
            this.btnreporte.ImageActive = null;
            this.btnreporte.Location = new System.Drawing.Point(702, 5);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(34, 34);
            this.btnreporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnreporte.TabIndex = 13;
            this.btnreporte.TabStop = false;
            this.toolTipController1.SetTitle(this.btnreporte, "Concretar Apartado");
            this.btnreporte.Zoom = 10;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = global::Joyeria2._0.Properties.Resources.accepted_notes_icon_icons_com_71535;
            this.btnaceptar.ImageActive = null;
            this.btnaceptar.Location = new System.Drawing.Point(748, 5);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(34, 34);
            this.btnaceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnaceptar.TabIndex = 9;
            this.btnaceptar.TabStop = false;
            this.toolTipController1.SetTitle(this.btnaceptar, "Concretar Apartado");
            this.btnaceptar.Zoom = 10;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
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
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(845, 401);
            this.dataGridView1.TabIndex = 8;
            this.toolTipController1.SetTitle(this.dataGridView1, "Apartados");
            // 
            // tmrss
            // 
            this.tmrss.Enabled = true;
            // 
            // date1
            // 
            this.date1.EditValue = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            this.date1.Location = new System.Drawing.Point(31, 17);
            this.date1.Name = "date1";
            // 
            // 
            // 
            this.date1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Properties.Appearance.Options.UseFont = true;
            this.date1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.date1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date1.Size = new System.Drawing.Size(100, 22);
            this.date1.TabIndex = 4;
            this.date1.ToolTipTitle = "Fecha 1";
            this.date1.Visible = false;
            // 
            // date2
            // 
            this.date2.EditValue = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            this.date2.Location = new System.Drawing.Point(161, 17);
            this.date2.Name = "date2";
            // 
            // 
            // 
            this.date2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Properties.Appearance.Options.UseFont = true;
            this.date2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.date2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date2.Size = new System.Drawing.Size(100, 22);
            this.date2.TabIndex = 5;
            this.date2.ToolTipTitle = "Fecha 2";
            this.date2.Visible = false;
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
            this.labelControl2.Visible = false;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.lblID);
            this.bunifuShadowPanel1.Controls.Add(this.btnreporte);
            this.bunifuShadowPanel1.Controls.Add(this.lblprimerafecha);
            this.bunifuShadowPanel1.Controls.Add(this.lblhoras);
            this.bunifuShadowPanel1.Controls.Add(this.btnaceptar);
            this.bunifuShadowPanel1.Controls.Add(this.date1);
            this.bunifuShadowPanel1.Controls.Add(this.date2);
            this.bunifuShadowPanel1.Controls.Add(this.labelControl2);
            this.bunifuShadowPanel1.Controls.Add(this.btneliminar);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(845, 49);
            this.bunifuShadowPanel1.TabIndex = 4;
            this.bunifuShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuShadowPanel1_Paint);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(598, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 17;
            // 
            // tmriniciar
            // 
            this.tmriniciar.Enabled = true;
            this.tmriniciar.Interval = 2;
            this.tmriniciar.Tick += new System.EventHandler(this.tmriniciar_Tick);
            // 
            // Frmapartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmapartado";
            this.Text = "Frmapartado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmapartado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnreporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2.Properties)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Timer tmrss;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private DevExpress.XtraEditors.DateEdit date1;
        private DevExpress.XtraEditors.DateEdit date2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.Framework.UI.BunifuImageButton btnaceptar;
        private System.Windows.Forms.Label lblhoras;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label lblprimerafecha;
        private Bunifu.Framework.UI.BunifuImageButton btnreporte;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Timer tmriniciar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}