namespace Joyeria2._0
{
    partial class Frmclientevent
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
            this.txtidbuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblidempleado = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.datagridventbusclie = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnenviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridventbusclie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidbuscar
            // 
            this.txtidbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtidbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtidbuscar.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtidbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtidbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtidbuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtidbuscar.HintText = "Buscar Cliente";
            this.txtidbuscar.isPassword = false;
            this.txtidbuscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtidbuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtidbuscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtidbuscar.LineThickness = 3;
            this.txtidbuscar.Location = new System.Drawing.Point(11, 26);
            this.txtidbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtidbuscar.MaxLength = 15;
            this.txtidbuscar.Name = "txtidbuscar";
            this.txtidbuscar.Size = new System.Drawing.Size(379, 33);
            this.txtidbuscar.TabIndex = 0;
            this.txtidbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtidbuscar, "Buscar Cliente");
            this.txtidbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidbuscar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnenviar);
            this.panel1.Controls.Add(this.lblidempleado);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Controls.Add(this.txtidbuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 70);
            this.panel1.TabIndex = 1;
            // 
            // lblidempleado
            // 
            this.lblidempleado.AutoSize = true;
            this.lblidempleado.Location = new System.Drawing.Point(4, 30);
            this.lblidempleado.Name = "lblidempleado";
            this.lblidempleado.Size = new System.Drawing.Size(0, 13);
            this.lblidempleado.TabIndex = 2;
            this.lblidempleado.Visible = false;
            // 
            // lblform
            // 
            this.lblform.AutoSize = true;
            this.lblform.Location = new System.Drawing.Point(12, 9);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(0, 13);
            this.lblform.TabIndex = 1;
            // 
            // datagridventbusclie
            // 
            this.datagridventbusclie.AllowUserToAddRows = false;
            this.datagridventbusclie.AllowUserToDeleteRows = false;
            this.datagridventbusclie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridventbusclie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridventbusclie.Location = new System.Drawing.Point(0, 70);
            this.datagridventbusclie.Name = "datagridventbusclie";
            this.datagridventbusclie.ReadOnly = true;
            this.datagridventbusclie.Size = new System.Drawing.Size(499, 248);
            this.datagridventbusclie.TabIndex = 2;
            this.toolTip1.SetToolTip(this.datagridventbusclie, "Clientes");
            this.datagridventbusclie.DoubleClick += new System.EventHandler(this.datagridventbusclie_DoubleClick);
            // 
            // btnenviar
            // 
            this.btnenviar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnenviar.Location = new System.Drawing.Point(412, 36);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.toolTip1.SetToolTip(this.btnenviar, "Enviar Datos");
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // Frmclientevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 318);
            this.Controls.Add(this.datagridventbusclie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmclientevent";
            this.Text = "Venta Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmclientevent_FormClosing);
            this.Load += new System.EventHandler(this.Frmclientevent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridventbusclie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridventbusclie;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtidbuscar;
        public System.Windows.Forms.Label lblform;
        public System.Windows.Forms.Label lblidempleado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnenviar;
    }
}