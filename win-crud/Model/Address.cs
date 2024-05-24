using System.ComponentModel.DataAnnotations.Schema;
using win_crud.Model.Common;

namespace win_crud.Model;

[Table("Address")]
public sealed class Address : BaseEntity
{
    public string Country { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public int PersonId { get; set; }

    [ForeignKey("PersonId")]
    public Person Person { get; set; }
}
