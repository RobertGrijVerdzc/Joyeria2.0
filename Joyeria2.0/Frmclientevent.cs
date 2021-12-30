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
    public partial class Frmclientevent : Form
    {
        public string Myname;
        public string myid;
        public string myname
        {
            get { return Myname; }
            set { Myname = value; }
        }
        public string MYID
        {
            get { return myid; }
            set { myid = value; }
        }
        clssutil consultas = new clssutil();
        Frmventas mandar = new Frmventas();
        public Frmclientevent()
        {
            InitializeComponent();
            datagri();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Frmaddclientes abrir = new Frmaddclientes();
            //abrir.lbltitle.Text = "Agregar Cliente Ventas";
            //abrir.Show();
        }
        private void datagri()
        {
            try
            {
                datagridventbusclie.DataSource = consultas.tabla("Select IDcliente as ID, Nombreclie as Nombre, Apellidoclie as Apellido, Domicilioclien as Domicilio, Numeroclie as Telefono, Correoclie as Email from Clientes");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Eror en la busqueda de Clientes");
            }
        }

        private void datagridventbusclie_DoubleClick(object sender, EventArgs e)
        {
            if (lblform.Text == "")
            {
                txtidbuscar.Text = datagridventbusclie.SelectedRows[0].Cells[0].Value.ToString();
            }
            else if (lblform.Text == "Cliente Apartado")
            {
                txtidbuscar.Text = datagridventbusclie.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void txtidbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                datagridventbusclie.DataSource = consultas.tabla("Select IDcliente as ID, Nombreclie as Nombre, Apellidoclie as Apellido, Domicilioclien as Domicilio, Numeroclie as Telefono, Correoclie as Email from Clientes where Nombreclie like '" + txtidbuscar.Text + "%' ");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Eror en la busqueda de Clientes");
            }
        }

        private void Frmclientevent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
        }

        private void Frmclientevent_Load(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            try
            {
                    myname = datagridventbusclie.SelectedRows[0].Cells[0].Value.ToString();
                    MYID = datagridventbusclie.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Escoger un cliente");
            }
        }
    }
}
