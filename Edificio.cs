using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace ProyectoDAI
{
    class Edificio
    {
        public Arrendador duenio { get; set; }
        public int idEdificio { get; }
        public String nombreEdificio { get; set; }
        public String calle { get; set; }
        public int numero { get; }
        public int CP { get; }
        public String RFCarrendador { get; }
        

        public static void LlenarComboEdificio(ComboBox cb, String RFCarrendador)
        {
            SqlDataReader dr;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                con = Conexion.AgregarConexion();
                cmd = new SqlCommand(String.Format("SELECT nombreEdificio FROM Edificio WHERE RFCArrendador='{0}'",RFCarrendador), con);
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
