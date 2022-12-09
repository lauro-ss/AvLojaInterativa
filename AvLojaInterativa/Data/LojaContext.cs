using AvLojaInterativa.Data.Map;
using AvLojaInterativa.Models;
using Microsoft.EntityFrameworkCore;

namespace AvLojaInterativa.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {

        }

        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<FabricanteModel> Fabricante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new FabricanteMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
