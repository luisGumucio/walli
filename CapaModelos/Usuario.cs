using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public String Nombre { get; set; }
        public String Password { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
