using CapaDatos;
using CapaDatos.model;
using CapaLogica;
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

namespace CapaPresentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ManagerCuentas managerCuenta;
        public MainWindow()
        {
            InitializeComponent();
            managerCuenta = new ManagerCuentas();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var rol = new Roles();
            //rol.NombreRol = txtRol.Text;
            //managerCuenta.CrearRoles(rol);
            //MessageBox.Show("Creado exitosamente");
            //foreach (Roles roles in managerCuenta.getAllRoles())
            //{
            //    MessageBox.Show(roles.NombreRol);
            //}
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nombre = txtLoginUser.Text,
                Password = txtPasswordLogin.Password
            };

            if (managerCuenta.Login(usuario))
            {
                Usuario user = managerCuenta.FindUser(usuario.Nombre);
                if(user.Roles.NombreRol.Equals("Cajero"))
                {
                    CajeroWindow cajero = new CajeroWindow();
                    this.Close();
                    cajero.ShowDialog();
                }
            } else
            {
                MessageBox.Show("Fallo al ingresar");
            }
        }
    }
}