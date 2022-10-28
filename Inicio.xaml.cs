using barquitos.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace barquitos
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        private Sala sala = new Sala();

        public Inicio()
        {
            InitializeComponent();
        }

        private void CrearSala(object sender, RoutedEventArgs e)
        {
            
            if (tbx_userName.Text != "")
                sala.HostName = tbx_userName.Text;

            CrearSala crearSala = new CrearSala(sala);
            crearSala.ShowDialog();
        }

        private void UnirseSala(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
