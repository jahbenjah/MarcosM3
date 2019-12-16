using System;
using System.Collections.Generic;
using System.Text;
using MarcosM3.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MarcosM3.Infrastructure
{
    public class MarcosM3DbContext : IdentityDbContext
    {
        public MarcosM3DbContext()
        {
        }

        public MarcosM3DbContext(DbContextOptions<MarcosM3DbContext> options) : base(options)
        {
        }
        public DbSet<Moldura> Molduras { get; set; }

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
