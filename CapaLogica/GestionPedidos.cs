using CapaDatos;
using CapaDatos.manager;
using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaLogica
{
    public class GestionPedidos
    {
        private ManagerPlatos managerPlatos;
        private ManagerPedidos managerPedidos;
        private ManagerClient managerClient;

        public GestionPedidos()
        {
            managerPlatos = new ManagerPlatos();
            managerClient = new ManagerClient();
            managerPedidos = new ManagerPedidos();
        }

        public List<Platos> MostrarPlatos()
        {
            return managerPlatos.FindAll();
        }

        public void SeleccionarPlato(Platos platos)
        {
            managerPlatos.addPlatos(platos);
        }

        public List<Pedidos> getPedidos()
        {
            return managerPedidos.FindAll();
        }

        public void crearPedido(Pedidos pedidos)
        {
           // managerClient.Create(pedidos.cliente);
            managerPedidos.Create(pedidos);
        }

        public Platos BuscarPlato(string content)
        {
            return managerPlatos.findByName(content);
        }

        public ICollection<DetallePedido> getPlatosSeleccionado()
        {
            List<DetallePedido> details = new List<DetallePedido>();

            foreach (Platos platos in managerPlatos.getPlatosSeleccionado())
            {
                DetallePedido detail = new DetallePedido();
                detail.Cantidad = 1;
                detail.Platos = platos;
                details.Add(detail);
            }
            return details;
        }
    }
}
