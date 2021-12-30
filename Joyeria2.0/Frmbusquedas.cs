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
    
    public partial class Frmbusquedas : Form
    {
        public string Myname;
        public string myname
        {
            get { return Myname; }
            set { Myname = value; }
        }
        clssutil select = new clssutil();
        public Frmbusquedas()
        {
            InitializeComponent();
        }
        private void Comboxclie()
        {
            try
            {
                string sql = "select IDcliente, Nombreclie from Clientes";
                select.Combo(sql);
                CMBCliente.ValueMember = "Nombreclie";
                CMBCliente.DataSource = select.dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Error Categoria");
            }
        }
        private void Comboxemple()
        {
            try
            {
                string sql = "select IDempleado, Nombreempl from Empleados";
                select.Combo(sql);
                CMBempleado.ValueMember = "Nombreempl";
                CMBempleado.DataSource = select.dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Error Categoria");
            }
        }
        private void selectempleado()
        {
            try
            {
                string sqls = "select IDempleado from Empleados where Nombreempl = '" + CMBempleado.Text + "'";
                select.Select(sqls);
                if (select.reader.Read())
                {
                    lblempleado.Text = select.reader["IDempleado"].ToString();
                }
                select.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la carga del Materias");
            }
        }
        private void selecliente()
        {
            try
            {
                string sqls = "select IDcliente from Clientes where Nombreclie = '" + CMBCliente.Text + "'";
                select.Select(sqls);
                if (select.reader.Read())
                {
                    lblcliente.Text = select.reader["IDcliente"].ToString();
                }
                select.con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la carga del Materias");
            }
        }
        private void Frmbusquedas_Load(object sender, EventArgs e)
        {
            CMBempleado.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            Comboxemple();
            Comboxclie();
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            try
            {
                tmr1.Format = DateTimePickerFormat.Custom;
                tmr1.CustomFormat = "yyyy-MM-dd";
                tmr2.Format = DateTimePickerFormat.Custom;
                tmr2.CustomFormat = "yyyy-MM-dd";
                selectempleado();
                selecliente();
                if (lblcliente.Text != "" && lblempleado.Text != "")
                {
                    myname = "select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente, totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado where IDempleado = '" + lblempleado.Text + "' and IDcliente = '" + lblcliente.Text + "' and fecha between '" + tmr1.Text + "' and '" + tmr2.Text + "'";
                }
                else if (lblcliente.Text != "" && lblempleado.Text == "")
                {
                    myname = "select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente, totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado where IDcliente = '" + lblcliente.Text + "' and fecha between '" + tmr1.Text + "' and '" + tmr2.Text + "'";
                }
                else if (lblempleado.Text != "" && lblcliente.Text == "")
                {
                    myname = "select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente, totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado where IDempleado = '" + lblempleado.Text + "' and fecha between '" + tmr1.Text + "' and '" + tmr2.Text + "'";
                }
                else if (lblcliente.Text == "" && lblempleado.Text == "")
                {
                    myname = "select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente, totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado where fecha between '" + tmr1.Text + "' and '" + tmr2.Text + "'";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Escoger una fecha");
            }
        }
    }
}
