using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;


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
            bunifuCustomDataGrid1.DataSource = consultas.tabla("select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente,totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado");
            consultas.con.Close();
        }

        private void consulta()
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente,totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado");
            consultas.con.Close();
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

        private void brnreportventas_Click(object sender, EventArgs e)
        {
            DataSetventas ds = new DataSetventas();
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
            reps.Load("C:\\Users\\Roberto\\Desktop\\Nueva carpeta (2)\\Trabajo del indelfonso\\4to\\Joyeria2.0\\Joyeria2.0\\CrystalReportventas.rpt");
            reps.SetDataSource(ds);
            Frmreportventas reportes = new Frmreportventas();
            reportes.crystalReportViewer1.ReportSource = reps;
            reportes.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            consulta();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Frmbusquedas f = new Frmbusquedas();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string sql = f.myname;
                    bunifuCustomDataGrid1.DataSource = consultas.tabla(sql);
                    consultas.con.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Abrir la ventana de productos");
            }
        }
    }
}
