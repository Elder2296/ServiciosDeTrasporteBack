using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class Mi_camioncitoContext : DbContext
    {
        public Mi_camioncitoContext()
        {
        }

        public Mi_camioncitoContext(DbContextOptions<Mi_camioncitoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Departament> Departaments { get; set; }
        public virtual DbSet<Muni> Munis { get; set; }
        public virtual DbSet<TipoCarga> TipoCargas { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Mi_camioncito;User=sa;Password=brC123abc");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dpi)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("DPI");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoDomiciliar)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoPersonal)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departament>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Departament");

                entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Muni>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio);

                entity.ToTable("Muni");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Munis)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Muni_Departament");
            });

            modelBuilder.Entity<TipoCarga>(entity =>
            {
                entity.HasKey(e => e.IdCarga);

                entity.ToTable("TipoCarga");

                entity.Property(e => e.IdCarga).HasColumnName("idCarga");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.ToTable("Ubicacion");

                entity.Property(e => e.IdUbicacion).HasColumnName("idUbicacion");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Ubicacions)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ubicacion_Departament");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo);

                entity.ToTable("Vehiculo");

                entity.Property(e => e.IdVehiculo).HasColumnName("idVehiculo");

                entity.Property(e => e.Capacidad)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("capacidad");

                entity.Property(e => e.ConsumoKm)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("consumo/km");

                entity.Property(e => e.IdUltimaUbicacion).HasColumnName("idUltimaUbicacion");

                entity.Property(e => e.TipoCarga).HasColumnName("tipoCarga");

                entity.HasOne(d => d.IdUltimaUbicacionNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdUltimaUbicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehiculo_Ubicacion");

                entity.HasOne(d => d.TipoCargaNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.TipoCarga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehiculo_TipoCarga");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
