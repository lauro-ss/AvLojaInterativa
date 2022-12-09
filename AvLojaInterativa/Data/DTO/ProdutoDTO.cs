using System.ComponentModel.DataAnnotations;

namespace AvLojaInterativa.Data.DTO
{
    public class ProdutoDTO
    {
        public int Id { set; get; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public string NomeFabricante { get; set; }
    }
}
