using win_crud.Model;

namespace win_crud.Repository.Interfaces;
public interface IAddressRepository
{
    Address? FindByPersonId(int personId);
    Address? Create(Address address);
    IEnumerable<Address> GetAll();
    public bool DeleteByPersonId(int personId);
    Address? UpdateByPersonId(int personId, Address address);
}
