using AvLojaInterativa.Data;
using AvLojaInterativa.Data.DTO;
using AvLojaInterativa.Data.Interfaces;
using AvLojaInterativa.Models;
using Microsoft.EntityFrameworkCore;

namespace AvLojaInterativa.Service
{
    public class FabricanteService : IFabricante
    {
        private readonly LojaContext _dbContext;
        public FabricanteService(LojaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<FabricanteModel> Create(FabricanteModel fabricante)
        {
            await _dbContext.Fabricante.AddAsync(fabricante);
            await _dbContext.SaveChangesAsync();
            return fabricante;
        }

        public async Task<bool> Delete(int id)
        {
            FabricanteModel fabricante = await Get(id);
            _dbContext.Fabricante.Remove(fabricante);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<FabricanteModel> Edit(FabricanteModel fabricante, int id)
        {
            FabricanteModel getedFabricante = await Get(id);
            getedFabricante = fabricante;

            _dbContext.Fabricante.Update(getedFabricante);
            await _dbContext.SaveChangesAsync();
            return getedFabricante;
        }

        public async Task<FabricanteModel> Get(int id)
        {
            FabricanteModel? fabricante = await _dbContext.Fabricante.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (fabricante == null)
                throw new Exception($"Não existe fabricante correspondente ao ID: {id}");

            return fabricante;
        }

        public async Task<IEnumerable<FabricanteModel>> GetAll()
        {
            return await _dbContext.Fabricante.AsNoTracking().ToListAsync();
        }

        public async Task<CategoriaDTO> GetCategoriasById(int id)
        {
            var query = from fabricante in _dbContext.Fabricante
                        where fabricante.Id.Equals(id)
                        orderby fabricante.Nome
                        select new CategoriaDTO
                        {
                            Categoria_1 = fabricante.Categoria_1,
                            Categoria_2 = fabricante.Categoria_2,
                            Categoria_3 = fabricante.Categoria_3
                        };
            return query.AsNoTracking().First();
        }
    }
}
