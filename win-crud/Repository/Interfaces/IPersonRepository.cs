using win_crud.Model;

namespace win_crud.Repository.Interfaces;
public interface IPersonRepository
{
    Person? Create(Person person);
    IEnumerable<Person> GetAll();
    Person? GetById(int id);
    Person? Update(int personId, Person person);
    bool Delete(int personId);
}
