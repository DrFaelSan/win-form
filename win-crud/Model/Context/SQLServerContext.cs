using Microsoft.EntityFrameworkCore;
using win_crud.Model.ContextMap;

namespace win_crud.Model.Context;

public class SQLServerContext : DbContext
{
    public SQLServerContext() { }
    public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }

    public DbSet<Person> Person { get; set; }
    public DbSet<Address> Address { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new PersonMap());
        builder.ApplyConfiguration(new AddressMap());
    }

}
