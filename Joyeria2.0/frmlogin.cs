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
    public partial class frmlogin : Form
    {
        string hora;
        Frmventas abrir = new Frmventas();
        clslogin classlogin = new clslogin();

        public frmlogin()
        {
            InitializeComponent();
        }
        private void sesion()
        {
            try
            {
                hora = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

                if (txtuser.Text != "" && txtpass.Text != "")
                {
                    classlogin.datos(txtuser.Text, txtpass.Text, hora);
                    if (classlogin.Nombre == txtuser.Text && classlogin.Contra == txtpass.Text && classlogin.TIPO == "1")
                    {
                        MessageBox.Show("Bienvenido " + classlogin.Nombre, "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        frmadmin abrir = new frmadmin();
                        abrir.lblnombre.Text = classlogin.Nombre;
                        abrir.lblpuesto.Text = classlogin.puesto;
                        abrir.Show();
                        this.Hide();
                    }
                    else if (classlogin.Nombre == txtuser.Text && classlogin.Contra == txtpass.Text && classlogin.TIPO == "2")
                    {
                        MessageBox.Show("Bienvenido " + classlogin.Nombre, "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        abrir.lblidemple.Text = classlogin.id;
                        abrir.lblnombreemple.Text = classlogin.Nombre;
                        abrir.Show();
                        this.Hide();
                    }
                    else if (classlogin.Nombre == null && classlogin.Contra == null)
                    {
                        MessageBox.Show("Datos Incorrectos intente de nuevo", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtuser.Text = null;
                        txtpass.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Llenar los campos faltantes", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtuser.Text = null;
                    txtpass.Text = null;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Datos Incorrectos Intente de nuevo", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtuser.Text = null;
                txtpass.Text = null;
            }
        }
        private void btnsesion_Click(object sender, EventArgs e)
        {
            sesion();   
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                sesion();
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void tmr_Tick(object sender, EventArgs e)
        {

        }
    }
}
