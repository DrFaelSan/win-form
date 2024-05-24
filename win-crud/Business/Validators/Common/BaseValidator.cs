using FluentValidation;

namespace win_crud.Business.Validators.Common;
public abstract class BaseValidator<TEntity> : AbstractValidator<TEntity>
{

    /// <summary>
    /// Método desenvolvido para verificar se um valor contém somente números.
    /// </summary>
    /// <returns>
    /// Retornar a expressão regex para ser testado no matches do FluentValidations.
    /// </returns>
    protected string OnlyNumberRegex() => @"^\d+$"; //Somente números
}
