using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Sistema_libreria.Models;

public partial class LibreriaContext : DbContext
{
    public LibreriaContext()
    {
    }

    public LibreriaContext(DbContextOptions<LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseMySql("server=localhost;database=LibreriaDB;user=root;password=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.7.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("PRIMARY");

            entity.ToTable("libros");

            entity.HasIndex(e => e.IdProveedor, "IdProveedor");

            entity.Property(e => e.Autor).HasMaxLength(100);
            entity.Property(e => e.Precio).HasPrecision(10, 2);
            entity.Property(e => e.Titulo).HasMaxLength(150);

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("libros_ibfk_1");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PRIMARY");

            entity.ToTable("proveedores");

            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PRIMARY");

            entity.ToTable("ventas");

            entity.HasIndex(e => e.IdLibro, "IdLibro");

            entity.Property(e => e.Total).HasPrecision(10, 2);

            entity.HasOne(d => d.IdLibroNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdLibro)
                .HasConstraintName("ventas_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
