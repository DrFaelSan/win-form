using win_crud.Model;

namespace win_crud.DTOs;
public record PersonGridItemDTO
(
    int Id,
    string FirstName,
    string LastName,
    short? Age,
    string? Phone,
    string? Email,
    string? CPF
)
{
    public PersonGridItemDTO(Person person) : this(
        Id: person.Id,
        FirstName: person.FirstName,
        LastName: person.LastName,
        Age: person.Age,
        Phone: person.Phone,
        Email: person.Email,
        CPF: person.CPF
    ) {}
}
