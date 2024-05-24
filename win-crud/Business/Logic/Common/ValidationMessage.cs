namespace win_crud.Business;
public class ValidationMessage
{
    public string Message { get; }
    public string Field { get; }

    public ValidationMessage(string message, string field)
    {
        Message = message;
        Field = field;
    }
}