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

    public async Task<Address> CreateAsync(Address address)
    {
        _context.Address.Add(address);
        await _context.SaveChangesAsync();
        return address;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        Address? address = await GetByIdAsync(id);

        if (address is null) return false;

        _context.Address.Remove(address);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteByPersonIdAsync(int personId)
    {
        Address? address = await FindByPersonIdAsync(personId);

        if (address is null) return false;

        _context.Address.Remove(address);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<Address?> FindByPersonIdAsync(int personId)
        => await _context.Address.AsNoTracking()
                                 .FirstOrDefaultAsync(a => a.PersonId == personId);

    public async Task<IEnumerable<Address>> GetAllAsync()
        => await _context.Address.ToListAsync();

    public async Task<Address?> UpdateAsync(int id, Address address)
    {
        if(await _context.Address.AnyAsync(a => a.Id == id))
        {
            address.Id = id;
            _context.Address.Update(address);
            await _context.SaveChangesAsync();
            return address;
        }
        return null;
    }

    public async Task<Address?> UpdateByPersonIdAsync(int personId, Address address)
    {
        Address? addressOnBase = await FindByPersonIdAsync(personId);
        if (addressOnBase is Address)
        {
            addressOnBase.PersonId = personId;
            _context.Address.Update(addressOnBase);
            await _context.SaveChangesAsync();
            return address;
        }

        return null;
    }

    protected async Task<Address?> GetByIdAsync(int id)
        => await _context.Address.AsNoTracking()
                                 .FirstOrDefaultAsync(a => a.Id == id);
}
