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
    /// Interaction logic for RegistrarArrendador.xaml
    /// </summary>
    public partial class RegistrarArrendador : Window
    {
        public RegistrarArrendador()
        {
            InitializeComponent();
        }
        private void Button_RegistrarArrendador(object sender, RoutedEventArgs e)
        {
            Arrendador a = new Arrendador();
            MessageBox.Show(tbRFC.Text+ tbNombre.Text+ Int64.Parse(tbTelefono.Text)+ tbCorreo.Text+ tbContrasena.Text);
            try
            {
                a.registraArrendador(tbRFC.Text, tbNombre.Text, Int64.Parse(tbTelefono.Text), tbCorreo.Text, tbContrasena.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("error" +e);
            }
            this.Hide();
            RegistrarEdificio w = new RegistrarEdificio();
            w.Show();
        }
    }
}
