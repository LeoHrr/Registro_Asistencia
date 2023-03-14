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
    /// Lógica de interacción para AgregarAdmin.xaml
    /// </summary>
    public partial class AgregarAdmin : Window
    {
        Clase_admin admin = new Clase_admin();

        public AgregarAdmin()
        {
            InitializeComponent();
            
        }

        private void Usuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Contrasenia_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Confirmar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged3(object sender, TextChangedEventArgs e)
        {

        }

        private void confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (Usuario.Text == "" || Contraseña.Text == "" || email.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }else if(Contraseña.Text != Confim_contr.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir");
            }
            else
            {
                Clase_admin admin = new Clase_admin(Usuario.Text, Contraseña.Text, email.Text);
                MessageBox.Show("Nuevo administrador añadido");
                Usuario.Text = "";
                Contraseña.Text = "";
                Confim_contr.Text = "";
                email.Text = "";
            }
            
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
