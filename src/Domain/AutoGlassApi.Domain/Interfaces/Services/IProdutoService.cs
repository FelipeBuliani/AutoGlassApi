using AutoGlassApi.Domain.Dtos;
using AutoGlassApi.Domain.Parameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoGlassApi.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Task AddAsync(ProdutoDtoCreate produto);
        Task<ProdutoDto> GetByIdAsync(int id);
        Task<IEnumerable<ProdutoDto>> GetAllAsync(ProdutoParameters parameters, int skip, int take);
        Task UpdateAsync(ProdutoDtoUpdate produto);
        Task RemoveAsync(int id);
        Task<bool> ExistAsync(int id);
    }
}
