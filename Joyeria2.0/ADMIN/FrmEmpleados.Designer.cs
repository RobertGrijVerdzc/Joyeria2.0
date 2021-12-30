namespace Joyeria2._0
{
    partial class FrmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.lblid = new System.Windows.Forms.Label();
            this.btnedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfrmaddemplezdo = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrmaddemplezdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.lblid);
            this.bunifuShadowPanel1.Controls.Add(this.btnedit);
            this.bunifuShadowPanel1.Controls.Add(this.btneliminar);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.Controls.Add(this.btnfrmaddemplezdo);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(851, 49);
            this.bunifuShadowPanel1.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(466, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Visible = false;
            // 
            // btnedit
            // 
            this.btnedit.Image = global::Joyeria2._0.Properties.Resources.editinguser_edituser_useedit_4520;
            this.btnedit.ImageActive = null;
            this.btnedit.Location = new System.Drawing.Point(805, 3);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(34, 34);
            this.btnedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnedit.TabIndex = 4;
            this.btnedit.TabStop = false;
            this.btnedit.Zoom = 10;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
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
            this.btneliminar.Zoom = 10;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Empleado:";
            // 
            // btnfrmaddemplezdo
            // 
            this.btnfrmaddemplezdo.Image = global::Joyeria2._0.Properties.Resources.adduser_añadir_3553;
            this.btnfrmaddemplezdo.ImageActive = null;
            this.btnfrmaddemplezdo.Location = new System.Drawing.Point(135, 6);
            this.btnfrmaddemplezdo.Name = "btnfrmaddemplezdo";
            this.btnfrmaddemplezdo.Size = new System.Drawing.Size(34, 34);
            this.btnfrmaddemplezdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfrmaddemplezdo.TabIndex = 0;
            this.btnfrmaddemplezdo.TabStop = false;
            this.btnfrmaddemplezdo.Zoom = 10;
            this.btnfrmaddemplezdo.Click += new System.EventHandler(this.btnfrmaddemplezdo_Click);
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 49);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(851, 401);
            this.bunifuCustomDataGrid1.TabIndex = 4;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrmaddemplezdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnfrmaddemplezdo;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnedit;
        private System.Windows.Forms.Label lblid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}