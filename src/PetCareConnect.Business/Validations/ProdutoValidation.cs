using FluentValidation;
using PetCareConnect.Business.Models;


namespace PetCareConnect.Business.Validations
{
    internal class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser forncido")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Descricao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser forncido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName} ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Valor)
                .GreaterThan(0)
                .WithMessage("O campo {PropertyName} precisa ser maior que {ComparisionValue}");

        }
    }
}
