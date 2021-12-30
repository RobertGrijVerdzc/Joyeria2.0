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
using System.Data.SqlClient;

namespace Joyeria2._0
{
    public partial class frmaddempleado : Form
    {
        string sql;
        clssutil clase = new clssutil();
        Frmaddacceso abrir = new Frmaddacceso();
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
            try
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
            catch (Exception)
            {

                MessageBox.Show("Error Correo");
            }
        }
        private void txtrfc_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public void btnaddimage_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.openFileDialog1.ShowDialog();
            //    if (this.openFileDialog1.FileName.Equals("") == false)
            //    {
            //        FileStream stream = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            //         binData = new byte[stream.Length];
            //        stream.Read(binData, 0, Convert.ToInt32(stream.Length));
            //        bunifuPictureBox1.Image = Image.FromStream(stream);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            //}
        }
        private void busqued()
        {
            try
            {
                string sqls = "select IDpuesto from puesto where Nombrepuesto = '" + comboBoxEdit1.Text + "'";
                clase.Select(sqls);
                lblapell.Text = "";
                if (clase.reader.Read())
                {
                    lblpuesto.Text = clase.reader["IDpuesto"].ToString();
                }
                clase.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error Puesto");
            }
        }
        private void ramdom()
        {
            try
            {
                int maxdigits = 10; // Change to needed # of digits
                StringBuilder result = new StringBuilder();
                Random r = new Random(); // Seed with what you feel is appropriate
                for (int i = 0; i <= maxdigits; i++)
                {
                    result.Append(r.Next(10)); // Append a number from 0 to 9
                }
                sql = "Select * from Empleados where IDempleadoram = '" + result.ToString() + "'";
                clase.consultaspruebas(sql);
                if (clase.Correc == "1")
                {
                    clase.con.Close();
                    ramdom();
                }
                else
                {
                    lblidempleadoramdom.Text = Convert.ToString(result.ToString());
                }
                clase.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en generar ID");
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
                        if (btnradioMasculino.Checked == true && bunifuRadioButton2.Checked == false)
                        {
                            ramdom();
                            busqued();
                            cambiohor();
                            string query = "Insert into Empleados (IDempleadoram, Nombreempl, Apellidoemple, Direccionemple, Telefonoemple, Correoemple, RFCemple, curpemple, sexoemple, Municipio, Estadoemple, Nacimientoemple, puestoemple, IDempresaemple) values('" + lblidempleadoramdom.Text + "','" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtelefono.Text + "', '" + txtcorreo.Text + "', '" + txtrfc.Text + "', '" + txtcurp.Text + "', 'M', '" + txtmunicipio.Text + "', '" + txtestado.Text + "', '" + dateEdit1.Text + "', '" + lblpuesto.Text + "', '" + clsempresa.ID + "')";
                            clase.Insertar(query, "Empleado");
                            borrar();
                        }
                        else if (bunifuRadioButton2.Checked == true && btnradioMasculino.Checked == false)
                        {
                            ramdom();
                            busqued();
                            cambiohor();
                            string query = "Insert into Empleados (IDempleadoram, Nombreempl, Apellidoemple, Direccionemple, Telefonoemple, Correoemple, RFCemple, curpemple, sexoemple, Municipio, Estadoemple, Nacimientoemple, puestoemple, IDempresaemple) values('" + lblidempleadoramdom.Text+ "','" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtelefono.Text + "', '" + txtcorreo.Text + "', '" + txtrfc.Text + "', '" + txtcurp.Text + "', 'F', '" + txtmunicipio.Text + "', '" + txtestado.Text + "', '" + dateEdit1.Text + "', '" + lblpuesto.Text + "', '" + clsempresa.ID + "')";
                            clase.Insertar(query, "Empleado");
                            borrar();
                        }

                    }
                    else if (lbltitle.Text == "Actualizar")
                    {
                        
                        if (btnradioMasculino.Checked == true && bunifuRadioButton2.Checked == false)
                        {
                        busqued();
                            cambiohor();
                            string query = "update Empleados set Nombreempl = '" + txtnombre.Text + "',Apellidoemple = '" + txtapellido.Text + "', Direccionemple = '" + txtdireccion.Text + "', Telefonoemple = '" + txtelefono.Text + "', Correoemple = '" + txtcorreo.Text + "', RFCemple = '" + txtrfc.Text + "', sexoemple = 'M', Municipio = '" + txtmunicipio.Text + "', Estadoemple = '" + txtestado.Text + "', Nacimientoemple = '" + dateEdit1.Text + "', curpemple = '" + txtcurp.Text + "', puestoemple = '" + lblpuesto.Text + "' where IDempleado = '" + lblid.Text + "'";
                            clase.actualizar(query);
                        }
                        else if (bunifuRadioButton2.Checked == true && btnradioMasculino.Checked == false)
                        {
                        busqued();
                            cambiohor();
                            string query = "update Empleados set Nombreempl = '" + txtnombre.Text + "',Apellidoemple = '" + txtapellido.Text + "', Direccionemple = '" + txtdireccion.Text + "', Telefonoemple = '" + txtelefono.Text + "', Correoemple = '" + txtcorreo.Text + "', RFCemple = '" + txtrfc.Text + "', sexoemple = 'F', Municipio = '" + txtmunicipio.Text + "', Estadoemple = '" + txtestado.Text + "', Nacimientoemple = '" + dateEdit1.Text + "', curpemple = '" + txtcurp.Text + "', puestoemple = '" + lblpuesto.Text + "' where IDempleado = '" + lblid.Text + "'";
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
            Combox();
            empleado();
        }
        private void cambiohor()
        {
            dateEdit1.Format = DateTimePickerFormat.Custom;
            dateEdit1.CustomFormat = "yyyy-MM-dd";
        }

        private void empleado()
        {
            try
            {
                if (lblid.Text != "")
                {
                    string query = " Select * from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto where IDempleado = '" + lblid.Text + "'";
                    clase.Select(query);
                    if (clase.reader.Read())
                    {
                        txtnombre.Text = clase.reader["Nombreempl"].ToString();
                        txtapellido.Text = clase.reader["Apellidoemple"].ToString();
                        txtdireccion.Text = clase.reader["Direccionemple"].ToString();
                        txtelefono.Text = clase.reader["Telefonoemple"].ToString();
                        txtrfc.Text = clase.reader["RFCemple"].ToString();
                        txtestado.Text = clase.reader["Estadoemple"].ToString();
                        txtcorreo.Text = clase.reader["Correoemple"].ToString();
                        txtmunicipio.Text = clase.reader["Municipio"].ToString();
                        dateEdit1.Text = clase.reader["Nacimientoemple"].ToString();
                        txtcurp.Text = clase.reader["curpemple"].ToString();
                        comboBoxEdit1.Text = "";
                        comboBoxEdit1.Text = clase.reader["Nombrepuesto"].ToString();
                        if (clase.reader["sexoemple"].ToString() == "M")
                        {
                            bunifuRadioButton2.Checked = false;
                            btnradioMasculino.Checked = true;
                        }
                        else if (clase.reader["sexoemple"].ToString() == "F")
                        {
                            btnradioMasculino.Checked = false;
                            bunifuRadioButton2.Checked = true;
                        }
                    }
                    btnseguridad.Visible = true;
                    lblidgenerar.Visible = true;
                    lblidcliente.Visible = true;
                    clase.con.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar al empleado");
            }
        }

        private void btnseguridad_Click(object sender, EventArgs e)
        {
            abrir.lblid.Text = lblid.Text;
            abrir.ShowDialog();
        }
        private void Combox()
        {
            try
            {
                string sql = "Select Nombrepuesto from puesto";
                clase.Combo(sql);
                comboBoxEdit1.ValueMember = "Nombrepuesto";
                comboBoxEdit1.DataSource = clase.dt;
                clase.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar al Puesto");
            }
        }

        private void dateEdit1_ValueChanged(object sender, EventArgs e)
        {
            dateEdit1.Format = DateTimePickerFormat.Custom;
            dateEdit1.CustomFormat = "yyyy-MM-dd";
        }
        private void borrar()
        {
            txtapellido.Text = "";
            txtcorreo.Text = "";
            txtcurp.Text = "";
            txtdireccion.Text = "";
            txtelefono.Text = "";
            txtestado.Text = "";
            txtmunicipio.Text = "";
            txtnombre.Text = "";
            txtrfc.Text = "";
            lblidempleadoramdom.Text = "";
            dateEdit1.Text = "";
            comboBoxEdit1.Text = "";
        }
    }
}
