using AutoGlassApi.Domain.Entities.Enums;
using System;

namespace AutoGlassApi.Domain.Dtos
{
    public class ProdutoDto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Situacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public int? CodigoFornecedor { get; set; }
        public string? DescricaoFornecedor { get; set; }
        public string? CnpjFornecedor { get; set; }
    }
}
