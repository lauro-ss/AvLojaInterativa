using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvLojaInterativa.Models
{
    [Table("Fabricante")]
    public class FabricanteModel
    {
        public int Id { set; get; }
        [Display(Name = "Fabricante")]
        public string Nome { set; get; }
        [Display(Name = "Categoria")]
        public string Categoria_1 { set; get; }
        [Display(Name = "Categoria")]
        public string? Categoria_2 { set; get; }
        [Display(Name = "Categoria")]
        public string? Categoria_3 { set; get; }

        public ICollection<ProdutoModel> Produtos { get; set; }
    }
}
