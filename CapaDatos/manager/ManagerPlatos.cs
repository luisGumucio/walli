using CapaDatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.manager
{
    public class ManagerPlatos : ManagerDb<Platos>
    {
        private WalliContext WalliContext;
        private List<Platos> Platoslist;

        public ManagerPlatos()
        {
            WalliContext = new WalliContext();
            Platoslist = new List<Platos>();
        }

        public void Create(Platos obj)
        {
            WalliContext.Platos.Add(obj);
            WalliContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void addPlatos(Platos platos)
        {
            Platoslist.Add(platos);
        }
        public List<Platos> getPlatosSeleccionado()
        {
            return Platoslist;
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public Platos findByName(string content)
        {
            return WalliContext.Platos.Where(b => b.Nombre.Equals(content)).FirstOrDefault();
        }

        public List<Platos> FindAll()
        {
            return WalliContext.Platos.ToList();
        }

        public void FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
