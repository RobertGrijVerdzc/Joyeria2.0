namespace Joyeria2._0
{
    partial class Frmbusquedas
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
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.btninforme = new System.Windows.Forms.Button();
            this.CMBCliente = new System.Windows.Forms.ComboBox();
            this.CMBempleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr2 = new System.Windows.Forms.DateTimePicker();
            this.tmr1 = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(233, 107);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(0, 13);
            this.lblcliente.TabIndex = 41;
            this.lblcliente.Visible = false;
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.Location = new System.Drawing.Point(233, 71);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(0, 13);
            this.lblempleado.TabIndex = 40;
            this.lblempleado.Visible = false;
            // 
            // btninforme
            // 
            this.btninforme.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btninforme.Location = new System.Drawing.Point(121, 139);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(75, 23);
            this.btninforme.TabIndex = 39;
            this.btninforme.Text = "Informe";
            this.toolTip1.SetToolTip(this.btninforme, "Informe");
            this.btninforme.UseVisualStyleBackColor = true;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // CMBCliente
            // 
            this.CMBCliente.FormattingEnabled = true;
            this.CMBCliente.Location = new System.Drawing.Point(90, 108);
            this.CMBCliente.Name = "CMBCliente";
            this.CMBCliente.Size = new System.Drawing.Size(121, 21);
            this.CMBCliente.TabIndex = 38;
            this.toolTip1.SetToolTip(this.CMBCliente, "Cliente");
            // 
            // CMBempleado
            // 
            this.CMBempleado.FormattingEnabled = true;
            this.CMBempleado.Location = new System.Drawing.Point(90, 64);
            this.CMBempleado.Name = "CMBempleado";
            this.CMBempleado.Size = new System.Drawing.Size(121, 21);
            this.CMBempleado.TabIndex = 37;
            this.toolTip1.SetToolTip(this.CMBempleado, "Empleado");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Empleado:";
            this.toolTip1.SetToolTip(this.label5, "Empleado");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cliente:";
            this.toolTip1.SetToolTip(this.label4, "Cliente");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fin";
            this.toolTip1.SetToolTip(this.label3, "Final");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Inicio";
            this.toolTip1.SetToolTip(this.label2, "Inicia");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fechas:";
            this.toolTip1.SetToolTip(this.label1, "Fecha");
            // 
            // tmr2
            // 
            this.tmr2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tmr2.Location = new System.Drawing.Point(196, 25);
            this.tmr2.Name = "tmr2";
            this.tmr2.Size = new System.Drawing.Size(82, 20);
            this.tmr2.TabIndex = 31;
            this.toolTip1.SetToolTip(this.tmr2, "Fecha Final");
            // 
            // tmr1
            // 
            this.tmr1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tmr1.Location = new System.Drawing.Point(90, 25);
            this.tmr1.Name = "tmr1";
            this.tmr1.Size = new System.Drawing.Size(82, 20);
            this.tmr1.TabIndex = 30;
            this.toolTip1.SetToolTip(this.tmr1, "Fecha Inicio");
            this.tmr1.Value = new System.DateTime(2018, 1, 1, 16, 23, 0, 0);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(211, 108);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 29;
            this.lblID.Visible = false;
            // 
            // Frmbusquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 174);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.CMBCliente);
            this.Controls.Add(this.CMBempleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmr2);
            this.Controls.Add(this.tmr1);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.Name = "Frmbusquedas";
            this.Text = "Busqueda Avanzada";
            this.Load += new System.EventHandler(this.Frmbusquedas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.ComboBox CMBCliente;
        private System.Windows.Forms.ComboBox CMBempleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tmr1;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btninforme;
        public System.Windows.Forms.DateTimePicker tmr2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}