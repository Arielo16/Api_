namespace APICrud.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Propiedad de navegación para la relación muchos a muchos con Pedido
        public ICollection<PedidoProducto> PedidoProductos { get; set; }
    }
}
