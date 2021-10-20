using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace ProyectoDAI
{
    class Departamento
    {
        public int idDepartament { get; }
        public int idEdificio { get; }
        public double precioRenta { get; set; }
        public double tamanio { get; set; }
        public int calificacion { get; set; }
        public static void LlenarComboDepartamento(ComboBox cb, string nombreEdificio)
        {
            SqlDataReader dr;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                con = Conexion.AgregarConexion();
                cmd = new SqlCommand(String.Format("SELECT idDepartamento FROM Departamento INNERJOIN Edificio ON Departamento.idEdificio=Edificio.idEdificio WHERE nombreEdificio='{0}'", nombreEdificio), con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr.GetString(0));
                }
                cb.SelectedIndex = 0;
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("error: " + ex);
            }
        }
    }
}
