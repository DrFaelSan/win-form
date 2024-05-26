using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using win_crud.DTOs;
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
        var sql = $"INSERT INTO {nameof(Person)} (FirstName, LastName, Age, Phone, CelPhone, Email, CPF, CreatedAt) " +
           "OUTPUT INSERTED.* " +
           "VALUES (@FirstName, @LastName, @Age, @Phone, @CelPhone, @Email, @CPF, @CreatedAt)";

        Person? insertedPerson = _context.Person
            .FromSqlRaw(sql,
                new SqlParameter("@FirstName", person.FirstName.Trim()),
                new SqlParameter("@LastName", person.LastName.Trim()),
                new SqlParameter("@Age", person.Age),
                new SqlParameter("@Phone", person.Phone ?? string.Empty),
                new SqlParameter("@CelPhone", person.CelPhone ?? string.Empty),
                new SqlParameter("@Email", person.Email ?? string.Empty),
                new SqlParameter("@CPF", person.CPF.Replace(",","").Replace("-","") ?? string.Empty),
                new SqlParameter("@CreatedAt", DateTime.Now))
            .AsEnumerable()
            .FirstOrDefault();

        return insertedPerson;
    }

    public bool Delete(int personId)
    {
        var sql = $"DELETE FROM {nameof(Person)} " + @"
            WHERE Id = {0}
        ";

        int rowsAffected = _context.Database.ExecuteSqlRaw(sql, personId);

        return rowsAffected > 0;
    }

    public IEnumerable<Person> GetAll(PersonFilterDTO? filterDTO = null)
    {
        var query = _context.Person.AsNoTracking();
        if (filterDTO is not null)
        {
            if (!string.IsNullOrEmpty(filterDTO.FirstName))
                query = query.Where(p => p.FirstName == filterDTO.FirstName || 
                                         p.FirstName.Contains(filterDTO.FirstName));

            if (filterDTO.Age.HasValue)
                query = query.Where(p => p.Age == filterDTO.Age);

            if (!string.IsNullOrEmpty(filterDTO.CPF))
                query = query.Where(p => p.CPF == filterDTO.CPF || 
                                         p.CPF.Contains(filterDTO.CPF));
        }

        return query.ToList();
    }
        
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
                person.FirstName.Trim(),
                person.LastName.Trim(),
                person.Age,
                person.Phone ?? string.Empty,
                person.CelPhone ?? string.Empty,
                person.Email ?? string.Empty,
                person.CPF?.Replace(",", "").Replace("-", "") ?? string.Empty,
                personId);
            return rowsAffected > 0 ? person : null;
        }
        return null;
    }
}
