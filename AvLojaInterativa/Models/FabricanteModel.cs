using System.ComponentModel.DataAnnotations.Schema;

namespace AvLojaInterativa.Models
{
    [Table("Fabricante")]
    public class FabricanteModel
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Categoria_1 { set; get; }
        public string? Categoria_2 { set; get; }
        public string? Categoria_3 { set; get; }

        public ICollection<ProdutoModel> Produtos { get; set; }
    }
}
