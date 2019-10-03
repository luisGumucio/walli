namespace CapaDatos.model
{
    public class DetallePedido
    {
        public int DetallePedidoId { get; set; }
        public Platos Platos { get; set; }
        public Pedidos Pedidos { get; set; }
        public int Cantidad { get; set; }
    }
}