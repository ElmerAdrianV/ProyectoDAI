using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace ProyectoDAI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Iniciar_Sesion(object sender, RoutedEventArgs e)
        {
            SqlConnection cnn = Conexion.AgregarConexion();
            int inicioSesion = Conexion.Verificacion(txIDUsuario.Text, txContrasena.Text);
            switch (inicioSesion)
            {
                case 1:
                    this.Hide();
                    break;
                case 2:
                    MessageBox.Show("Contraseña incorrecta");
                    break;
                case 3:
                    MessageBox.Show("Usuario no encontrado");
                    break;
            }
            
        }

        private void Button_Registrar(object sender, RoutedEventArgs e)
        {
            Window registrar = new Registrar();
            this.Hide();
            registrar.Show();
        }
    }
}
