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
using BarcodeLib;
using System.Drawing.Imaging;

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

        private void generarcodigo()
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panel1.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtidprod.Text, Color.Black, Color.White, 400, 100);
        }
        private void txtidprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
            if (e.KeyChar == (char)13)
            {
                if (txtidprod.Text != "")
                {
                    sql = "Select * from Articulos where IDarticulos = '" + txtidprod.Text + "'";
                    select.busqueda(sql);
                    if (select.numero == 1)
                    {
                        sql = "update Articulos set cantidadArt = cantidadArt +1 where IDarticulos = '" + txtidprod.Text + "'";
                        select.consultadata(sql);
                        eliminartodo();
                    }
                    else
                    {
                        generarcodigo();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un ID");
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
            //try
            //{
            //    this.openFileDialog1.ShowDialog();
            //    if (this.openFileDialog1.FileName.Equals("") == false)
            //    {
            //        pctprod.Load(this.openFileDialog1.FileName);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            //}

        }
        private void seletcat()
        {
            string sqls = "select IDcat from categorias where Nombrecat = '" + CMBcategoria.Text + "'";
            select.Select(sqls);
            if (select.reader.Read())
            {
                lblidcateg.Text = select.reader["IDcat"].ToString();
            }
            select.con.Close();
        }
        private void selectmate()
        {
            try
            {
                string sqls = "select IDmaterial from Materialesart where NombreMaterial = '" + CMBmaterial.Text + "'";
                select.Select(sqls);
                if (select.reader.Read())
                {
                    lblmater.Text = select.reader["IDmaterial"].ToString();
                }
                select.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la carga del Materias");
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
                sql = "Select * from Articulos where IDarticulos = '" + result.ToString() + "'";
                select.consultaspruebas(sql);
                if (select.Correc == "1")
                {
                    select.con.Close();
                    ramdom();
                }
                else
                {
                    txtidprod.Text = Convert.ToString(result.ToString());
                }
                select.con.Close();
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
                if (txtprecio.Text != "" && txtnombre.Text != "")
                {
                    //string query = "Insert into Articulos (Nombre, Categoria,Color,estilo,marca,forma,grosor,largo,Precio) Values ('"+txtnombre.Text+"', '"+CBCategoria.Text+"', '"+txtnombre.Text+"')";
                    if (lblfrm.Text == "Agregar")
                    {
                        seletcat();
                        selectmate();
                        if (txtidprod.Text == "")
                        {
                            ramdom();
                            sql = "insert into Articulos (IDarticulos, NombreArt, CategoriaArt, ColorArt, idmaterial, marcaArt, grosorArt, largoArt, PrecioArt, cantidadArt) values ('" + txtidprod.Text + "', '" + txtnombre.Text + "', '" + lblidcateg.Text + "', '" + txtcolor.Text + "', '" + lblmater.Text + "', '" + txtmarca.Text + "', '" + txtgrosor.Text + "', '" + txtlargo.Text + "', '" + txtprecio.Text + "', '" + txtcantidad.Value + "')";
                            select.consultadata(sql);
                            generarcodigo();
                            guardarimagr();
                            eliminartodo();
                        }
                        else
                        {
                            sql = "insert into Articulos (IDarticulos, NombreArt, CategoriaArt, ColorArt, idmaterial, marcaArt, grosorArt, largoArt, PrecioArt, cantidadArt) values ('" + txtidprod.Text + "', '" + txtnombre.Text + "', '" + lblidcateg.Text + "', '" + txtcolor.Text + "', '" + lblmater.Text + "', '" + txtmarca.Text + "', '" + txtgrosor.Text + "', '" + txtlargo.Text + "', '" + txtprecio.Text + "', '" + txtcantidad.Value + "')";
                            select.consultadata(sql);
                            generarcodigo();
                            guardarimagr();
                            eliminartodo();
                        }
                    }
                    else if (lblfrm.Text == "Actualizar")
                    {
                        seletcat();
                        selectmate();
                        sql = "Update Articulos SET NombreArt = '" + txtnombre.Text + "', PrecioArt = '" + txtprecio.Text + "', CantidadArt = '" + txtcantidad.Value + "',ColorArt = '" + txtcolor.Text + "', largoArt= '" + txtlargo.Text + "', CategoriaArt = '" + lblidcateg.Text + "', marcaArt= '" + txtmarca.Text + "', idmaterial = '" + lblmater.Text + "', grosorArt= '" + txtgrosor.Text + "' where IDarticulos = '" + txtidprod.Text + "'";
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

        private void guardarimagr()
        {
            Image imgFinal = (Image)panel1.BackgroundImage.Clone();

            SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
        private void Frmaddprod_Load(object sender, EventArgs e)
        {
            Comboxcat();
            Comboxmate();
            selects();
        }
        private void selects()
        {
            try
            {
                if (lblfrm.Text == "Actualizar")
                {
                    if (txtidprod.Text != "")
                    {
                        string sql = "select* from Articulos inner join categorias on Articulos.CategoriaArt = categorias.IDcat inner join Materialesart on Articulos.idmaterial = Materialesart.IDmaterial where IDarticulos = '" + txtidprod.Text + "'";
                        select.Select(sql);
                        if (select.reader.Read())
                        {
                            txtnombre.Text = select.reader["NombreArt"].ToString();
                            //txtdescripcion.Text = select.reader["Descripcion"].ToString();
                            CMBcategoria.Text = select.reader["Nombrecat"].ToString();
                            lblidcateg.Text = select.reader["CategoriaArt"].ToString();
                            txtprecio.Text = select.reader["PrecioArt"].ToString();
                            try
                            {
                                txtcantidad.Value = Convert.ToDecimal(select.reader["cantidadArt"].ToString());
                            }
                            catch (Exception)
                            {

                                txtcantidad.Value = 0;
                            }
                            txtgrosor.Text = select.reader["grosorArt"].ToString();
                            CMBmaterial.Text = select.reader["NombreMaterial"].ToString();
                            txtcolor.Text = select.reader["ColorArt"].ToString();
                            txtmarca.Text = select.reader["marcaArt"].ToString();
                            txtlargo.Text = select.reader["largoArt"].ToString();
                        }
                        select.con.Close();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el Producto");
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
            txtcantidad.Value = 0;
            CMBmaterial.Text = "";
            txtprecio.Text = "";
            txtgrosor.Text = "";
            CMBcategoria.Text = "";
            CMBmaterial.Text = "";
            txtcolor.Text = "";
            txtmarca.Text = "";
            txtlargo.Text = "";
            panel1.BackgroundImage = null;
        }
        private void Comboxmate()
        {
            string sql = "select * from Materialesart";
            select.Combo(sql);
            CMBmaterial.ValueMember = "NombreMaterial";
            CMBmaterial.DataSource = select.dt;
        }
        private void Comboxcat()
        {
            try
            {
                string sql = "Select IDcat, Nombrecat from categorias";
                select.Combo(sql);
                CMBcategoria.ValueMember = "Nombrecat";
                CMBcategoria.DataSource = select.dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Error Categoria");
            }
        }

        private void CMBmaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);

        }

        private void CMBcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);

        }

        private void txtgrosor_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void txtlargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Sololetras(e);
        }

        private void btnprueas_Click(object sender, EventArgs e)
        {
            ramdom();
        }

        private void CMBmaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
