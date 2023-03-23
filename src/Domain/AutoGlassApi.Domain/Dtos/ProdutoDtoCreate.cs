using AutoGlassApi.Domain.Dtos.Validations;
using AutoGlassApi.Domain.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AutoGlassApi.Domain.Dtos
{
    public class ProdutoDtoCreate
    {
        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(
            50, 
            ErrorMessage = "A descrição deve conter no máximo 50 caracteres")]
        public string Descricao { get; set; }

        [DataFabricacaoValida]
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int CodigoFornecedor { get; set; }

        [StringLength(
            50,
            ErrorMessage = "A descrição do fornecedor deve conter no máximo 50 caracteres")]
        public string DescricaoFornecedor { get; set; }
        public string CnpjFornecedor { get; set; }
    }


}
