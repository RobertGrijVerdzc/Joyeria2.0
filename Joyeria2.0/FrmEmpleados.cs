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
            bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDempleado as ID,Nombrepuesto as Cargo, Nombre, Apellido, Direccion, Telefono, Correo, RFC, curp from Empleados inner join puesto on Empleados.puesto = puesto.IDpuesto");
        }

        private void consulta()
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDempleado as ID,Nombrepuesto as Cargo, Nombre, Apellido, Direccion, Telefono, Correo, RFC, curp from Empleados inner join puesto on Empleados.puesto = puesto.IDpuesto");
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
    }
}
