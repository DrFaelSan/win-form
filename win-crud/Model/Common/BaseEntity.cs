using System.ComponentModel.DataAnnotations;

namespace win_crud.Model.Common;
public class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
