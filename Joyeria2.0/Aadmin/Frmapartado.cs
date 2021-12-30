using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Data.SqlClient;

namespace Joyeria2._0
{
    public partial class Frmapartado : Form
    {
        string sql;
        clssutil consultas = new clssutil();
        Conexion conexx = new Conexion();
        public Frmapartado()
        {
            InitializeComponent();
        }

        private void Frmapartado_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = consultas.tabla("select IDApartado as ID, Nombreempl as Empleado, Nombreclie as Cliente,fechainicioapart as [Fecha Inicial],fechafinalapart as [Fecha a finalizar] ,Totalapart as [Saldo a Pagar], totalpago as Total from Apartado inner join detallarticu on Apartado.idpagoapart = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Apartado.idpagoapart = pago.IDpado inner join Clientes on Apartado.IDclienteapar = Clientes.IDcliente inner join Empleados on Apartado.IDempleadoapa = Empleados.IDempleado");
                consultas.con.Close();
                lblhoras.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //foreachs();
        }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la consulta");
            }
}
        private void consulta()
        {
            try
            {
                dataGridView1.DataSource = consultas.tabla("select IDApartado as ID, Nombreempl as Empleado, Nombreclie as Cliente,fechainicioapart as [Fecha Inicial],fechafinalapart as [Fecha a finalizar] ,Totalapart as [Saldo a Pagar], totalpago as Total from Apartado inner join detallarticu on Apartado.idpagoapart = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Apartado.idpagoapart = pago.IDpado inner join Clientes on Apartado.IDclienteapar = Clientes.IDcliente inner join Empleados on Apartado.IDempleadoapa = Empleados.IDempleado");
                consultas.con.Close();
               foreachs();
        }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la consulta");
            }
}

        public void foreachs()
        {
            DateTime compare2 = Convert.ToDateTime(lblhoras.Text.Trim(), new CultureInfo("es-ES"));

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                DateTime fecha = Convert.ToDateTime(item.Cells["Fecha a finalizar"].Value);
                lblprimerafecha.Text = fecha.ToString("dd/MM/yyyy");
                DateTime compare1 = Convert.ToDateTime(lblprimerafecha.Text.Trim(), new CultureInfo("es-ES"));
                if (compare2 > compare1)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                    //MessageBox.Show("");
                }
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (lblID.Text != "")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Decea Eliminar el apartado?", "Apartado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (opcion == DialogResult.No)
                    {

                    }
                    else
                    {
                        if (lblID.Text != "")
                        {
                            string sql = "delete from Apartado where IDApartado = '" + lblID.Text + "'";
                            consultas.Delete(sql);
                            consulta();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione Al cliente");
                        }
                    }
                }
                else
                {
                        MessageBox.Show("Seleccione Al Apartado");

                    }
                }
            catch (Exception)
            {

                MessageBox.Show("Seleccione Al Apartado");
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from Apartado where IDApartado = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                consultas.Select(sql);
                if (consultas.reader.Read())
                {
                    sql = "insert into Venta (IDEmpleadovent, IDclientevent, IDpagoven, fecha) values ('" + consultas.reader["IDempleadoapa"].ToString() + "', '" + consultas.reader["IDclienteapar"].ToString() + "', '" + consultas.reader["idpagoapart"].ToString() + "', '" + lblhoras.Text + "')";
                    consultas.consultadata(sql);
                    sql = " delete from Apartado where IDApartado = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    consultas.consultadata(sql);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el apartado", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void bunifuShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metodo()
        {
            CrystalReportapartado objeto = new CrystalReportapartado();
            sql = "select IDApartado as ID, Nombreempl as Empleado, Nombreclie as Cliente,fechainicioapart as [Fecha Inicial],fechafinalapart as [Fecha a finalizar] ,Totalapart as [Saldo a Pagar], totalpago as Total from Apartado inner join detallarticu on Apartado.idpagoapart = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Apartado.idpagoapart = pago.IDpado inner join Clientes on Apartado.IDclienteapar = Clientes.IDcliente inner join Empleados on Apartado.IDempleadoapa = Empleados.IDempleado";
            SqlConnection exe = new SqlConnection(consultas.conexion);
            SqlDataAdapter adat = new SqlDataAdapter(sql, exe);
            DataSet quss = new DataSet();
            adat.Fill(quss, "Reporte");
            objeto.SetDataSource(quss);
            Frmreportapartado reportes = new Frmreportapartado();
            reportes.crystalReportViewer1.ReportSource = objeto;
            reportes.ShowDialog();


        }
        private void btnreporte_Click(object sender, EventArgs e)
        {


            DataSetapartados ds = new DataSetapartados();
            int filas = dataGridView1.Rows.Count;
            for (int i = 0; i <= filas - 1; i++)
            {
                ds.Tables[0].Rows.Add
                    (new object[] { dataGridView1[0,i].Value.ToString(),
                    dataGridView1[1,i].Value.ToString(),
                    dataGridView1[2,i].Value.ToString(),
                    dataGridView1[3,i].Value.ToString(),
                                        dataGridView1[4,i].Value.ToString(),
                                                            dataGridView1[5,i].Value.ToString(),
                                                                                dataGridView1[6,i].Value.ToString()
                    });
            }
            ReportDocument reps = new ReportDocument();
            reps.Load("C:\\Users\\Roberto\\Desktop\\Nueva carpeta (2)\\Trabajo del indelfonso\\4to\\Joyeria2.0\\Joyeria2.0\\CrystalReportapartado.rpt");
            reps.SetDataSource(ds);
            Frmreportapartado reportes = new Frmreportapartado();
            reportes.crystalReportViewer1.ReportSource = reps;
            reportes.ShowDialog();
        }

        private void tmriniciar_Tick(object sender, EventArgs e)
        {
            foreachs();
            tmriniciar.Stop();
        }

        private void btnbusquedaava_Click(object sender, EventArgs e)
        {
            foreachs();
        }
    }
}