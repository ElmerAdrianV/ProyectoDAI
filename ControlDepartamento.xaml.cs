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
    /// Interaction logic for ControlDepartamento.xaml
    /// </summary>
    public partial class ControlDepartamento : Window
    {
        public string nombreEdificio;
        public string RFCarrendador;
        public ControlDepartamento()
        {
            InitializeComponent();
        }
        public ControlDepartamento(string nombreEdificio, string RFCarrendador)
        {
            InitializeComponent();
            this.nombreEdificio = nombreEdificio;
            this.RFCarrendador = RFCarrendador;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Departamento.LlenarComboDepartamento(cbDepartamentos,nombreEdificio);
            Arrendador a = new Arrendador();
            lbBienvenido.Content = "Bienvenido," + a.obtenerNombre(RFCarrendador);
        }
        private void cerrarSesion(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Hide();
            w.Show();
        }

        private void seleccionarDepa(object sender, RoutedEventArgs e)
        {

        }
    }
}
