using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyeria2._0
{
    class clslogin
    {
        private string cadena = "Data Source=Roberto;Initial Catalog=joyeria;Integrated Security=True";
        public string Nombre;
        public string Contra;
        public string TIPO;
        public string id;
        public string puesto;
        public SqlDataReader reader;

        public void datos(string user,string pass, string hora)
        {
                string sql = "select * from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto where Nombreempl = '" + user+ "' and Contrasenaemple = '" + Clsencry.Encriptar(pass) +"'";
                SqlConnection cnn = new SqlConnection(cadena);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader["IDempleado"].ToString();
                    Nombre = reader["Nombreempl"].ToString();
                    Contra = Clsencry.DesEncriptar(reader["Contrasenaemple"].ToString());
                    TIPO = reader["Tipoemple"].ToString();
                string newsql = "Insert into registrologins (idempleadoregistro, fechahora) values ('" + id + "', '" + hora + "')";
                clssutil clase = new clssutil();
                clase.consultadata(newsql);
                puesto = reader["Nombrepuesto"].ToString();
                }
            cnn.Close();

        }
    }
}


