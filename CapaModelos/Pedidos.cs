using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.model
{
    public enum Estados
    {
        INICIO, COLA, PROCESANDO, ENTREGADO
    }
    public class Pedidos
    {
        public int PedidosId { get; set; }
        public DateTime? FechaPedido { get; set; }
        public Estados? Estados { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
