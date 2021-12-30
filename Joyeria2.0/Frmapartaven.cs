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
    public partial class Frmapartaven : Form
    {
        clssutil util = new clssutil();
        string sql;
        impres ticket = new impres();

        public Frmapartaven()
        {
            InitializeComponent();
        }
        private void sumasdescu()
        {
            try
            {
                float subtotal = float.Parse(lblsub.Text);
                double iva = 0.16;
                float ivas = subtotal * Single.Parse(iva.ToString());
                lbliva.Text = ivas.ToString();
                float total = ivas + float.Parse(subtotal.ToString());
                lbltotal.Text = total.ToString();
                lbltotalescondidos.Text = total.ToString();
                double primerpago = Convert.ToDouble(lbltotalescondidos.Text) * Convert.ToDouble(lbldescuento.Text);
                lblprimerpago.Text = primerpago.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Upps, Algun Error en sumar IVA", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        private void sumasytodo()
        {
            try
            {
                double sbu = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    sbu = sbu + Convert.ToDouble(item.Cells["Costo"].Value);
                }
                lblsub.Text = sbu.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error en sumar los precios de productos", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }
        private void inserdetalles()
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    sql = "insert into detallarticu(cantidadarticudetall,IDarticulosdetall, idpagodetals) values ('" + item.Cells["Cantidad"].Value + "', '" + item.Cells["ID"].Value + "', '" + lblidpago.Text + "')";
                    util.consultadata(sql);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error Insertar Datos a detalles", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        private void insertarpago()
        {
            try
            {
                sql = "insert into pago(Subtotalpago, ivapag, totalpago, cambio) values ('" + lblsub.Text + "', '" + lbliva.Text + "', '" + lbltotalescondidos.Text + "', '" + lblcambio.Text + "')";
                util.consultadata(sql);
                sql = "select MAX(IDpado) as IDpado from pago where Subtotalpago = '" + lblsub.Text + "' and ivapag = '" + lbliva.Text + "' and totalpago = '" + lbltotalescondidos.Text + "' and cambio = '" + lblcambio.Text + "'";
                util.Select(sql);
                if (util.reader.Read())
                {
                    lblidpago.Text = util.reader["IDpado"].ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error Insertar Datos a pago", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        private void insertarapartado()
        {
            try
            {
                if (lblidcliente.Text != "" && lblidpago.Text != "" && lblidemple.Text != "")
                {
                    sql = "insert into Apartado (IDempleadoapa, IDclienteapar, idpagoapart, fechafinalapart, fechainicioapart, Pago1, Totalapart) values ('" + lblidemple.Text + "', '" + lblidcliente.Text + "', '" + lblidpago.Text + "', '" + lblfecha30dias.Text + "', '" + lbldatetimer.Text + "', '" + lblprimerpago.Text + "', '" + lbltotal.Text + "')";
                    util.consultadata(sql);
                }
                else
                {
                    MessageBox.Show("Faltan datos de Cliente, Pago o Empleado");
                }
        }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error Insertar Datos a Apartado", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
}

        private void Frmapartaven_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frmventas abrir = new Frmventas();
            abrir.lblidemple.Text = lblidemple.Text;
            abrir.lblnombreemple.Text = lblnombremeple.Text;
            abrir.Show();
            this.Hide();
        }

        private void txtidbusuqeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                clssutil.Solonumeros(e);
                if (e.KeyChar == (char)13)
                {
                    util.con.Close();
                    string sql = "select IDarticulos, NombreArt, PrecioArt, cantidadArt from Articulos where IDarticulos = '" + txtidbusuqeda.Text + "'";
                    util.Select(sql);
                    if (util.reader.Read())
                    {
                        if (Convert.ToInt32(util.reader["cantidadArt"].ToString()) <= 0)
                        {
                            MessageBox.Show("Este articulo no esta disponible");
                        }
                        else
                        {
                            string numero = util.reader["IDarticulos"].ToString();
                            descontarpro(Convert.ToInt64(numero));
                            foreach (DataGridViewRow item in dataGridView1.Rows)
                            {
                                if (numero == Convert.ToString(item.Cells["ID"].Value))
                                {
                                    item.Cells["Cantidad"].Value = Convert.ToInt32(item.Cells["Cantidad"].Value) + 1;
                                    sql = "Select * from Articulos where IDarticulos = '" + numero + "'";
                                    item.Cells["Costo"].Value = Convert.ToDouble(item.Cells["Cantidad"].Value) * Convert.ToDouble(util.reader["PrecioArt"].ToString());
                                    txtidbusuqeda.Text = "";
                                    lblcambio.Text = "0.00";
                                    util.con.Close();
                                    sumasytodo();
                                    sumasdescu();
                                    return;
                                }
                            }
                            dataGridView1.Rows.Add(util.reader["IDarticulos"].ToString(), util.reader["NombreArt"].ToString(), "1", util.reader["PrecioArt"].ToString(), util.reader["PrecioArt"].ToString());
                            txtidbusuqeda.Text = "";
                            util.con.Close();
                            sumasytodo();
                            sumasdescu();
                        }
                    }
                    else
                    {
                        txtidbusuqeda.Text = "";
                        MessageBox.Show("Este Articulo no exise", "Verifique el codigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error Insertar Datos de busqueda", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            clssutil.Solonumeros(e);
            try
            {
                if (lblidcliente.Text != "")
                {
                    if (lbltotal.Text != "0.00")
                    {
                        if (e.KeyChar == (char)13)
                        {
                            float pago = Single.Parse(txtpago.Text);
                            if (Convert.ToDecimal(txtpago.Text) < Convert.ToDecimal(lblprimerpago.Text))
                            {
                                float sums = Single.Parse(lbltotal.Text) - Single.Parse(txtpago.Text);
                                lbltotal.Text = sums.ToString();
                                txtpago.Text = "";
                            }
                            else if (Convert.ToDecimal(txtpago.Text) >= Convert.ToDecimal(lblprimerpago.Text))
                            {
                                float sums = Single.Parse(lbltotal.Text) - Single.Parse(txtpago.Text);
                                lbltotal.Text = sums.ToString();
                                DialogResult opcion;
                                opcion = MessageBox.Show("¿Guardar Apartado?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                if (opcion == DialogResult.Yes)
                                {
                                    insertarpago();
                                    inserdetalles();
                                    insertarapartado();
                                    tickets();
                                    dataGridView1.Rows.Clear();
                                    txtpago.Text = "";
                                    lbltotal.Text = "";
                                    lblsub.Text = "";
                                    lbliva.Text = "";
                                    lblprimerpago.Text = "";
                                }
                                else
                                {

                                }

                            }
                            else if (Convert.ToDecimal(txtpago.Text) >= Convert.ToDecimal(lbltotal.Text))
                            {
                                float sums = Single.Parse(txtpago.Text) - Single.Parse(lbltotal.Text);
                                lblcambio.Text = sums.ToString();
                                insertarpago();
                                inserdetalles();
                                insertarapartado();
                                dataGridView1.Rows.Clear();
                                txtpago.Text = "";
                                lbltotal.Text = "";
                                lblsub.Text = "";
                                lbliva.Text = "";
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Agrege al cliente");
                    txtpago.Text = "";
                }
        }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error en calculo del pago", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
}

        private void Frmapartaven_Load(object sender, EventArgs e)
        {
            try
            {
                lbldatetimer.Text = DateTime.Now.ToString("yyyy-MM-dd");
                DateTime fecha = DateTime.Today.AddMinutes(2);
                lblfecha30dias.Text = fecha.ToString("yyyy-MM-dd");
                clsempresa.empresa();
                decimal desc = clsempresa.pagos;
                lbldescuento.Text = "0." + desc;
            }
            catch (Exception)
            {

                MessageBox.Show("Upps, Algun Error", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnavanzado_Click(object sender, EventArgs e)
        {

            try
            {
                busqprod f = new busqprod();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    txtidbusuqeda.Text = f.myname;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Abrir la ventana de productos");
            }
        }
        private void descontarpro(Int64 id)
        {
            try
            {
                sql = "update Articulos set cantidadArt = cantidadArt - 1 where IDarticulos = '" + id + "'";
                util.consultadata(sql);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro al descontar al producto");
            }
        }
        private void sumarprodu()
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    sql = "update Articulos set cantidadArt = cantidadArt + '" + item.Cells["Cantidad"].Value + "' where IDarticulos = '" + item.Cells["ID"].Value + "'";
                    util.consultadata(sql);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro al sumar el producto");
            }
        }
        private void btncliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Cliente Nuevo?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (opcion == DialogResult.No)
                {
                    Frmclientevent f = new Frmclientevent();
                    f.lblform.Text = "Cliente Apartado";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        lblidcliente.Text = f.myname;
                        lblnombrecliente.Text = f.MYID;
                    }
                }
                else
                {
                    Frmaddclientes r = new Frmaddclientes();
                    r.lbltitle.Text = "Agregar Cliente Ventas Apartado";
                    if (r.ShowDialog() == DialogResult.OK)
                    {
                        lblidcliente.Text = r.myname;
                        lblnombrecliente.Text = r.myid;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Integrar al cliente en el apartado");
            }
        }

        private void btnelipro_Click(object sender, EventArgs e)
        {
            sumarprodu();
            Frmapartaven abrir = new Frmapartaven();
            this.Hide();
            abrir.lblidemple.Text = lblidemple.Text;
            abrir.lblnombremeple.Text = lblnombremeple.Text;
            abrir.Show();
        }
        private void tickets()
        {
            clsempresa.empresa();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(clsempresa.Nombre);
            ticket.TextoIzquierda("DIREC: " + clsempresa.Direccion);
            ticket.TextoIzquierda("TELEF: " + clsempresa.Numero);
            ticket.TextoIzquierda("R.F.C: " + clsempresa.RFC);
            ticket.TextoIzquierda("EMAIL: " + clsempresa.Correo);//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # 1", "Ticket # 002-0000006");
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: " + lblnombremeple.Text);
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("SIGUIENTE FECHA A PAGAR: " + lblfecha30dias.Text);
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dataGridView1.Rows)//dgvLista es el nombre del datagridview
            {
                ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), int.Parse(fila.Cells[2].Value.ToString()), decimal.Parse(fila.Cells[3].Value.ToString()), decimal.Parse(fila.Cells[4].Value.ToString()));
            }
            //ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL......$", Convert.ToDecimal(lblsub.Text));
            ticket.AgregarTotales("         IVA...........$", Convert.ToDecimal(lbliva.Text));//La M indica que es un decimal en C#
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         Total........$", Convert.ToDecimal(lbltotalescondidos.Text));
            ticket.AgregarTotales("         Usted debe........$", Convert.ToDecimal(lbltotal.Text));

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }

        private void btnelimi_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update Articulos set cantidadArt = cantidadArt + '" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "' where IDarticulos = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                util.consultadata(sql);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor Selecciona el articulo a eliminar");
            }
        }

        private void txtpago_TextChange(object sender, EventArgs e)
        {

        }
    }
}
