using FluentValidation;
using FluentValidation.Results;
using win_crud.Extensions;
using win_crud.Model;
using win_crud.Repository.Interfaces;
using win_crud.Services.Interfaces;

namespace win_crud.Services;
public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;
    private readonly IValidator<Address> _addressValidator;

    public AddressService(IAddressRepository addressRepository, 
                          IValidator<Address> addressValidator)
    {
        _addressRepository = addressRepository;
        _addressValidator = addressValidator;
    }
    public Address? Create(Address address)
        => IsValid(address) ? _addressRepository.Create(address) : null;

    public bool DeleteByPersonId(int personId)
        => _addressRepository.DeleteByPersonId(personId);

    public Address? FindByPersonId(int personId)
        => _addressRepository.FindByPersonId(personId);

    public IEnumerable<Address> GetAll()
        => _addressRepository.GetAll();
    
    public Address? UpdateByPersonId(int personId, Address address)
        => IsValid(address) ? _addressRepository.UpdateByPersonId(personId, address) : null;

    public bool IsValid(Address address)
    {
        ValidationResult validationResult = _addressValidator.Validate(address);

        if (!validationResult.IsValid)
            validationResult.ShowValidationErrors("Erro ao validar endereço da pessoa");

        return validationResult.IsValid;
    }
}
