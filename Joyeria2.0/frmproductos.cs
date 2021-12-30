using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Joyeria2._0
{
    public partial class frmproductos : Form
    {
        clssutil consultas = new clssutil();
        Frmaddprod abrir = new Frmaddprod();
        public frmproductos()
            
        {
            InitializeComponent();
        }
        private void btnfrmaddproducto_Click(object sender, EventArgs e)
        {
            abrir.lblfrm.Text = "Agregar";
            abrir.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                abrir.lblfrm.Text = "Actualizar";
                abrir.btnguardar.Text = "Actualizar";
                abrir.txtidprod.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                    abrir.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccion algun producto para actualizar", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void btnelimina_Click(object sender, EventArgs e)
        {
            try
            {
                lblid.Text = "";
                lblid.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                if (lblid.Text == "")
                {
                    MessageBox.Show("Seleccione Al cliente");
                }
                else
                {
                    string sql = "delete from Articulos where IDarticulos = '" + lblid.Text + "'";
                    consultas.Delete(sql);
                    consulta();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione al Cliente", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void consulta()
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDarticulos as ID, Nombre, marca as Marca, Color, estilo As Estilo,forma as Forma, grosor as Grosor, largo as Margen  from Articulos");
        }
        private void frmproductos_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = consultas.tabla("Select IDarticulos as ID, Nombre, marca as Marca, Color, estilo As Estilo,forma as Forma, grosor as Grosor, largo as Margen  from Articulos");
        }
    }
}
