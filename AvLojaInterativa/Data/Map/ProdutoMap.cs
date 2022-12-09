using AvLojaInterativa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvLojaInterativa.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(150);

            builder.HasIndex(x => x.IdFabricante, "fk_produto_fabricante_ind");

            builder.Property(x => x.Categoria).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Preco).IsRequired().HasColumnType("numeric(10,2)");

            builder.HasOne(x => x.IdFabricanteNavigation)
                .WithMany(p => p.Produtos)
                .HasForeignKey(x => x.IdFabricante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_produto_fabricante");
        }
    }
}
