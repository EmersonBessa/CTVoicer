using CTVoicer.Veiculos.Bussiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CTVoicer.Veiculos.Data.Mapping
{
    public class CorMapping : IEntityTypeConfiguration<Cor>
    {
        public void Configure(EntityTypeBuilder<Cor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(255)");

        }
    }
}
