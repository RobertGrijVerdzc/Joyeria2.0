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

        private void btnguardarclientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtapellido.Text != "" && txtcorreo.Text != "" && txtdireccion.Text != "" && txtelefono.Text != "" && txtnombre.Text != "")
                {
                    if (lbltitle.Text == "Agregar")
                    {
                        string query = "Insert into Clientes (Nombre, Apellido, Domicilio, Correo, Numero) Values ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtdireccion.Text + "', '" + txtcorreo.Text + "', '" + txtelefono.Text + "')";
                        util.Insertar(query, "Cliente");
                        if (util.Correc == "1")
                        {
                            txtnombre.Text = "";
                            txtelefono.Text = "";
                            txtcorreo.Text = "";
                            txtdireccion.Text = "";
                            txtapellido.Text = "";
                        }
                    }
                    else if (lbltitle.Text == "Actualizar")
                    {
                        string query = "Update Clientes Set Nombre = '"+txtnombre.Text+"', Apellido= '"+txtapellido.Text+"', Domicilio= '"+txtdireccion.Text+"', Correo= '"+txtcorreo.Text+"', Numero = '"+txtelefono.Text+"' ";
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
        private void busqueda()
        {
            if (lblid.Text != "")
            {
                string sql = "Select * from Clientes where IDcliente = '" + lblid.Text + "'";
                util.Select(sql);
                if (util.reader.Read())
                {
                    txtnombre.Text = util.reader["Nombre"].ToString();
                    txtapellido.Text = util.reader["Apellido"].ToString();
                    txtcorreo.Text = util.reader["correo"].ToString();
                    txtelefono.Text = util.reader["Numero"].ToString();
                    txtdireccion.Text = util.reader["Domicilio"].ToString();
                }
                util.reader.Close();
            }
        }

        private void Frmaddclientes_Load(object sender, EventArgs e)
        {
            busqueda();
        }
    }
}
