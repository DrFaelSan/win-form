using System.ComponentModel.DataAnnotations.Schema;
using win_crud.Model.Common;

namespace win_crud.Model;

[Table("Person")]
public class Person : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get => $"{FirstName} {LastName}"; }
    public short Age { get; set; }
    public string? Phone { get; set; }
    public string? CelPhone { get; set; }
    public string? Email { get; set; }
    public string? CPF { get; set; }

    public virtual Address? Address { get; set; }

    public Person(){}
}
