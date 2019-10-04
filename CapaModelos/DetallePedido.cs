namespace CapaDatos.model
{
    public class DetallePedido
    {
        public int DetallePedidoId { get; set; }
        public virtual Platos Platos { get; set; }
        public virtual Pedidos Pedidos { get; set; }
        public int Cantidad { get; set; }
    }
}