using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tareabd.ModelsSQL
{
    public partial class appsContext : DbContext
    {
        public appsContext()
        {
        }

        public appsContext(DbContextOptions<appsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=apps;Username=postgres;Password=debg20091996");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.HasIndex(e => e.Userid)
                    .HasName("usuario_userid_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);

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
