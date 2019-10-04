using CapaDatos.manager;
using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerRol ctx = new ManagerRol();
            ManagerClient client = new ManagerClient();
            ManagerUsuario user = new ManagerUsuario();
            ManagerPedidos pedidosM = new ManagerPedidos();
            ManagerPlatos managerPlatos = new ManagerPlatos();


            var rol = new Roles() { NombreRol = "Cajero" };
                ctx.Create(rol);
            
            var usuario = new Usuario() { Nombre = "gumu", Password = "gumu123", Roles = rol };
            user.Create(usuario);
            var clientes = new Cliente() { Nit = 1233, Nombre = "pepe" };
            client.Create(clientes);
            var platos = new Platos() { Nombre = "tranca", Precio = 10 };
            managerPlatos.Create(platos);
            var pedidos = new Pedidos()
            {
                Usuario = usuario,
                cliente = clientes,
                Estados = Estados.INICIO,
                FechaPedido = DateTime.Now
            };
            pedidosM.Create(pedidos);


        }
    }
}
