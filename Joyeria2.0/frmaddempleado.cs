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

namespace Joyeria2._0
{
    public partial class frmaddempleado : Form
    {
        clssutil clase = new clssutil();
        public frmaddempleado()
        {
            InitializeComponent();
        }

        private void txtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            //Esta variable de puede publicar al inicio, no se estara repitiendo
            //Validad correo
            System.Text.RegularExpressions.Regex rEMAIL = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtcorreo.Text.Length > 0)
            {
                if (!rEMAIL.IsMatch(txtcorreo.Text))
                {
                    MessageBox.Show("Correo Invalido", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtcorreo.ToString();
                    e.Cancel = true;
                }
            }
        }
        private void txtrfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void btnaddimage_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    bunifuPictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtapellido.Text != "" && txtcorreo.Text != "" && txtdireccion.Text != "" && txtelefono.Text != "" && txtnombre.Text != "" && txtrfc.Text != "" && txtestado.Text != "" && txtmunicipio.Text != "" && txtcorreo.Text != "")
                {
                    if (lbltitle.Text == "Agregar")
                    {
                        string query = "insert into Empleados (Nombre, Apellido, Direccion, Correo, Telefono, CURP, RFC, Municipio, Estado, Nacimiento) values ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtcorreo.Text + "', '" + txtelefono.Text + "', '" + txtcurp.Text + "', '" + txtrfc.Text + "', '" + txtmunicipio.Text + "', '" + txtestado.Text + "', '" + dateEdit1.Text + "')";
                        clase.Insertar(query, "Empleado");
                    }
                    else if (lbltitle.Text == "Actualizar")
                    {
                        if (btnradioMasculino.Checked == true && bunifuRadioButton2.Checked == false)
                        {
                            string query = "update Empleados set Nombre = '" + txtnombre.Text + "', Apellido = '" + txtapellido.Text + "', Direccion = '" + txtdireccion.Text + "', Telefono = '" + txtelefono.Text + "', Correo = '" + txtcorreo.Text + "', RFC = '" + txtrfc.Text + "', sexo = 'M', Municipio = '" + txtmunicipio.Text + "', Estado = '" + txtestado.Text + "', Nacimiento = '" + dateEdit1.Text + "', curp = '" + txtcurp.Text + "', puesto = '" + comboBoxEdit1.Text + "' where IDempleado = '" + lblid.Text + "'";
                            clase.actualizar(query);
                        }
                        else if (bunifuRadioButton2.Checked == true && btnradioMasculino.Checked == false)
                        {
                            string query = "update Empleados set Nombre = '" + txtnombre.Text + "', Apellido = '" + txtapellido.Text + "', Direccion = '" + txtdireccion.Text + "', Telefono = '" + txtelefono.Text + "', Correo = '" + txtcorreo.Text + "', RFC = '" + txtrfc.Text + "', sexo = 'F', Municipio = '" + txtmunicipio.Text + "', Estado = '" + txtestado.Text + "', Nacimiento = '" + dateEdit1.Text + "', curp = '" + txtcurp.Text + "', puesto = '" + comboBoxEdit1.Text + "' where IDempleado = '" + lblid.Text + "'";
                            clase.actualizar(query);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Campos por rellenar", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arror Administrador", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmaddempleado_Load(object sender, EventArgs e)
        {
            empleado();
        }

        private void empleado()
        {
            if (lblid.Text != "")
            {
                string query = "Select * from Empleados where IDempleado= '"+lblid.Text+"'";
                clase.Select(query);
                if (clase.reader.Read())
                {
                    txtnombre.Text = clase.reader["Nombre"].ToString();
                    txtapellido.Text = clase.reader["Apellido"].ToString();
                    txtdireccion.Text = clase.reader["Direccion"].ToString();
                    txtelefono.Text = clase.reader["Telefono"].ToString();
                    txtrfc.Text = clase.reader["rfc"].ToString();
                    txtestado.Text = clase.reader["Estado"].ToString();
                    txtcorreo.Text = clase.reader["correo"].ToString();
                   txtmunicipio.Text = clase.reader["Municipio"].ToString();
                    dateEdit1.Text = clase.reader["Nacimiento"].ToString();
                    txtcurp.Text = clase.reader["curp"].ToString();
                    comboBoxEdit1.Text = clase.reader["puesto"].ToString();
                    if (clase.reader["sexo"].ToString() == "M")
                    {
                        bunifuRadioButton2.Checked = false;
                        btnradioMasculino.Checked = true;
                        
                    }
                    else if (clase.reader["sexo"].ToString() == "F")
                    {
                        btnradioMasculino.Checked = false;
                        bunifuRadioButton2.Checked = true;
                    }
                }
                clase.reader.Close();
            }
        }
    }
}
