using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){
        }
        public DbSet<Inventario.Models.Producto> Producto { get; set; } = default!;
        public DbSet<Inventario.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Inventario.Models.Pedido> Pedido { get; set; } = default!;
    }
}
