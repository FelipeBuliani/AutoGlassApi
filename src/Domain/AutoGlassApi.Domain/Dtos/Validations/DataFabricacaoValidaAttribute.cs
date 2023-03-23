using System;
using System.ComponentModel.DataAnnotations;

namespace AutoGlassApi.Domain.Dtos.Validations
{
    public class DataFabricacaoValidaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Type type = validationContext.ObjectInstance.GetType();

            DateTime dataValidade;

            if (type == typeof(ProdutoDtoCreate))
                dataValidade = ((ProdutoDtoCreate)validationContext.ObjectInstance).DataValidade;
            else
                dataValidade = ((ProdutoDtoUpdate)validationContext.ObjectInstance).DataValidade;

            DateTime dataFrabricacao = (DateTime)value;

            return dataFrabricacao >= dataValidade
                ? new ValidationResult(
                    ErrorMessage = "A data de fabricação não pode ser maior ou igual a data de validade")
                : ValidationResult.Success;
        }
    }
}
