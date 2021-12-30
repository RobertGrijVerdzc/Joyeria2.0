using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Joyeria2._0
{
    class clssutil
    {
        public string conexion = "Data Source=Roberto;Initial Catalog=joyeria;Integrated Security=True";
        public static string cadena = "Data Source=Roberto;Initial Catalog=joyeria;Integrated Security=True";
        public string Correc = "";
        public SqlDataReader reader;
        public SqlDataReader read2;
        public DataSet ds;
        public DataTable dt;
        public SqlConnection con = new SqlConnection(cadena);
        public int numero;
        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }

        public DataTable tabla(string sql)
        {
            con.Open();
            //el datatable nos ayuda a guardar los datos de la tabla que hemos selecionado en la consulta
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            //en esta parte se ejecuta la consulta sql para obtener la tabla
            da.SelectCommand = new SqlCommand(sql, con);
            //aqui llenamos el dataset con lo que contiene el dataadapter
            da.Fill(ds);
            //aqui guardamos en el datatable la tabla espesifica del dataset
            dt = ds.Tables[0];
            //finalmente retornamos el dt
            return dt;
        }
        public void Insertar(string query, string frm)
        {
            Correc = "0";
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand exe = new SqlCommand(query, con);
            con.Open();
            exe.ExecuteNonQuery();
            MessageBox.Show("Datos " + frm + " Guardados Correctamente", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Correc = "1";
            con.Close();
        }

        
        public void Delete(string sql)
        {
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand exe = new SqlCommand(sql, cn);
            cn.Open();
            exe.ExecuteNonQuery();
            MessageBox.Show("Datos Eliminados");
            cn.Close();
        }

        public void Combo(string sql)
        {
                SqlCommand cm = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                dt.Rows.InsertAt(fila, 0);
        }

        public void actualizar(string sql)
        {
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand exe = new SqlCommand(sql, con);
            con.Open();
            exe.ExecuteNonQuery();
            MessageBox.Show("Datos Actualizados", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Correc = "1";
            con.Close();
        }
        public void consultadata(string sql)
        {
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();        
        }
        public void Select(string sql)
        {
            SqlCommand exe = new SqlCommand(sql, con);
            con.Open();
            reader = exe.ExecuteReader();
        }
        public void reader2(string sql)
        {
            SqlCommand exe = new SqlCommand(sql, con);
            con.Open();
            read2 = exe.ExecuteReader();
        }

        public void select4(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataAdapter dp = new SqlDataAdapter(command);
            ds = new DataSet("Empleados");
            byte[] MyData = new byte[0];
            dp.Fill(ds, "Empleados");
        }

        public void consultaspruebas(string sql)
        {
            Correc = "0";
            SqlCommand exe = new SqlCommand(sql, con);
            con.Open();
            if (exe.ExecuteNonQuery() > 0)
            {
                Correc = "1";
            }
        }
        #region busqueda
        public void busqueda(string sql)
        {
            numero = 0;
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (Convert.ToInt32(reader.Read()) > 0)
            {
                numero = 1;
            }
            con.Close();
        }
        #endregion
        public static void Sololetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void Solonumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
