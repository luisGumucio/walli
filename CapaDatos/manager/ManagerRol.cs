using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.manager
{
    public class ManagerRol: ManagerDb<Roles>
    {
        private WalliContext WalliContext;
        public ManagerRol()
        {
            WalliContext = new WalliContext();
        }

        public void Create(Roles obj)
        {
            WalliContext.Roles.Add(obj);
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

        public List<Roles> FindAll()
        {
            return WalliContext.Roles.ToList();
        }

        public void FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
