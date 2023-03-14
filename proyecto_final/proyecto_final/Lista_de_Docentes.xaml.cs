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

namespace proyecto_final
{
    /// <summary>
    /// Lógica de interacción para Lista_de_Docentes.xaml
    /// </summary>
    public partial class Lista_de_Docentes : Window
    {
        public Lista_de_Docentes()
        {
            InitializeComponent();
            string datos = "DataSource = 127.0.0.1;Port = 3306 ; username = root; Password = ;DataBase=docentes ";
            MySqlConnection conectar = new MySqlConnection(datos);
            try
            {
                conectar.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos");
            }

            string consulta = "Select * From personas";
            MySqlCommand Leer = new MySqlCommand(consulta, conectar);
            MySqlDataReader lectura = Leer.ExecuteReader();

            List.Text = "ID\tNombre\tApellido\t   DNI\t  Materia\n";
            while (lectura.Read())
            {
                
                List.Text += lectura.GetInt32(0) +"\t"+ lectura.GetString(1) +"\t"+ lectura.GetString(2) +"\t "+ lectura.GetString(3) +" "+ lectura.GetString(4) + "\n";

            }
            lectura.Close();
            conectar.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
