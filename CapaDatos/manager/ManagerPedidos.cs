using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.manager
{
    public class ManagerPedidos : ManagerDb<Pedidos>
    {
        private WalliContext WalliContext;
        public ManagerPedidos()
        {
            WalliContext = new WalliContext();
        }

        public void Create(Pedidos obj)
        {
            WalliContext.Pedidos.Add(obj);
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

        public List<Pedidos> FindAll()
        {
            return WalliContext.Pedidos.ToList();
        }

        public void FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
