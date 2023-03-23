using AutoGlassApi.Domain.Entities.Enums;
using System;

namespace AutoGlassApi.Domain.Parameters
{
    public class ProdutoParameters
    {
        public SituacaoProduto? Situacao { get; set; }
        public DateTime DataFabricacaoMin { get; set; } = DateTime.MinValue;
        public DateTime DataFabricacaoMax { get; set; } = DateTime.MaxValue;
        public DateTime DataValidadeMin { get; set; } = DateTime.MinValue;
        public DateTime DataValidadeMax { get; set; } = DateTime.MaxValue;

        public bool DataFabricacaoValida() => DataFabricacaoMax >= DataFabricacaoMin;
        public bool DataValidadeValida() => DataValidadeMax >= DataValidadeMin;
    }
}
