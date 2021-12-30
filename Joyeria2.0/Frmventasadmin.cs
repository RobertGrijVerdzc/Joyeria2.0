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
    public partial class Frmventasadmin : Form
    {
        clssutil consultas = new clssutil();
        public Frmventasadmin()
        {
            InitializeComponent();
        }

        private void btnnewfrmventas_Click(object sender, EventArgs e)
        {
            Frmventas abrir = new Frmventas();
            abrir.ShowDialog();

        }

        private void btnewfrmgrafica_Click(object sender, EventArgs e)
        {
            Frmventasgrafica abrir = new Frmventasgrafica();
            abrir.ShowDialog();
        }

        private void Frmventasadmin_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("Select * from venta");
        }

        private void consulta()
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("Select * from venta");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblid.Text = "";
                lblid.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                if (lblid.Text != "")
                {
                    string sql = "delete from venta where IDventas = '" + lblid.Text + "'";
                    consultas.Delete(sql);
                    consulta();
                }
                else
                {
                    MessageBox.Show("Seleccione Al cliente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione al Cliente", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
