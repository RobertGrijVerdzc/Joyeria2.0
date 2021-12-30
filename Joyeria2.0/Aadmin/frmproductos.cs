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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;


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
            try
            {
                bunifuCustomDataGrid1.DataSource = consultas.tabla("select IDarticulos as ID, NombreArt as Nombre, cantidadArt as Stock, PrecioArt as Precio, Nombrecat as Categoria, NombreMaterial as Material from Articulos inner join categorias on Articulos.CategoriaArt = categorias.IDcat inner join Materialesart on Articulos.idmaterial = Materialesart.IDmaterial");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }
        private void frmproductos_Load(object sender, EventArgs e)
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = consultas.tabla("select IDarticulos as ID, NombreArt as Nombre, cantidadArt as Stock, PrecioArt as Precio, Nombrecat as Categoria, NombreMaterial as Material from Articulos inner join categorias on Articulos.CategoriaArt = categorias.IDcat inner join Materialesart on Articulos.idmaterial = Materialesart.IDmaterial");
                consultas.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta");
            }
        }

        private void btnimprim_Click(object sender, EventArgs e)
        {
            DataSetproduc ds = new DataSetproduc();
            int filas = bunifuCustomDataGrid1.Rows.Count;
            for (int i = 0; i <= filas - 1; i++)
            {
                ds.Tables[0].Rows.Add
                    (new object[] { bunifuCustomDataGrid1[0,i].Value.ToString(),
                    bunifuCustomDataGrid1[1,i].Value.ToString(),
                    bunifuCustomDataGrid1[2,i].Value.ToString(),
                    bunifuCustomDataGrid1[3,i].Value.ToString(),
                    bunifuCustomDataGrid1[4,i].Value.ToString(),
                    bunifuCustomDataGrid1[5,i].Value.ToString()
                    });
            }
            ReportDocument reps = new ReportDocument();
            reps.Load("C:\\Users\\Roberto\\Desktop\\Nueva carpeta (2)\\Trabajo del indelfonso\\4to\\Joyeria2.0\\Joyeria2.0\\CrystalReportproductos.rpt");
            reps.SetDataSource(ds);
            Frmreporproduc reportes = new Frmreporproduc();
            reportes.crystalReportViewer1.ReportSource = reps;
            reportes.ShowDialog();
        }
    }
}
