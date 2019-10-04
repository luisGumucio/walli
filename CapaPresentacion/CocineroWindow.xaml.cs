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
    /// Lógica de interacción para CocineroWindow.xaml
    /// </summary>
    public partial class CocineroWindow : Window
    {
        private GestionPedidos pedidos;

        public CocineroWindow()
        {
            InitializeComponent();
            pedidos = new GestionPedidos();
            foreach(Pedidos p in pedidos.getPedidos())
            {
                dataGridPlatos.Items.Add(p);
            }
        }
    }
}
