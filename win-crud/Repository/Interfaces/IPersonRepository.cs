using win_crud.Model;

namespace win_crud.Repository.Interfaces;
public interface IPersonRepository
{
    Task<Person> CreateAsync(Person person);
    Task<IEnumerable<Person?>> GetAllAsync();
    Task<Person?> GetByIdAsync(int id);
    Task<Person?> UpdateAsync(int personId, Person person);
    Task<bool> DeleteAsync(int personId);
}
