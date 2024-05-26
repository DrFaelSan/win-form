using System.Text.RegularExpressions;

namespace win_crud.DTOs;
public record PersonFilterDTO
(
    string? FirstName,
    ushort? Age,
    string? CPF
)
{
    public static PersonFilterDTO Create(string? firstName, ushort? age, string? cpf)
    {
        //Verificar se tem 11 números.
        string onlyDigits = Regex.Replace(cpf ?? "", "[^0-9]", "");
        
        return new PersonFilterDTO(
            string.IsNullOrWhiteSpace(firstName) ? null : firstName.Trim(),
            age,
            string.IsNullOrWhiteSpace(onlyDigits) ? null : onlyDigits
        );
    }
}