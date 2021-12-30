using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Joyeria2._0
{
    class Conexion
    {
        public static string strconex = "Data Source=Roberto;Initial Catalog=joyeria;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconex);

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
    }
}
