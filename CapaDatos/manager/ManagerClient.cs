using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.manager
{
    public class ManagerClient : ManagerDb<Cliente>
    {
        private WalliContext WalliContext;
        public ManagerClient()
        {
            WalliContext = new WalliContext();
        }

        public void Create(Cliente obj)
        {
            WalliContext.Clientes.Add(obj);
            WalliContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> FindAll()
        {
            throw new NotImplementedException();
        }

        public void FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
