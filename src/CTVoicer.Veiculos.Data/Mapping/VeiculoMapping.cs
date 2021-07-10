using CTVoicer.Veiculos.Bussiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CTVoicer.Veiculos.Data.Mapping
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Chassi)
                   .IsRequired()
                   .HasColumnType("varchar(255)");
        }
    }
}
