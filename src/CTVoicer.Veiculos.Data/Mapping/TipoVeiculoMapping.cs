using CTVoicer.Veiculos.Bussiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CTVoicer.Veiculos.Data.Mapping
{
    public class TipoVeiculoMapping : IEntityTypeConfiguration<TipoVeiculo>
    {
        public void Configure(EntityTypeBuilder<TipoVeiculo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(255)");

            builder.Property(x => x.QuantidadePassageiros)
               .IsRequired();
        }
    }
}
