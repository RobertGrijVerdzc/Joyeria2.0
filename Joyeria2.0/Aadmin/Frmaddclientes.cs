using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Joyeria2._0
{
    public partial class Frmaddclientes : Form
    {
        public string Myname;
        public string Myid;
        public string myname
        {
            get { return Myname; }
            set { Myname = value; }
        }
        public string myid
        {
            get { return Myid; }
            set { Myid = value; }
        }
        clssutil util = new clssutil();
        public Frmaddclientes()
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

                MessageBox.Show("Error en el correo");
            }
        }

        private void btnguardarclientes_Click(object sender, EventArgs e)
        {
           
        }
        private void busqueda()
        {
            try
            {
                if (lblid.Text != "")
                {
                    string sql = "Select * from Clientes where IDcliente = '" + lblid.Text + "'";
                    util.Select(sql);
                    if (util.reader.Read())
                    {
                        txtnombre.Text = util.reader["Nombreclie"].ToString();
                        txtapellido.Text = util.reader["Apellidoclie"].ToString();
                        txtcorreo.Text = util.reader["Correoclie"].ToString();
                        txtelefono.Text = util.reader["Numeroclie"].ToString();
                        txtdireccion.Text = util.reader["Domicilioclien"].ToString();
                    }
                    util.reader.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar Cliente");
            }
        }

        private void Frmaddclientes_Load(object sender, EventArgs e)
        {
            if (lblid.Text != "")
            {
                busqueda();
                lbldatos.Visible = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtapellido.Text != "" && txtcorreo.Text != "" && txtdireccion.Text != "" && txtelefono.Text != "" && txtnombre.Text != "")
                {
                    if (lbltitle.Text == "Agregar")
                    {
                        string query = "Insert into Clientes (Nombreclie, Apellidoclie, Domicilioclien, Correoclie, Numeroclie) Values ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtcorreo.Text + "', '" + txtelefono.Text + "')";
                        util.Insertar(query, "Cliente");
                        if (util.Correc == "1")
                        {
                            txtnombre.Text = "";
                            txtelefono.Text = "";
                            txtcorreo.Text = "";
                            txtdireccion.Text = "";
                            txtapellido.Text = "";
                            this.Close();
                        }
                    }
                    else if (lbltitle.Text == "Agregar Cliente Ventas")
                    {
                        string query = "Insert into Clientes (Nombreclie, Apellidoclie, Domicilioclien, Correoclie, Numeroclie) Values ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtcorreo.Text + "', '" + txtelefono.Text + "')";
                        util.Insertar(query, "Cliente");
                        if (util.Correc == "1")
                        {
                            string sql = "select * from Clientes where Numeroclie = '" + txtelefono.Text + "' and Correoclie = '" + txtcorreo.Text + "'";
                            util.Select(sql);
                            if (util.reader.Read())
                            {
                                myname = util.reader["IDcliente"].ToString();
                                myid = util.reader["Nombreclie"].ToString();
                            }
                            util.Close();
                            txtnombre.Text = "";
                            txtelefono.Text = "";
                            txtcorreo.Text = "";
                            txtdireccion.Text = "";
                            txtapellido.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Fallo al registrar al nuevo cliente");
                        }
                    }
                    else if (lbltitle.Text == "Agregar Cliente Ventas Apartado")
                    {
                        string query = "Insert into Clientes (Nombreclie, Apellidoclie, Domicilioclien, Correoclie, Numeroclie) Values ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtcorreo.Text + "', '" + txtelefono.Text + "')";
                        util.Insertar(query, "Cliente");
                        if (util.Correc == "1")
                        {
                            string sql = "select * from Clientes where Numeroclie = '" + txtelefono.Text + "' and Correoclie = '" + txtcorreo.Text + "'";
                            util.Select(sql);
                            if (util.reader.Read())
                            {
                                myname = util.reader["IDcliente"].ToString();
                                myid = util.reader["Nombreclie"].ToString();
                            }
                            util.Close();
                            txtnombre.Text = "";
                            txtelefono.Text = "";
                            txtcorreo.Text = "";
                            txtdireccion.Text = "";
                            txtapellido.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Fallo al registrar al nuevo cliente");
                        }
                    }
                    else if (lbltitle.Text == "Actualizar")
                    {
                        string query = "Update Clientes Set Nombreclie = '" + txtnombre.Text + "', Apellidoclie= '" + txtapellido.Text + "', Domicilioclien= '" + txtdireccion.Text + "', Correoclie= '" + txtcorreo.Text + "', Numeroclie = '" + txtelefono.Text + "' where IDcliente = '" + lblid.Text + "'";
                        util.actualizar(query);
                        if (util.Correc == "1")
                        {
                            txtnombre.Text = "";
                            txtelefono.Text = "";
                            txtcorreo.Text = "";
                            txtdireccion.Text = "";
                            txtapellido.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Datos Faltantes", "Correcion en datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos Faltantes", "Correcion en datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
