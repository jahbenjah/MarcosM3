using Marcos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marcos.Data
{
    public class MarcosDbContext : IdentityDbContext
    {
        public MarcosDbContext()
        {
        }

        public MarcosDbContext(DbContextOptions<MarcosDbContext> options) : base(options)
        {
        }
        public DbSet<Moldura> Molduras { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Moldura>(entity =>
            {
                entity.Property(e => e.Precio)
                .HasColumnType("decimal(20,2)");
            });


            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.ToTable("Usuario");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("UserioClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("UserTokens");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("Roles");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("UsuarioRoles");
            });

        }


    }

}
