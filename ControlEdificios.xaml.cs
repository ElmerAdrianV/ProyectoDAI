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
using System.Windows.Shapes;


namespace ProyectoDAI
{
    /// <summary>
    /// Interaction logic for ControlEdificios.xaml
    /// </summary>
    public partial class ControlEdificios : Window
    {
        public string RFCarrendador;
        public ControlEdificios()
        {
            InitializeComponent();
        }
        public ControlEdificios(string RFCarrendador)
        {
            InitializeComponent();
            this.RFCarrendador = RFCarrendador;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Edificio.LlenarComboEdificio(cbEdificios, RFCarrendador);
            Arrendador a = new Arrendador();
            lbBienvenido.Content = "Bienvenido," + a.obtenerNombre(RFCarrendador);
        }
        private void cerrarSesion(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Hide();
            w.Show();
        }

        private void seleccionarEdificio(object sender, RoutedEventArgs e)
        {
            ControlDepartamento w = new ControlDepartamento(cbEdificios.SelectedItem.ToString(), RFCarrendador);
            this.Hide();
            w.Show();
        }

        

        private void registrarEdificio(object sender, RoutedEventArgs e)
        {
            RegistrarEdificio w = new RegistrarEdificio(RFCarrendador);
            this.Hide();
            w.Show();
        }

        
    }
}
