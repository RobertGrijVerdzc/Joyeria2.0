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
using System.IO;

namespace Joyeria2._0
{
    public partial class Frmaddprod : Form
    {
        string sql;
        clssutil select = new clssutil();
        public Frmaddprod()
        {
            InitializeComponent();
        }
        private void txtidprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
            if (e.KeyChar == (char)13)
            {
                sql = "Select * from Articulos where IDarticulos = '" + txtidprod.Text+"'";
                select.busqueda(sql);
                if (select.numero == 1)
                {
                    sql = "update Articulos set cantidad = cantidad +1 where IDarticulos = '"+txtidprod.Text+"'";
                    select.consultadata(sql);
                    eliminartodo();
                }
                else
                {
                      
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void NUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void CBtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void CBCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pctprod.Load(this.openFileDialog1.FileName);
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
                if (txtprecio.Text != "" && txtnombre.Text != "")
                {

                    //string query = "Insert into Articulos (Nombre, Categoria,Color,estilo,marca,forma,grosor,largo,Precio) Values ('"+txtnombre.Text+"', '"+CBCategoria.Text+"', '"+txtnombre.Text+"')";
                    if (lblfrm.Text == "Agregar")
                    {
                        sql = "insert into Articulos (IDarticulos, Nombre, Categoria, Color, estilo, marca, forma, grosor, largo, Precio, imagen, cantidad) values ('" + txtidprod.Text+"', '"+txtnombre.Text+"', '"+ CMBcateg.Text+ "', '"+txtcolor.Text+"', '"+CMBestilo.Text+"', '"+txtmarca.Text+"', '"+CMBestilo.Text+"', '"+txtgrosor.Text+"', '"+txtlargo.Text+"', '"+txtprecio.Text+"', '"+ pctprod.Image + "', '"+txtcantidad.Value +"')";
                        select.consultadata(sql);
                        eliminartodo();
                    }
                    else if (lblfrm.Text == "Actualizar")
                    {
                        sql = "Update Articulos SET Nombre = '" + txtnombre.Text + "', Precio = '" + txtprecio.Text + "', Cantidad = '"+txtcantidad.Value +"',Color = '"+txtcolor.Text+"', largo= '"+txtlargo.Text+"', Categoria = '"+CMBcateg.Text+"', marca= '"+txtmarca.Text+"', imagen = '"+ pctprod.Image +"', estilo = '"+CMBestilo.Text+"', grosor= '"+txtgrosor.Text+"', forma= '"+CMBestilo.Text+"' where IDarticulos = '" + txtidprod.Text + "'";
                        select.actualizar(sql);
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Datos");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Al intentar" + lblfrm.Text, "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Frmaddprod_Load(object sender, EventArgs e)
        {
            selects();
        }
        private void selects()
        {
            if (lblfrm.Text == "Actualizar")
            {
                if (txtidprod.Text != "")
                {
                    string sql = "select * from Articulos where IDarticulos= '" + txtidprod.Text + "'";
                    select.Select(sql);
                    if (select.reader.Read())
                    {
                        txtnombre.Text = select.reader["Nombre"].ToString();
                        //txtdescripcion.Text = select.reader["Descripcion"].ToString();
                        CMBcateg.Text = select.reader["Categoria"].ToString();
                        txtprecio.Text = select.reader["Precio"].ToString();
                        try
                        {
                            txtcantidad.Value = Convert.ToDecimal(select.reader["cantidad"].ToString());
                        }
                        catch (Exception)
                        {

                            txtcantidad.Value = 0;
                        }
                        txtgrosor.Text = select.reader["grosor"].ToString();
                        CMBestilo.Text = select.reader["estilo"].ToString();
                        CMBcateg.Text = select.reader["Categoria"].ToString();
                        txtcolor.Text = select.reader["Color"].ToString();
                        txtmarca.Text = select.reader["Marca"].ToString();
                        txtlargo.Text = select.reader["largo"].ToString();
                    }
                    select.reader.Close();
                }
            }
        }

        private void Frmaddprod_FormClosing(object sender, FormClosingEventArgs e)
        {
            eliminartodo();
        }

        private void eliminartodo()
        {
            txtidprod.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtcantidad.Value = 0;
            CMBcateg.Text = "";
            txtprecio.Text = "";
            txtgrosor.Text = "";
            CMBestilo.Text = "";
            CMBcateg.Text = "";
            txtcolor.Text = "";
            txtmarca.Text = "";
            txtlargo.Text = "";
        }
    }
}
