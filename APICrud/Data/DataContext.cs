using Microsoft.EntityFrameworkCore;
using APICrud.Models;

namespace APICrud.Data
{
    public class DataContext : DbContext
    {
        // Constructor que recibe las opciones de configuración
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Estas propiedades DbSet representan las tablas de la base de datos
        public DbSet<Usuario> Usuarios { get; set; }  // Tabla Usuario
        public DbSet<Producto> Productos { get; set; }  // Tabla Producto
        public DbSet<Pedido> Pedidos { get; set; }  // Tabla Pedido
    }
}
