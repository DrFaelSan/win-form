using FluentValidation.Results;

namespace win_crud.Business;
public class BusinessManager : IBusinessManager
{
    private List<string> _rules;
    private List<ValidationResult> _validationResults;

    public BusinessManager()
    {
        _rules = new List<string>();
        _validationResults = new List<ValidationResult>();
    }

    public void AdicionarRegra(string mensagem)
       => _rules.Add(mensagem);

    public void AdicionarValidacao(ValidationResult validation)
        => _validationResults.Add(validation);

    public IReadOnlyList<string> ObterErrosDeRegras()
    {
        var rules = new List<string>(_rules);
        _rules.Clear();

        return rules;
    }

    public IEnumerable<ValidationMessage> ObterErrosDeValidacoes()
    {
        var validations = _validationResults.SelectMany(x => x.Errors)
                                            .Select(v => new ValidationMessage(v.ErrorMessage, v.PropertyName))
                                            .ToList();

        _validationResults.Clear();
        return validations;
    }

    public bool HasValidationErrors()
        =>  _validationResults.Any(x => !x.IsValid);
    
    public bool IsValid()
        =>  !_rules.Any() && !_validationResults.Any(x => !x.IsValid);
}
