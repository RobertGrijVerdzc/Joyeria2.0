using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Joyeria2._0
{
    public partial class Frmregistrologs : Form
    {
        clssutil consultas = new clssutil();
        public Frmregistrologs()
        {
            InitializeComponent();
        }
        
        private void Frmregistrologs_Load(object sender, EventArgs e)
        {
            consulta();
        }
        private void consulta()
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("select  IDregistrologin as ID, Nombre, Nombrepuesto as Puesto, fechahora as Tiempo  from registrologins inner join Empleados on registrologins.idempleadoregistro = Empleados.IDempleado inner join puesto on Empleados.puesto = puesto.IDpuesto");
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            Frmreporteslogins abrir = new Frmreporteslogins();
            abrir.ShowDialog();
        }
    }
}
