using System.ComponentModel.DataAnnotations.Schema;
using win_crud.Model.Common;

namespace win_crud.Model;

[Table("Address")]
public class Address : BaseEntity
{
    public string ZipCode { get; set; } = default!;
    public string Street { get; set; } = default!;
    public string? City { get; set; } = default!;
    public string? State { get; set; } = default!;
    public string? Country { get; set; } 
    public string? Number { get; set; }
    public string? UF { get; set; }
    
    public int? PersonId { get; set; }
    public virtual Person? Person { get; set; }
}
