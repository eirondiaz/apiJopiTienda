using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiJopiTienda.Models;

namespace apiJopiTienda.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartHist> CartHist { get; set; }
    }
}
