using FluentValidation.Results;
using win_crud.Model;
using win_crud.Repository.Interfaces;

namespace win_crud.Services.Interfaces;
public interface IPersonService : IPersonRepository
{
    public bool IsValid(Person person);
    public ValidationResult GetErrors(Person person);
}
