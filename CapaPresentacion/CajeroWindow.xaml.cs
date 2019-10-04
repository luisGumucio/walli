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
using System.Windows.Shapes;

namespace CapaPresentacion
{
    /// <summary>
    /// Interaction logic for CajeroWindow.xaml
    /// </summary>
    public partial class CajeroWindow : Window
    {
        GestionPedidos Gestion;
        private Usuario user;
        public CajeroWindow(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            Gestion = new GestionPedidos();
            init();
        }

        private void init()
        {
            //========================Listar Categoria trago y Comida=================================
            int marginrighttp = -850;
            foreach (Platos p in Gestion.MostrarPlatos())
            {
                Button btn = new Button();
                btn.Name = p.Nombre;
                btn.Width = 190;
                btn.Height = 78;
                btn.Content = p.Nombre + " " + "precio " + p.Precio.ToString();
                btn.FontSize = 15;
                btn.Margin = new Thickness(marginrighttp, 0, 20, 0);
                marginrighttp += 190;
                btn.Click += botonClick;

                //this.GridPlatos.Children.Add(btn);
            }
        }

        private void botonClick(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Name.ToString();
            var platos = Gestion.BuscarPlato(content);
            Gestion.SeleccionarPlato(platos);
            //dataGridPlatos.Items.Add(platos);
        }

        private void btnGuardarPedido_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
