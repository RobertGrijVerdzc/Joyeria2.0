using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyeria2._0
{
    class clsempresa
    {
        public static string cadena = "Data Source=Roberto;Initial Catalog=joyeria;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(cadena);
        public static string sql = "select * from config inner join Empresa on config.IDempresaconfig = Empresa.IDempresa";
        public static SqlCommand cmd;
        public static int ID;
        public static string Nombre;
        public static int Numero;
        public static string Correo;
        public static string Direccion;
        public static string RFC;
        public static decimal pagos;
        public static decimal iva;
        public static float descuento;
        public static void empresa()
        {
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = Convert.ToInt32(reader["IDempresaconfig"].ToString());
                    Nombre = reader["Nombreempre"].ToString();
                    Direccion = reader["Direccionempre"].ToString();
                    Correo = reader["Correoempre"].ToString();
                    Numero = Convert.ToInt32(reader["Telefonoempre"].ToString());
                    RFC = reader["RFCempre"].ToString();
                    iva = Convert.ToDecimal(reader["ivaconfig"].ToString());
                    pagos = Convert.ToDecimal(reader["pagosconfig"].ToString());
                    descuento = Convert.ToInt32(reader["descuentoconfig"].ToString());
                }
            con.Close();
        }
            catch (Exception)
            {
                MessageBox.Show("Contacte al Administrador", "Aviiso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
}
    }
}
