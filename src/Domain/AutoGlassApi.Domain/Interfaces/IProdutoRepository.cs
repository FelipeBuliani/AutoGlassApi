using AutoGlassApi.Domain.Dtos;
using AutoGlassApi.Domain.Entities;
using AutoGlassApi.Domain.Parameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoGlassApi.Domain.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> GetAllAsync(ProdutoParameters parameters, int skip, int take);
        Task RemoveAsync(int id);
        Task<bool> ExistAsync(int id);
    }
}
