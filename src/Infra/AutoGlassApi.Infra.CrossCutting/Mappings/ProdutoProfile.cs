using AutoGlassApi.Domain.Dtos;
using AutoGlassApi.Domain.Entities;
using AutoGlassApi.Domain.Entities.Enums;
using AutoMapper;

namespace AutoGlassApi.Infra.CrossCutting.Mappings
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile() 
        {
            CreateMap<Produto, ProdutoDto>()
                .ForMember(p => p.CnpjFornecedor,
                    map => map.MapFrom(p => this.FormatarCnpjFornecedor(p.CnpjFornecedor)))
                .ForMember(p => p.Situacao,
                    map => map.MapFrom(p => p.Situacao.ToString()));

            CreateMap<ProdutoDtoCreate, Produto>();

            CreateMap<ProdutoDtoUpdate, Produto>();

        }

        private string FormatarCnpjFornecedor(string cnpj)
        {
            if (!string.IsNullOrEmpty(cnpj))
            {
                var encryptedCharacters = cnpj.Substring(2, 9);
                cnpj = cnpj.Replace(encryptedCharacters, ".XXX.XXX/");
            }

            return cnpj;
        }
    }
}
