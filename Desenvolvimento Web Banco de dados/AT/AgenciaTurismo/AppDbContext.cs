using AgenciaTurismo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<PacoteTuristico> Pacotes { get; set; } = null!;
    public DbSet<Reserva> Reservas { get; set; } = null!;
    public DbSet<CidadeDestino> Cidades { get; set; } = null!;
    public DbSet<PaisDestino> Paises { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PacoteTuristico>()
            .HasMany(p => p.Destinos)
            .WithMany(c => c.Pacotes);

      
        modelBuilder.Entity<Reserva>()
            .HasIndex(r => new { r.ClienteId, r.PacoteTuristicoId, r.DataReserva })
            .IsUnique();

        modelBuilder.Entity<PacoteTuristico>().HasQueryFilter(p => !p.IsDeleted);
    }
}
