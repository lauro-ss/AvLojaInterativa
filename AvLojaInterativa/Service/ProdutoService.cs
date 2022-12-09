using AvLojaInterativa.Data;
using AvLojaInterativa.Data.Interfaces;
using AvLojaInterativa.Models;
using Microsoft.EntityFrameworkCore;

namespace AvLojaInterativa.Service
{
    public class ProdutoService : IProduto
    {
        private readonly LojaContext _dbContext;
        public ProdutoService(LojaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ProdutoModel> Create(ProdutoModel produto)
        {
            await _dbContext.Produto.AddAsync(produto);
            await _dbContext.SaveChangesAsync();
            return produto;
        }

        public async Task<bool> Delete(int id)
        {
            ProdutoModel produto = await Get(id);
            _dbContext.Produto.Remove(produto);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ProdutoModel> Edit(ProdutoModel produto, int id)
        {
            ProdutoModel getedProduto = await Get(id);
            getedProduto = produto;

            _dbContext.Produto.Update(getedProduto);
            await _dbContext.SaveChangesAsync();
            return getedProduto;
        }

        public async Task<ProdutoModel> Get(int id)
        {
            ProdutoModel? produto = await _dbContext.Produto.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (produto == null)
                throw new Exception($"Não existe produto correspondente ao ID: {id}");

            return produto;
        }

        public async Task<IEnumerable<ProdutoModel>> GetAll()
        {
            return await _dbContext.Produto.AsNoTracking().ToListAsync();
        }
    }
}
