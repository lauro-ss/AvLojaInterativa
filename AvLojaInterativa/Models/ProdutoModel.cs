using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvLojaInterativa.Models
{
    [Table("Produto")]
    public class ProdutoModel
    {
        public int Id { set; get; }

        public string Nome { get; set; }

        public int IdFabricante { get; set; }

        public string Categoria { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public FabricanteModel? IdFabricanteNavigation { get; set; }
    }
}
