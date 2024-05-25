using FluentValidation;
using win_crud.Model;

namespace win_crud.Validations;
public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty().WithMessage("O campo Nome é obrigatório.");
        RuleFor(p => p.FirstName).MaximumLength(20).WithMessage("O campo Nome não pode ter mais de 20 caracteres.");
        RuleFor(p => p.LastName).NotEmpty().WithMessage("O campo Sobrenome é obrigatório.");
        RuleFor(p => p.LastName).MaximumLength(30).WithMessage("O campo Sobrenome não pode ter mais de 30 caracteres.");
        RuleFor(p => p.Phone).MaximumLength(20).WithMessage("O campo Telefone não pode ter mais de 20 caracteres.");
    }
}
