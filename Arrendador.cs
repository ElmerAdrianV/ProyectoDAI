using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace ProyectoDAI
{
    class Arrendador
    {
        public String RFC { get; set; }
        public String nombre { get; set; }
        public Int32 telefono { get; set; }
        public String correo { get; set; }
        public String contrasena;
        public Arrendador(){
        }
        public Arrendador(String RFC)
        {
            this.RFC = RFC;
        }
        public Arrendador(String RFC, String nombre, Int32 telefono, String correo, String contrasena)
        {
            this.RFC=RFC;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.contrasena = contrasena;
        }
        public static int VerificacionArrendador(String idUsuario, String contra)
        {
            int res = 0;
            SqlDataReader dr;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                con = Conexion.AgregarConexion();
                cmd = new SqlCommand(string.Format("SELECT contrasena FROM UsuarioArrendador WHERE RFCarrendador='{0}'", idUsuario), con);
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
        public int registraArrendador(String RFC, String nombre, Int64 telefono, String correo, String contrasena)
        {
            int res = -1;
            SqlConnection con;
            SqlCommand cmdA, cmdUA;
            
                con = Conexion.AgregarConexion();
                cmdA = new SqlCommand(string.Format("INSERT INTO Arrendador(RFCarrendador, nombre, telefono, correo) values ('{0}','{1}',{2},'{3}') ", RFC, nombre, telefono, correo), con);
                cmdUA = new SqlCommand(string.Format("INSERT INTO UsuarioArrendador(RFCarrendador, contrasena) values ('{0}','{1}') ", RFC, contrasena), con);
                res = cmdA.ExecuteNonQuery(); // no es consulta, no regresa datos
                res = cmdUA.ExecuteNonQuery(); // no es consulta, no regresa datos
                con.Close();
            
            
            return res;
        }
        public String obtenerNombre(String RFCarrendador)
        {
            SqlDataReader dr;
            SqlConnection con;
            SqlCommand cmd;
            String nombreA="";
            try
            {
                con = Conexion.AgregarConexion();
                cmd = new SqlCommand(String.Format("SELECT nombre FROM Arrendador WHERE RFCArrendador='{0}'", RFCarrendador), con);
                dr = cmd.ExecuteReader();
                dr.Read();
                nombreA=dr.GetString(0);    
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("error: " + ex);
            }
            return nombreA;
        }
    }
}
