namespace win_crud.Business;
public interface IBusinessConsumer
{
    IReadOnlyList<string> ObterErrosDeRegras();
    IEnumerable<ValidationMessage> ObterErrosDeValidacoes();
    bool HasValidationErrors();
    bool IsValid();
}
