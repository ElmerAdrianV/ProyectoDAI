using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoDAI
{
    class Conexion
    {
        public static SqlConnection AgregarConexion()
        {
            SqlConnection cnn;
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=bdRommies;Persist Security Info=True;User ID=sa;Password=sqladmin");
                cnn.Open();
            }
            catch (Exception e)
            {
                cnn = null;
            }
            return cnn;
        }
        
    }
}
