using AvLojaInterativa.Models;

namespace AvLojaInterativa.Data.Interfaces
{
    public interface IProduto
    {
        Task<ProdutoModel> Get(int id);
        Task<IEnumerable<ProdutoModel>> GetAll();
        Task<ProdutoModel> Create(ProdutoModel produto);
        Task<ProdutoModel> Edit(ProdutoModel produto, int id);
        Task<bool> Delete(int id);
    }
}
