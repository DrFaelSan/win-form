using FluentValidation.Results;

namespace win_crud.Business;

public interface IBusinessManager : IBusinessConsumer
{
    void AdicionarRegra(string mensagem);
    void AdicionarValidacao(ValidationResult validation);
}
