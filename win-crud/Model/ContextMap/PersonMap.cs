using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace win_crud.Model.ContextMap;

public class PersonMap : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.FirstName)
               .IsRequired()
               .HasMaxLength(20);
        builder.Property(p => p.LastName)
               .IsRequired()
               .HasMaxLength(30);
        builder.Property(p => p.Phone).HasMaxLength(20);

        builder.HasOne(p => p.Address)
            .WithOne(a => a.Person)
            .HasForeignKey<Address>(a => a.PersonId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
