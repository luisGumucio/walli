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
    public class ManagerCuentas
    {
        private ManagerRol managerRol;
        private ManagerUsuario managerUsuario;

        public ManagerCuentas()
        {
            managerRol = new ManagerRol();
            managerUsuario = new ManagerUsuario();
        }

        public void CrearRoles(Roles rol)
        {
            managerRol.Create(rol);
        }

        public List<Roles> getAllRoles()
        {
            return managerRol.FindAll();
        }

        public bool Login(Usuario user)
        {
            return managerUsuario.Login(user);
        }

        public Usuario FindUser(String nombre)
        {
            return managerUsuario.findByName(nombre);
        }
    }
}
