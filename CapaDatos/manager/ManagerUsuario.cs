using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.manager
{
    public class ManagerUsuario : ManagerDb<Usuario>
    {
        private WalliContext WalliContext;

        public ManagerUsuario()
        {
            WalliContext = new WalliContext();
        }
        public void Create(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public void FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario findByName(string nombre)
        {
            return WalliContext.Usuarios.Where(b => b.Nombre.Equals(nombre)).FirstOrDefault();
        }

        public Boolean Login(Usuario user)
        {
            return WalliContext.Usuarios.Where(b => b.Nombre.Equals(user.Nombre) && b.Password.Equals(user.Password)).Count() > 0;
        }
    }
}
