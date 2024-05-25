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

    public Person? Create(Person person)
    {
        var sql = $"INSERT INTO {nameof(Person)} "+@"(FirstName, LastName, Age, Phone, CelPhone, Email, CPF)
            VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})";

        int rowsAffected = _context.Database.ExecuteSqlRaw(sql,
            person.FirstName,
            person.LastName,
            person.Age,
            person.Phone ?? string.Empty,
            person.CelPhone ?? string.Empty,
            person.Email ?? string.Empty,
            person.CPF ?? string.Empty);

        return rowsAffected > 0 ? person : null;
    }

    public bool Delete(int personId)
    {
        var sql = $"DELETE FROM {nameof(Person)} " + @"
            WHERE PersonId = {0}
        ";

        int rowsAffected = _context.Database.ExecuteSqlRaw(sql, personId);

        return rowsAffected > 0;
    }

    public IEnumerable<Person> GetAll()
    => _context.Person.AsNoTracking()
                      .ToList();
        
    public Person? GetById(int id)
        => _context.Person.AsNoTracking()
                          .Include(p => p.Address)
                          .FirstOrDefault(p => p.Id == id);
    public Person? Update(int personId, Person person)
    {
        var exists = _context.Person.AsNoTracking()
                            .Any(p => p.Id == personId);
        if (exists)
        {
            var sql = $"UPDATE {nameof(Person)} "+@"
            SET FirstName = {0},
                LastName = {1},
                Age = {2},
                Phone = {3},
                CelPhone = {4},
                Email = {5},
                CPF = {6}
            WHERE Id = {7}
            ";

            int rowsAffected = _context.Database.ExecuteSqlRaw(sql,
                person.FirstName,
                person.LastName,
                person.Age,
                person.Phone ?? string.Empty,
                person.CelPhone ?? string.Empty,
                person.Email ?? string.Empty,
                person.CPF ?? string.Empty,
                personId);
            return rowsAffected > 0 ? person : null;
        }
        return null;
    }
}
