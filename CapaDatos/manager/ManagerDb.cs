using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.manager
{
    public interface ManagerDb<T>
    {
        void Create(T obj);
        void Edit(int id);
        void Delete(int id);
        void FindById(int id);
        List<T> FindAll();

    }
}
