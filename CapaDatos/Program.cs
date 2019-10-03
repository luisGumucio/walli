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
                var rol = new Roles() { NombreRol = "Admin123" };
                ctx.Create(rol);
                foreach(Roles roles in ctx.FindAll())
                {
                    Console.WriteLine(roles.NombreRol);
                }
        }
    }
}
