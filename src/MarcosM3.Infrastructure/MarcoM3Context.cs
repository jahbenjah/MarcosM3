using System;
using System.Collections.Generic;
using System.Text;
using MarcosM3.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MarcosM3.Infrastructure
{
    public partial class MarcosM3DbContext : IdentityDbContext
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

        }
    }
}
