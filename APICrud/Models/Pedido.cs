namespace APICrud.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Relación muchos a muchos con Producto a través de PedidoProducto
        public ICollection<PedidoProducto> PedidoProductos { get; set; }
    }
}
