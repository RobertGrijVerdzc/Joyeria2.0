using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace Joyeria2._0
{
    public partial class FrmEmpleados : Form
    {
        clssutil consultas = new clssutil();
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnfrmaddemplezdo_Click(object sender, EventArgs e)
        {
            frmaddempleado abrir = new frmaddempleado();
            abrir.ShowDialog();
        }

        private void btnimageedit_Click(object sender, EventArgs e)
        {
            frmaddempleado abrir = new frmaddempleado();
            abrir.lbltitle.Text = "Agregar";
            abrir.lblid.Text = "";
            abrir.lblidcliente.Text = "";
            abrir.btnguardar.Text = "Guardar";
            abrir.ShowDialog();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            try
            {
                frmaddempleado abrir = new frmaddempleado();
                abrir.lbltitle.Text = "Actualizar";
                abrir.btnguardar.Text = "Actualizar";
                abrir.lblidcliente.Text = "ID Cliente";
                abrir.lblid.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                abrir.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione a algun Empleado");
            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDempleado as ID,IDempleadoram as [ID Empleado],Nombrepuesto as Cargo, Nombreempl as Nombre, Apellidoemple as Apellido, Direccionemple as Direccion, Telefonoemple as Numero, Correoemple as Correo, RFCemple as RFC, curpemple as CURP from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }

        private void consulta()
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDempleado as ID,IDempleadoram as [ID Empleado],Nombrepuesto as Cargo, Nombreempl as Nombre, Apellidoemple as Apellido, Direccionemple as Direccion, Telefonoemple as Numero, Correoemple as Correo, RFCemple as RFC, curpemple as CURP from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblid.Text = "";
                lblid.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                if (lblid.Text != "")
                {
                    string sql = "delete from Empleados where IDempleado = '" + lblid.Text + "'";
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

        private void txtbuscarempleados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                clssutil.Sololetras(e);
                bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDempleado as ID,Nombrepuesto as Cargo, Nombreempl as Nombre, Apellidoemple as Apellido, Direccionemple as Direccion, Telefonoemple as Numero, Correoemple as Correo, RFCemple as RFC, curpemple as CURP from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto where Nombreempl like '" + txtbuscarempleados.Text + "%' ");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DatasetEmpleados ds = new DatasetEmpleados();
                int filas = bunifuCustomDataGrid1.Rows.Count;
                for (int i = 0; i <= filas - 1; i++)
                {
                    ds.Tables[0].Rows.Add
                        (new object[] { bunifuCustomDataGrid1[1,i].Value.ToString(),
                    bunifuCustomDataGrid1[3,i].Value.ToString(),
                    bunifuCustomDataGrid1[4,i].Value.ToString(),
                    bunifuCustomDataGrid1[2,i].Value.ToString(),
                    bunifuCustomDataGrid1[5,i].Value.ToString(),
                    bunifuCustomDataGrid1[6,i].Value.ToString(),
                    bunifuCustomDataGrid1[7,i].Value.ToString(),
                    bunifuCustomDataGrid1[8,i].Value.ToString(),
                    bunifuCustomDataGrid1[9,i].Value.ToString()
                        });
                }
                ReportDocument reps = new ReportDocument();
                reps.Load("C:\\Users\\Roberto\\Desktop\\Nueva carpeta (2)\\Trabajo del indelfonso\\4to\\Joyeria2.0\\Joyeria2.0\\CrystalReporempleados.rpt");
                reps.SetDataSource(ds);
                Frmreporempleadosss reportes = new Frmreporempleadosss();
                reportes.crystalReportViewer1.ReportSource = reps;
                reportes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Impresion, Dos impresiones o mas", "Aviso Importanye", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
