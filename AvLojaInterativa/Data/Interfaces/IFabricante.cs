using AvLojaInterativa.Data.DTO;
using AvLojaInterativa.Models;

namespace AvLojaInterativa.Data.Interfaces
{
    public interface IFabricante
    {
        Task<FabricanteModel> Get(int id);
        Task<IEnumerable<FabricanteModel>> GetAll();
        Task<CategoriaDTO> GetCategoriasById(int id);
        Task<FabricanteModel> Create(FabricanteModel fabricante);
        Task<FabricanteModel> Edit(FabricanteModel fabricante, int id);
        Task<bool> Delete(int id);
    }
}
