using FluentValidation.Results;
using System.Text;

namespace win_crud.Extensions;
public static class ValidationExtensions
{
    public static void ShowValidationErrors(this ValidationResult validationResult, string title = "Erro de validação")
    {
        if (!validationResult.IsValid)
        {
            StringBuilder sb = new();
            foreach (var error in validationResult.Errors)
                sb.Append($"{error.ErrorMessage}\n");
            
            MessageBox.Show(sb.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
