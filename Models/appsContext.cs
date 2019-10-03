using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tareabd.Models
{
    public partial class appsContext : DbContext
    {
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
optionsBuilder.UseMySql("server=localhost;database=apps;user=root;pwd=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Userid)
                    .HasName("userid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(30);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30);
            });
        }
    }
}
