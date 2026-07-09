using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Sistema_Eventos.Models;

public partial class SistemaEventosContext : DbContext
{
    public SistemaEventosContext()
    {
    }

    public SistemaEventosContext(DbContextOptions<SistemaEventosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Participante> Participantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseMySql("server=localhost;port=3306;database=sistema_eventos;user=root;password=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.7.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntrada).HasName("PRIMARY");

            entity.ToTable("entradas");

            entity.HasIndex(e => e.IdEventos, "IdEventos");

            entity.HasIndex(e => e.IdParticipante, "IdParticipante");

            entity.Property(e => e.FechaCompra).HasColumnType("datetime");
            entity.Property(e => e.Precio).HasPrecision(10, 2);
            entity.Property(e => e.TipoEntrada).HasMaxLength(50);

            entity.HasOne(d => d.IdEventosNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.IdEventos)
                .HasConstraintName("entradas_ibfk_1");

            entity.HasOne(d => d.IdParticipanteNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.IdParticipante)
                .HasConstraintName("entradas_ibfk_2");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEventos).HasName("PRIMARY");

            entity.ToTable("eventos");

            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.Lugar).HasMaxLength(100);
            entity.Property(e => e.NombreEvento).HasMaxLength(100);
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PRIMARY");

            entity.ToTable("pagos");

            entity.HasIndex(e => e.IdEntrada, "IdEntrada");

            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.MetodoPago).HasMaxLength(50);
            entity.Property(e => e.Monto).HasPrecision(10, 2);

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdEntrada)
                .HasConstraintName("pagos_ibfk_1");
        });

        modelBuilder.Entity<Participante>(entity =>
        {
            entity.HasKey(e => e.IdParticipante).HasName("PRIMARY");

            entity.ToTable("participantes");

            entity.Property(e => e.Cedula).HasMaxLength(10);
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
