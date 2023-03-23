using AutoGlassApi.Domain.Entities;
using AutoGlassApi.Domain.Entities.Enums;
using AutoGlassApi.Domain.Interfaces;
using AutoGlassApi.Domain.Parameters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassApi.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AutoGlassApiDbContext context) : base(context)
        {

        }

        public override async Task UpdateAsync(Produto produtoAlterado)
        {
            var produto = await GetByIdAsync(produtoAlterado.Codigo);
            produtoAlterado.Situacao = produto.Situacao;
            context.Entry(produto).CurrentValues.SetValues(produtoAlterado);
            await SaveChangesAsync();
        }

        public override async Task RemoveAsync(int id)
        {
            var produto = await GetByIdAsync(id);

            if (produto.Situacao == SituacaoProduto.Ativo)
            {
                produto.Situacao = SituacaoProduto.Inativo;

                context.Update(produto);
                await SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Produto>> GetAllAsync(
            ProdutoParameters parameters, int skip, int take)
        {
            var result = context.Produto.Where(p => 
                p.DataFabricacao >= parameters.DataFabricacaoMin &&
                p.DataFabricacao <= parameters.DataFabricacaoMax &&
                p.DataValidade >= parameters.DataValidadeMin &&
                p.DataValidade <= parameters.DataValidadeMax);

            if (parameters.Situacao != null)
                result = result.Where(p => p.Situacao == parameters.Situacao);

            return (await result.ToListAsync())
                .OrderBy(p => p.Codigo)
                .Skip(skip)
                .Take(take);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await context.Produto.AnyAsync(x => x.Codigo.Equals(id));
        }
    }
}
