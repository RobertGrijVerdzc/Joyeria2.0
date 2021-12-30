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
    public partial class Frmconfig : Form
    {
        public Frmconfig()
        {
            InitializeComponent();
        }

        private void txtiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void btnfrmcondifg_Click(object sender, EventArgs e)
        {
            Frmregistrologs abrir = new Frmregistrologs();
            abrir.ShowDialog();
        }
    }
}
