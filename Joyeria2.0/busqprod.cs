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
    
    public partial class busqprod : Form
    {
        public string Myname;
        public string myname
        {
            get { return Myname; }
            set { Myname = value; }
        }
        clssutil consultas = new clssutil();
        public busqprod()
        {
            InitializeComponent();
        }

        private void txtavanzaprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            datagridprodavan.DataSource = consultas.tabla("select IDarticulos as ID, NombreArt as Nombre, PrecioArt as Precio, Nombrecat as Categoria, NombreMaterial as Material from Articulos inner join categorias on Articulos.CategoriaArt = categorias.IDcat inner join Materialesart on Articulos.idmaterial = Materialesart.IDmaterial where NombreArt like '"+txtavanzaprod.Text+"%'");
            consultas.con.Close();
        }

        private void datagridprodavan_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtavanzaprod.Text = datagridprodavan.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void bnenvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtavanzaprod.Text != "")
                {
                    myname = datagridprodavan.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Escoger un articulo");
            }
        }

        private void busqprod_Load(object sender, EventArgs e)
        {

        }
    }
}
