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
                cnn = new SqlConnection("Data Source=.;Initial Catalog=bdRoomies; User ID=sa;Password=sqladmin");
                cnn.Open();
            }
            catch (Exception ex)
            {
                cnn = null;
            }
            return cnn;
        }
        public static int Verificacion(String idUsuario, String contra)
        {
            int res = 0;
            SqlDataReader dr;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                con = Conexion.AgregarConexion();
                cmd = new SqlCommand(string.Format("SELECT contrasena FROM UsuarioArrendatario WHERE idArrendatario='{0}'", idUsuario), con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetString(0).Equals(contra))
                        res = 1;
                    else//contrasena desigual
                        res = 2;
                }
                else//usuario no encontrado
                {
                    res = 3;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("error: " + ex);
            }
            return res;
        }
    }
}
