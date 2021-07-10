using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CTVoicer.Veiculos.Bussiness.Models;
using Microsoft.EntityFrameworkCore;

namespace CTVoicer.Veiculos.Data.Context
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<TipoVeiculo> TipoVeiculo { get; set; }
        public DbSet<Cor> Cor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VeiculoContext).Assembly);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    entry.Property("DataCriacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                    entry.Property("DataCriacao").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
