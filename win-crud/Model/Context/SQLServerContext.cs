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
        SeedInitialData(builder);
        builder.ApplyConfiguration(new PersonMap());
        builder.ApplyConfiguration(new AddressMap());
        base.OnModelCreating(builder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("DB_STRING") ?? "");
    }

    private void SeedInitialData(ModelBuilder modelBuilder)
    {
        // Inserir dados iniciais
        modelBuilder.Entity<Person>().HasData(
            new Person
            {
                Id = 1,
                FirstName = "João",
                LastName = "Silva",
                Age = 30,
                Phone = "1156794477",
                CelPhone = "11984763130",
                Email = "joao.silva@example.com",
                CPF = "123.456.789-01",
                CreatedAt = DateTime.Now
            },
            new Person
            {
                Id = 2,
                FirstName = "Maria",
                LastName = "Santos",
                Age = 25,
                Phone = "1156794477",
                CelPhone = "11987537480",
                Email = "maria.santos@example.com",
                CPF = "987.654.321-02",
                CreatedAt = DateTime.Now
            },
            new Person
            {
                Id = 3,
                FirstName = "Pedro",
                LastName = "Oliveira",
                Age = 40,
                Phone = "1156794477",
                CelPhone = "11984933130",
                Email = "pedro.oliveira@example.com",
                CPF = "111.222.333-03",
                CreatedAt = DateTime.Now
            },
            new Person
            {
                Id = 4,
                FirstName = "Ana",
                LastName = "Pereira",
                Age = 35,
                Phone = "1156794477",
                CelPhone = "11987558130",
                Email = "ana.pereira@example.com",
                CPF = "444.555.666-04",
                CreatedAt = DateTime.Now
            },
            new Person
            {
                Id = 5,
                FirstName = "Carlos",
                LastName = "Souza",
                Age = 28,
                Phone = "1156794477",
                CelPhone = "11946833130",
                Email = "carlos.souza@example.com",
                CPF = "777.888.999-05",
                CreatedAt = DateTime.Now
            }
        );

        modelBuilder.Entity<Address>().HasData(
            new Address
            {
                Id = 1,
                Country = "Brasil",
                Street = "Rua A",
                Number = "123",
                City = "São Paulo",
                State = "São Paulo",
                UF = "SP",
                ZipCode = "01010-010",
                PersonId = 1,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 2,
                Country = "Brasil",
                Street = "Rua B",
                Number = "456",
                City = "Rio de Janeiro",
                State = "Rio de Janeiro",
                UF = "RJ",
                ZipCode = "02020-020",
                PersonId = 2,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 3,
                Country = "Brasil",
                Street = "Rua C",
                Number = "789",
                City = "Belo Horizonte",
                State = " Minas Gerais",
                UF = "MG",
                ZipCode = "03030-030",
                PersonId = 3,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 4,
                Country = "Brasil",
                Street = "Rua D",
                Number = "1011",
                City = "Curitiba",
                State = "Paraná",
                UF = "PR",
                ZipCode = "04040-040",
                PersonId = 4,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 5,
                Country = "Brasil",
                Street = "Rua E",
                Number = "1213",
                City = "Porto Alegre",
                State = "Rio Grande do Sul",
                UF = "RS",
                ZipCode = "05050-050",
                PersonId = 5,
                CreatedAt = DateTime.Now
            }
        );
    }

}
