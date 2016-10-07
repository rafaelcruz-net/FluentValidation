using FluentValidation;
using FluentValidationSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationSample.Validator
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            this.RuleFor(x => x.Name).NotEmpty().WithMessage("Nome é obrigatório")
                .Length(1, 40).WithMessage("Nome não pode ser maior que 40 caracteres");

            this.RuleFor(x => x.Description).NotEmpty().WithMessage("Descrição é obrigatório")
                .Length(1, 255).WithMessage("Descrição não pode ser maior que 255 caracteres");

            this.RuleFor(x => x.Price).NotEmpty().WithMessage("Preço é obrigatório")
                .GreaterThan(0.0M).WithMessage("Preço do produto deve ser maior que zero");


        }
    }
}