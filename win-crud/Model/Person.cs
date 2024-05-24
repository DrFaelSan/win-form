using System.ComponentModel.DataAnnotations.Schema;
using win_crud.Model.Common;

namespace win_crud.Model;

[Table("Person")]
public sealed class Person : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => $"{FirstName} {LastName}"; }
    public ushort Age { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public int AddressId { get; set; }

    [ForeignKey("AddressId")]
    public Address Address { get; set; }

}
