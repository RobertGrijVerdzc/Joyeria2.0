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
    public partial class FrmClientes : Form
    {
        clssutil consultas = new clssutil();
        Frmaddclientes abrir = new Frmaddclientes();
        public FrmClientes()
        {
                InitializeComponent();
        }
        private void btnfrmaddcliente_Click(object sender, EventArgs e)
        {
            abrir.lbldatos.Text = "";
            abrir.lblid.Text = "";
            abrir.txtnombre.Text = "";
            abrir.txtapellido.Text = "";
            abrir.txtcorreo.Text = "";
            abrir.txtdireccion.Text = "";
            abrir.txtelefono.Text = "";
            abrir.lbltitle.Text = "Agregar";
            abrir.btnguardarclientes.Text = "              Guardar";
            abrir.ShowDialog();
        }

        private void btneditclien_Click(object sender, EventArgs e)
        {
            try
            {
                abrir.lblid.Text = "";
                abrir.lblid.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                if (abrir.lblid.Text != "")
                {
                    abrir.lbldatos.Text = "ID Cliente:";
                    abrir.lbltitle.Text = "Actualizar";
                    abrir.btnguardarclientes.Text = "              Actualizar";
                    abrir.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecciona a un cliente para editar su Informacion");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona a un cliente para editar su Informacion");
            }
        }

        public void consulta()
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = consultas.tabla("Select * from Clientes");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
    }

        private void btnelimimnar_Click(object sender, EventArgs e)
        {
            try
            {
                lblID.Text = "";
                lblID.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                if (lblID.Text != "")
                {
                    string sql = "delete from Clientes where IDcliente = '" + lblID.Text + "'";
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDcliente as ID, Nombreclie as Nombre, Apellidoclie as Apellido, Domicilioclien as Domicilio, Numeroclie as Telefono, Correoclie as Email from Clientes");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }

        private void btnbuscarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                clssutil.Sololetras(e);
                bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDcliente as ID, Nombreclie as Nombre, Apellidoclie as Apellido, Domicilioclien as Domicilio, Numeroclie as Telefono, Correoclie as Email from Clientes where Nombreclie like '" + btnbuscarcliente.Text + "%' ");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            DataSetclientes ds = new DataSetclientes();
            int filas = bunifuCustomDataGrid1.Rows.Count;
            for (int i = 0; i <= filas - 1; i++)
            {
                ds.Tables[0].Rows.Add
                    (new object[] { bunifuCustomDataGrid1[0,i].Value.ToString(),
                    bunifuCustomDataGrid1[1,i].Value.ToString(),
                    bunifuCustomDataGrid1[2,i].Value.ToString(),
                    bunifuCustomDataGrid1[3,i].Value.ToString(),
                    bunifuCustomDataGrid1[4,i].Value.ToString(),
                    bunifuCustomDataGrid1[5,i].Value.ToString()
                    });
            }
            ReportDocument reps = new ReportDocument();
            reps.Load("C:\\Users\\Roberto\\Desktop\\Nueva carpeta (2)\\Trabajo del indelfonso\\4to\\Joyeria2.0\\Joyeria2.0\\CrystalReportclientes.rpt");
            reps.SetDataSource(ds);
            Frmcrysclientes reportes = new Frmcrysclientes();
            reportes.cryreportecliente.ReportSource = reps;
            reportes.ShowDialog();
        }
    }
}
