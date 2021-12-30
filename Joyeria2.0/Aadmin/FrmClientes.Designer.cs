namespace Joyeria2._0
{
    partial class FrmClientes
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
            this.btninforme = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnbuscarcliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnelimimnar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneditclien = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblnameclie = new System.Windows.Forms.Label();
            this.btnfrmaddcliente = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnelimimnar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditclien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrmaddcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.btninforme);
            this.bunifuShadowPanel1.Controls.Add(this.btnbuscarcliente);
            this.bunifuShadowPanel1.Controls.Add(this.lblID);
            this.bunifuShadowPanel1.Controls.Add(this.btnelimimnar);
            this.bunifuShadowPanel1.Controls.Add(this.btneditclien);
            this.bunifuShadowPanel1.Controls.Add(this.lblnameclie);
            this.bunifuShadowPanel1.Controls.Add(this.btnfrmaddcliente);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(851, 49);
            this.bunifuShadowPanel1.TabIndex = 0;
            this.toolTipController1.SetTitle(this.bunifuShadowPanel1, "Eliminar Cliente");
            // 
            // btninforme
            // 
            this.btninforme.Image = global::Joyeria2._0.Properties.Resources.informe_seo;
            this.btninforme.ImageActive = null;
            this.btninforme.Location = new System.Drawing.Point(705, 3);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(34, 34);
            this.btninforme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninforme.TabIndex = 8;
            this.btninforme.TabStop = false;
            this.toolTipController1.SetTitle(this.btninforme, "Eliminar cliente");
            this.btninforme.Zoom = 10;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.btnbuscarcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.btnbuscarcliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbuscarcliente.HintForeColor = System.Drawing.Color.Empty;
            this.btnbuscarcliente.HintText = "Buscar Cliente";
            this.btnbuscarcliente.isPassword = false;
            this.btnbuscarcliente.LineFocusedColor = System.Drawing.Color.Blue;
            this.btnbuscarcliente.LineIdleColor = System.Drawing.Color.Gray;
            this.btnbuscarcliente.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btnbuscarcliente.LineThickness = 3;
            this.btnbuscarcliente.Location = new System.Drawing.Point(229, 6);
            this.btnbuscarcliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarcliente.MaxLength = 20;
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(379, 33);
            this.btnbuscarcliente.TabIndex = 7;
            this.btnbuscarcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnbuscarcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnbuscarcliente_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(652, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Visible = false;
            // 
            // btnelimimnar
            // 
            this.btnelimimnar.Image = global::Joyeria2._0.Properties.Resources.delete_4219__1_;
            this.btnelimimnar.ImageActive = null;
            this.btnelimimnar.Location = new System.Drawing.Point(754, 3);
            this.btnelimimnar.Name = "btnelimimnar";
            this.btnelimimnar.Size = new System.Drawing.Size(34, 34);
            this.btnelimimnar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnelimimnar.TabIndex = 5;
            this.btnelimimnar.TabStop = false;
            this.toolTipController1.SetTitle(this.btnelimimnar, "Eliminar cliente");
            this.btnelimimnar.Visible = false;
            this.btnelimimnar.Zoom = 10;
            this.btnelimimnar.Click += new System.EventHandler(this.btnelimimnar_Click);
            // 
            // btneditclien
            // 
            this.btneditclien.Image = global::Joyeria2._0.Properties.Resources.editinguser_edituser_useedit_4520;
            this.btneditclien.ImageActive = null;
            this.btneditclien.Location = new System.Drawing.Point(805, 3);
            this.btneditclien.Name = "btneditclien";
            this.btneditclien.Size = new System.Drawing.Size(34, 34);
            this.btneditclien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneditclien.TabIndex = 4;
            this.btneditclien.TabStop = false;
            this.btneditclien.Zoom = 10;
            this.btneditclien.Click += new System.EventHandler(this.btneditclien_Click);
            // 
            // lblnameclie
            // 
            this.lblnameclie.AutoSize = true;
            this.lblnameclie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameclie.Location = new System.Drawing.Point(12, 14);
            this.lblnameclie.Name = "lblnameclie";
            this.lblnameclie.Size = new System.Drawing.Size(95, 16);
            this.lblnameclie.TabIndex = 1;
            this.lblnameclie.Text = "Nuevo Cliente:";
            this.toolTipController1.SetTitle(this.lblnameclie, "Nuevo Cliente");
            // 
            // btnfrmaddcliente
            // 
            this.btnfrmaddcliente.Image = global::Joyeria2._0.Properties.Resources.adduser_añadir_3553;
            this.btnfrmaddcliente.ImageActive = null;
            this.btnfrmaddcliente.Location = new System.Drawing.Point(110, 5);
            this.btnfrmaddcliente.Name = "btnfrmaddcliente";
            this.btnfrmaddcliente.Size = new System.Drawing.Size(34, 34);
            this.btnfrmaddcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfrmaddcliente.TabIndex = 0;
            this.btnfrmaddcliente.TabStop = false;
            this.toolTipController1.SetTitle(this.btnfrmaddcliente, "Agregar nuevo cliente");
            this.btnfrmaddcliente.Zoom = 10;
            this.btnfrmaddcliente.Click += new System.EventHandler(this.btnfrmaddcliente_Click);
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
            this.bunifuCustomDataGrid1.TabIndex = 5;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnelimimnar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditclien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrmaddcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnfrmaddcliente;
        private System.Windows.Forms.Label lblnameclie;
        private Bunifu.Framework.UI.BunifuImageButton btnelimimnar;
        private Bunifu.Framework.UI.BunifuImageButton btneditclien;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Label lblID;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnbuscarcliente;
        private Bunifu.Framework.UI.BunifuImageButton btninforme;
    }
}