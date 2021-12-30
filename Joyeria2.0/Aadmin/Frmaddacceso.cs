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
    public partial class Frmaddacceso : Form
    {
        string sql;
        clssutil clase = new clssutil();
        public Frmaddacceso()
        {
            InitializeComponent();
        }

        private void Frmaddacceso_Load(object sender, EventArgs e)
        {
            cargaform();
        }

        private void cargaform()
        {
            try
            {
                if (lblid.Text != "")
                {
                    sql = "Select * from Empleados where idempleado= '" + lblid.Text + "'";
                    clase.reader2(sql);
                    if (clase.read2.Read())
                    {
                        lblname.Text = clase.read2["Nombreempl"].ToString();
                        cmbtipo.Text = clase.read2["Tipoemple"].ToString();
                    }
                    clase.con.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Cargar Empleado");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text != "" && lblname.Text != "")
                {
                    if (txtpass.Text != "")
                    {
                        sql = "update Empleados set Tipoemple = '" + cmbtipo.Text + "', Contrasenaemple = '" + Clsencry.Encriptar(txtpass.Text) + "' where IDempleado = '" + lblid.Text + "'";
                        clase.Insertar(sql, "Acceso");
                    }
                    else if (txtpass.Text == "")
                    {
                        sql = "update Empleados set Tipoemple = '" + cmbtipo.Text + "' where IDempleado = '" + lblid.Text + "'";
                        clase.Insertar(sql, "Acceso");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al darle permisos", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void eliminartodo()
        {
            lblid.Text = "";
            lblname.Text = "";
            txtpass.Text = "";
            cmbtipo.Text = "";
        }
        private void Frmaddacceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            eliminartodo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
