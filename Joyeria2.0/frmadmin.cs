using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joyeria2._0
{
    public partial class frmadmin : Form
    {
        clslogin clas = new clslogin();
        public frmadmin()
        {
            InitializeComponent();
        }

        private void frmadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmlogin abrir = new frmlogin();
            abrir.Show();
            this.Hide();
        }
        private void metodo(object formsec)
        {
            if (this.panelfrm.Controls.Count > 0)
                this.panelfrm.Controls.RemoveAt(0);
            Form fm = formsec as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panelfrm.Controls.Add(fm);
            this.panelfrm.Tag = fm;
            fm.Show();
        }
        private void btnewfrmprod_Click(object sender, EventArgs e)
        {
            metodo(new frmproductos());
        }

        private void btnfrmempleados_Click(object sender, EventArgs e)
        {
            metodo(new FrmEmpleados());
        }

        private void btnfrmclientes_Click(object sender, EventArgs e)
        {
            metodo(new FrmClientes());
        }

        private void btnfrmventas_Click(object sender, EventArgs e)
        {
            metodo(new Frmventasadmin());
        }

        private void btnfrmapartado_Click(object sender, EventArgs e)
        {
            metodo(new Frmapartado());
        }

        private void btnfrmcondifg_Click(object sender, EventArgs e)
        {
            metodo(new Frmconfig());
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
