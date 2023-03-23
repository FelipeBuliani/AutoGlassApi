using AutoGlassApi.Domain.Dtos;
using AutoGlassApi.Domain.Entities;
using AutoGlassApi.Domain.Interfaces;
using AutoGlassApi.Domain.Interfaces.Services;
using AutoGlassApi.Domain.Parameters;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassApi.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDto>> GetAllAsync(
            ProdutoParameters parameters,int skip, int take)
        {
            var entities = await _produtoRepository.GetAllAsync(parameters, skip, take);
            return _mapper.Map<IEnumerable<ProdutoDto>>(entities.ToList());
        }

        public async Task<ProdutoDto> GetByIdAsync(int id)
        {
            return _mapper.Map<ProdutoDto>(await _produtoRepository.GetByIdAsync(id));
        }

        public async Task AddAsync(ProdutoDtoCreate produto)
        {
            await _produtoRepository.AddAsync(_mapper.Map<Produto>(produto));
        }

        public async Task UpdateAsync(ProdutoDtoUpdate produto)
        {
            await _produtoRepository.UpdateAsync(_mapper.Map<Produto>(produto));
        }

        public async Task RemoveAsync(int id)
        {
            await _produtoRepository.RemoveAsync(id);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _produtoRepository.ExistAsync(id);
        }
    }
}
