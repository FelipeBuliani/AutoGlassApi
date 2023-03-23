using AutoGlassApi.Domain.Entities.Enums;
using System;

namespace AutoGlassApi.Domain.Entities
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public SituacaoProduto? Situacao { get; set; } = SituacaoProduto.Ativo;
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public int? CodigoFornecedor { get; set; }
        public string? DescricaoFornecedor { get; set; }
        public string? CnpjFornecedor { get; set; }
    }
}
