using FluentValidation;
using win_crud.Model;

namespace win_crud.Validations;
public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(a => a.Street).NotEmpty().WithMessage("O campo Lougradouro é obrigatório.");
        RuleFor(a => a.ZipCode).NotEmpty().WithMessage("O campo CEP é obrigatório.");
        RuleFor(a => a.City).NotEmpty().WithMessage("O campo Cidade é obrigatório.");
        RuleFor(a => a.State).NotEmpty().WithMessage("O campo Estado é obrigatório.");
        RuleFor(a => a.UF).MaximumLength(2).WithMessage("O campo UF deve conter somente 2 caracteres");
    }
}
