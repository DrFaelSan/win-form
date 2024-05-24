using Microsoft.EntityFrameworkCore;
using win_crud.Model;
using win_crud.Model.Context;
using win_crud.Repository.Interfaces;

namespace win_crud.Repository;
public class PersonRepository : IPersonRepository
{
    private readonly SQLServerContext _context;

    public PersonRepository(SQLServerContext context)
        =>  _context = context;

    public async Task<Person> CreateAsync(Person person)
    {
        _context.Person.Add(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<bool> DeleteAsync(int personId)
    {
        Person? person = await GetByIdAsync(personId);
        if (person is not null)
        {
            _context.Person.Remove(person);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
    }

    public async Task<IEnumerable<Person?>> GetAllAsync()
        => await _context.Person.ToListAsync();

    public async Task<Person?> GetByIdAsync(int personId)
        => await _context.Person.AsNoTracking()
                                .Include(p => p.Address)
                                .FirstOrDefaultAsync(p => p.Id == personId);

    public async Task<Person?> UpdateAsync(int personId, Person person)
    {
        if(_context.Person.Any(p => p.Id == personId))
        {
            _context.Person.Update(person);
            await _context.SaveChangesAsync();
            return person;
        }
        return null;
    }
}
