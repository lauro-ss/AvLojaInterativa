using AvLojaInterativa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvLojaInterativa.Data.Map
{
    public class FabricanteMap : IEntityTypeConfiguration<FabricanteModel>
    {
        public void Configure(EntityTypeBuilder<FabricanteModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Categoria_1).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Categoria_2).HasMaxLength(150);

            builder.Property(x => x.Categoria_3).HasMaxLength(150);
        }
    }
}
