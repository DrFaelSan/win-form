using Microsoft.EntityFrameworkCore;
using win_crud.Model;
using win_crud.Model.Context;
using win_crud.Repository.Interfaces;

namespace win_crud.Repository;
public class AddressRepository : IAddressRepository
{
    private readonly SQLServerContext _context;

    public AddressRepository(SQLServerContext context)
        =>  _context = context;

    public Address? Create(Address address)
    {
        var sql = $"INSERT INTO {nameof(Address)} "+@"(ZipCode, Street, City, State, Country, Number, UF, PersonId)
            VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
            ";

        int rowsAffected = _context.Database.ExecuteSqlRaw(sql,
            address.ZipCode,
            address.Street,
            address.City ?? string.Empty,
            address.State ?? string.Empty,
            address.Country ?? string.Empty,
            address.Number ?? string.Empty,
            address.UF ?? string.Empty,
            address.PersonId);

        return rowsAffected > 0 ? address : null;
    }

    public bool DeleteByPersonId(int personId)
    {
        var sql = $"DELETE FROM {nameof(Address)} " + @"
            WHERE PersonId = {0}
        ";

        int rowsAffected = _context.Database.ExecuteSqlRaw(sql, personId);

        return rowsAffected > 0;
    }

    public Address? FindByPersonId(int personId)
        => _context.Address.AsNoTracking()
                           .FirstOrDefault(a => a.PersonId == personId);
    public IEnumerable<Address> GetAll()
        => _context.Address.ToList();

    public Address? UpdateByPersonId(int personId, Address address)
    {
        var exists = _context.Address.AsNoTracking()
                                              .Any(a => a.PersonId == personId);

        if (exists)
        {
            var sql = $"UPDATE {nameof(Address)} " +@"
                    SET  ZipCode = {0}, 
                         Street = {1}, 
                         City = {2}, 
                         State = {3}, 
                         Country = {4}, 
                         Number = {5}, 
                         UF = {6}
                    WHERE PersonId = {7}
                    ";

            int rowsAffected = _context.Database.ExecuteSqlRaw(sql,
                address.ZipCode,
                address.Street,
                address.City ?? string.Empty,
                address.State ?? string.Empty,
                address.Country ?? string.Empty,
                address.Number ?? string.Empty,
                address.UF ?? string.Empty,
                personId);

            return rowsAffected > 0 ? address : null;
        }
        return null;
    }

    protected Address? GetById(int id)
        => _context.Address.AsNoTracking()
                           .FirstOrDefault(a => a.Id == id);
}
