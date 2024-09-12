using Microsoft.EntityFrameworkCore;
using PruebaData.DataBase.Seeds;
using PruebaData.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaData.DataBase
{
    public class MiDbContext : DbContext
    {
        public MiDbContext (DbContextOptions opts): base(opts)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasMany<Pedido>()
                .WithOne()
                .HasForeignKey(p => p.id_Persona);

            modelBuilder.Seed();
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
