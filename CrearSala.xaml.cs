using barquitos.Clases;
using MySql.Data.MySqlClient;
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

namespace barquitos
{
    /// <summary>
    /// Lógica de interacción para CrearSala.xaml
    /// </summary>
    public partial class CrearSala : Window
    {
        private Sala sala;
        
        public CrearSala(Sala sala)
        {
            this.sala = sala;
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            InsertarSala(sala.HostName, sala.Player2, tbx_contrasenya.Text.ToString());
        }

        private void InsertarSala(string nombreHost, string player2, string pass)
        {
            string servidor = "eu-west.connect.psdb.cloud"; //Nombre o ip del servidor de MySQL
            string bd = "battleship"; //Nombre de la base de datos
            string usuario = "3yrwocc3dq1cdh4mgsd5"; //Usuario de acceso a MySQL
            string password = "pscale_pw_uoUzJefCSQUqk7QlMUM0cxpUqAU2UFmIdp9kJPXsbzq"; //Contraseña de usuario de acceso a 

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                string consulta = "insert into salas(nombreHost,nombreJugador2,contrasenya) values ('"+ nombreHost + "','" +player2 + "','" + pass +"');"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                MessageBox.Show("Sala Creada", "Event", MessageBoxButton.OK, MessageBoxImage.Information); //Imprime en cuadro de dialogo el resultado
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }
    }
}
