using Microsoft.EntityFrameworkCore;
using Tienda_online.API.Models;

namespace Tienda_online.API.Data
{
    public class TiendaOnlineDbContext : DbContext
    {
        public TiendaOnlineDbContext(DbContextOptions<TiendaOnlineDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
