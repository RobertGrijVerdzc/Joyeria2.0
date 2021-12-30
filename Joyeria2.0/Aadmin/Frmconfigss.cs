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
    public partial class Frmconfigss : Form
    {
        public Frmconfigss()
        {
            InitializeComponent();
        }
        public void carga()
            {
            txtiva.Text = Convert.ToString(clsempresa.iva);
            txtdesc.Text = Convert.ToString(clsempresa.descuento);
            txtpago.Text = Convert.ToString(clsempresa.pagos);
        }

        private void Frmconfigss_Load(object sender, EventArgs e)
        {
            carga();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdesc.Text != "" && txtiva.Text != "")
                {
                    clssutil enviar = new clssutil();
                    string sql = "update config set descuentoconfig = '" + txtdesc.Text+ "', ivaconfig = '" + txtiva.Text+"', pagosconfig = '"+txtpago.Text+"'";
                    enviar.actualizar(sql);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Datos No actualizados", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
