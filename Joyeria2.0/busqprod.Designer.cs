namespace Joyeria2._0
{
    partial class busqprod
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
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bnenvar = new System.Windows.Forms.Button();
            this.txtavanzaprod = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.datagridprodavan = new System.Windows.Forms.DataGridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bunifuShadowPanel1.SuspendLayout();
            this.bunifuShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprodavan)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.bnenvar);
            this.bunifuShadowPanel1.Controls.Add(this.txtavanzaprod);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(598, 71);
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // bnenvar
            // 
            this.bnenvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnenvar.Location = new System.Drawing.Point(451, 23);
            this.bnenvar.Name = "bnenvar";
            this.bnenvar.Size = new System.Drawing.Size(75, 23);
            this.bnenvar.TabIndex = 1;
            this.bnenvar.Text = "Enviar";
            this.toolTipController1.SetTitle(this.bnenvar, "Enviar Dato");
            this.bnenvar.UseVisualStyleBackColor = true;
            this.bnenvar.Click += new System.EventHandler(this.bnenvar_Click);
            // 
            // txtavanzaprod
            // 
            this.txtavanzaprod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtavanzaprod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtavanzaprod.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtavanzaprod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtavanzaprod.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtavanzaprod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtavanzaprod.HintForeColor = System.Drawing.Color.Empty;
            this.txtavanzaprod.HintText = "Nombre del Producto";
            this.txtavanzaprod.isPassword = false;
            this.txtavanzaprod.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtavanzaprod.LineIdleColor = System.Drawing.Color.Gray;
            this.txtavanzaprod.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtavanzaprod.LineThickness = 3;
            this.txtavanzaprod.Location = new System.Drawing.Point(46, 13);
            this.txtavanzaprod.Margin = new System.Windows.Forms.Padding(4);
            this.txtavanzaprod.MaxLength = 15;
            this.txtavanzaprod.Name = "txtavanzaprod";
            this.txtavanzaprod.Size = new System.Drawing.Size(379, 33);
            this.txtavanzaprod.TabIndex = 0;
            this.txtavanzaprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtavanzaprod, "Ingrese el nombre del producto");
            this.txtavanzaprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtavanzaprod_KeyPress);
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel2.Controls.Add(this.datagridprodavan);
            this.bunifuShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(0, 71);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(598, 287);
            this.bunifuShadowPanel2.TabIndex = 1;
            // 
            // datagridprodavan
            // 
            this.datagridprodavan.AllowUserToAddRows = false;
            this.datagridprodavan.AllowUserToDeleteRows = false;
            this.datagridprodavan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridprodavan.CausesValidation = false;
            this.datagridprodavan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridprodavan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridprodavan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridprodavan.Location = new System.Drawing.Point(0, 0);
            this.datagridprodavan.Name = "datagridprodavan";
            this.datagridprodavan.ReadOnly = true;
            this.datagridprodavan.Size = new System.Drawing.Size(598, 287);
            this.datagridprodavan.TabIndex = 0;
            this.toolTipController1.SetTitle(this.datagridprodavan, "Listado del producto");
            this.datagridprodavan.DoubleClick += new System.EventHandler(this.datagridprodavan_DoubleClick);
            // 
            // busqprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 358);
            this.Controls.Add(this.bunifuShadowPanel2);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "busqprod";
            this.Text = "Productos Avanzado";
            this.Load += new System.EventHandler(this.busqprod_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridprodavan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtavanzaprod;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel2;
        private System.Windows.Forms.DataGridView datagridprodavan;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Button bnenvar;
    }
}