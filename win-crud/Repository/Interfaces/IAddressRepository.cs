using win_crud.Model;

namespace win_crud.Repository.Interfaces;
public interface IAddressRepository
{
    Task<Address?> FindByPersonIdAsync(int personId);
    Task<Address> CreateAsync(Address address);
    Task<IEnumerable<Address>> GetAllAsync();
    Task<bool> DeleteAsync(int id);
    Task<bool> DeleteByPersonIdAsync(int personId);
    Task<Address?> UpdateAsync(int id, Address address);
    Task<Address?> UpdateByPersonIdAsync(int personId, Address address);
}
