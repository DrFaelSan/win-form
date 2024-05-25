using win_crud.Model;
using win_crud.Repository.Interfaces;

namespace win_crud.Services.Interfaces;
public interface IAddressService : IAddressRepository
{
    public bool IsValid(Address address);
}
