using FluentValidation;
using FluentValidation.Results;
using win_crud.DTOs;
using win_crud.Extensions;
using win_crud.Model;
using win_crud.Repository.Interfaces;
using win_crud.Services.Interfaces;

namespace win_crud.Services;
public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;
    private readonly IValidator<Person> _personValidator;

    public PersonService(IPersonRepository personRepository, 
                         IValidator<Person> personValidator)
    {
        _personRepository = personRepository;
        _personValidator = personValidator;
    }

    public Person? Create(Person person)
        => IsValid(person) ? _personRepository.Create(person) : null;

    public bool Delete(int personId)
        => _personRepository.Delete(personId);

    public IEnumerable<Person> GetAll(PersonFilterDTO? filterDTO = null)
        => _personRepository.GetAll(filterDTO);

    public Person? GetById(int id)
        => _personRepository.GetById(id);

    public Person? Update(int personId, Person person)
        => IsValid(person) ? _personRepository.Update(personId, person) : null;

    public bool IsValid(Person person)
    {
        ValidationResult validationResult = _personValidator.Validate(person);

        if (!validationResult.IsValid)
            validationResult.ShowValidationErrors("Erro ao validar dados da Pessoa");
        
        return validationResult.IsValid;
    }
}
