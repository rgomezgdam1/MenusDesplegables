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

namespace MenusDesplegables
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void M_Nuevo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaVentana = new MainWindow();
            nuevaVentana.Show();
        }

        private void M_Abrir_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog abrirFichero = new Microsoft.Win32.OpenFileDialog();
            abrirFichero.ShowDialog();
        }

        private void M_Guardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guardado");
        }

        private void M_Guardar_como_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog guardarFichero = new Microsoft.Win32.SaveFileDialog();
            guardarFichero.ShowDialog();
        }

        private void M_Imprimir_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog imprimir = new System.Windows.Controls.PrintDialog();
            imprimir.ShowDialog();
        }

        private void M_Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void M_Usuarios_Click(object sender, RoutedEventArgs e)
        {
            Usuarios abrirUsuarios = new Usuarios();
            abrirUsuarios.Show();
        }

        private void M_Cortar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Copiado ");
        }

        private void M_Copiar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Cortado ");
        }

        private void M_Pegar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Pegado ");
        }

        private void M_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Eliminado ");
        }
    }
}
