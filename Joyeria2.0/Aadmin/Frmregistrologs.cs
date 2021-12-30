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
using System.Drawing.Printing;
using System.IO;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

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
            bunifuCustomDataGrid1.DataSource = consultas.tabla("select  IDregistrologin as ID, Nombreempl as Nombre, Nombrepuesto as Puesto, fechahora as Tiempo  from registrologins inner join Empleados on registrologins.idempleadoregistro = Empleados.IDempleado inner join puesto on Empleados.puestoemple = puesto.IDpuesto");
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            DataSetlogins ds = new DataSetlogins();
            int filas = bunifuCustomDataGrid1.Rows.Count;
            for (int i = 0; i <= filas - 1; i++)
            {
                ds.Tables[0].Rows.Add
                    (new object[] { bunifuCustomDataGrid1[0,i].Value.ToString(),
                    bunifuCustomDataGrid1[1,i].Value.ToString(),
                    bunifuCustomDataGrid1[2,i].Value.ToString(),
                    bunifuCustomDataGrid1[3,i].Value.ToString()
                    });
            }
            ReportDocument reps = new ReportDocument();
            reps.Load("C:\\Users\\Roberto\\Desktop\\Nueva carpeta (2)\\Trabajo del indelfonso\\4to\\Joyeria2.0\\Joyeria2.0\\cryreportlogins.rpt");
            reps.SetDataSource(ds);
            reportss reportes = new reportss();
            reportes.crystalReportViewer1.ReportSource = reps;
            reportes.ShowDialog();
        }
    }
}
