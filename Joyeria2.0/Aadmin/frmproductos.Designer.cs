namespace Joyeria2._0
{
    partial class frmproductos
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
            this.btnimprim = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblid = new System.Windows.Forms.Label();
            this.btnelimina = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblnameprod = new System.Windows.Forms.Label();
            this.btnfrmaddproducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnimprim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnelimina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrmaddproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.btnimprim);
            this.bunifuShadowPanel1.Controls.Add(this.lblid);
            this.bunifuShadowPanel1.Controls.Add(this.btnelimina);
            this.bunifuShadowPanel1.Controls.Add(this.btneditar);
            this.bunifuShadowPanel1.Controls.Add(this.lblnameprod);
            this.bunifuShadowPanel1.Controls.Add(this.btnfrmaddproducto);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(870, 49);
            this.bunifuShadowPanel1.TabIndex = 2;
            // 
            // btnimprim
            // 
            this.btnimprim.Image = global::Joyeria2._0.Properties.Resources.informe_seo;
            this.btnimprim.ImageActive = null;
            this.btnimprim.Location = new System.Drawing.Point(703, 3);
            this.btnimprim.Name = "btnimprim";
            this.btnimprim.Size = new System.Drawing.Size(34, 34);
            this.btnimprim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnimprim.TabIndex = 5;
            this.btnimprim.TabStop = false;
            this.toolTipController1.SetTitle(this.btnimprim, "Eliminar Producto");
            this.btnimprim.Zoom = 10;
            this.btnimprim.Click += new System.EventHandler(this.btnimprim_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(407, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 4;
            this.lblid.Visible = false;
            // 
            // btnelimina
            // 
            this.btnelimina.Image = global::Joyeria2._0.Properties.Resources.delete_4219__1_;
            this.btnelimina.ImageActive = null;
            this.btnelimina.Location = new System.Drawing.Point(754, 3);
            this.btnelimina.Name = "btnelimina";
            this.btnelimina.Size = new System.Drawing.Size(34, 34);
            this.btnelimina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnelimina.TabIndex = 3;
            this.btnelimina.TabStop = false;
            this.toolTipController1.SetTitle(this.btnelimina, "Eliminar Producto");
            this.btnelimina.Zoom = 10;
            this.btnelimina.Click += new System.EventHandler(this.btnelimina_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Joyeria2._0.Properties.Resources.circle_edit_article_icon_icons_com_66938;
            this.btneditar.ImageActive = null;
            this.btneditar.Location = new System.Drawing.Point(805, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(34, 34);
            this.btneditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneditar.TabIndex = 2;
            this.btneditar.TabStop = false;
            this.toolTipController1.SetTitle(this.btneditar, "Editar Producto");
            this.btneditar.Zoom = 10;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // lblnameprod
            // 
            this.lblnameprod.AutoSize = true;
            this.lblnameprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameprod.Location = new System.Drawing.Point(12, 14);
            this.lblnameprod.Name = "lblnameprod";
            this.lblnameprod.Size = new System.Drawing.Size(108, 16);
            this.lblnameprod.TabIndex = 1;
            this.lblnameprod.Text = "Nuevo Producto:";
            this.toolTipController1.SetToolTip(this.lblnameprod, "Nuevo Producto");
            // 
            // btnfrmaddproducto
            // 
            this.btnfrmaddproducto.Image = global::Joyeria2._0.Properties.Resources.flat_style_circle_add_icon_icons_com_66944;
            this.btnfrmaddproducto.ImageActive = null;
            this.btnfrmaddproducto.Location = new System.Drawing.Point(135, 6);
            this.btnfrmaddproducto.Name = "btnfrmaddproducto";
            this.btnfrmaddproducto.Size = new System.Drawing.Size(34, 34);
            this.btnfrmaddproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfrmaddproducto.TabIndex = 0;
            this.btnfrmaddproducto.TabStop = false;
            this.toolTipController1.SetTitle(this.btnfrmaddproducto, "Agregar nuevo producto");
            this.btnfrmaddproducto.Zoom = 10;
            this.btnfrmaddproducto.Click += new System.EventHandler(this.btnfrmaddproducto_Click);
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
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(870, 346);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 395);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproductos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmproductos_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnimprim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnelimina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfrmaddproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnelimina;
        private Bunifu.Framework.UI.BunifuImageButton btneditar;
        private System.Windows.Forms.Label lblnameprod;
        private Bunifu.Framework.UI.BunifuImageButton btnfrmaddproducto;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Label lblid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuImageButton btnimprim;
    }
}