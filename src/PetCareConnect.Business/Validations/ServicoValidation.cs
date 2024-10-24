using FluentValidation;
using PetCareConnect.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Validations
{
    public class ServicoValidation : AbstractValidator<Servico>
    {
        public ServicoValidation()
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
