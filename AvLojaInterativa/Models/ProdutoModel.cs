using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvLojaInterativa.Models
{
    [Table("Produto")]
    public class ProdutoModel
    {
        public int Id { set; get; }
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        [Display(Name = "Fabricante")]
        public int IdFabricante { get; set; }
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public FabricanteModel? IdFabricanteNavigation { get; set; }
    }
}
