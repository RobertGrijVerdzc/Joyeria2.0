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
    public partial class Frmapartaven : Form
    {
        public Frmapartaven()
        {
            InitializeComponent();
        }

        private void Frmapartaven_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frmventas abrir = new Frmventas();
            abrir.Show();
            this.Hide();
        }
    }
}
