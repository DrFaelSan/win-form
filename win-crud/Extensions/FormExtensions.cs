namespace win_crud.Extensions;
public static class FormExtensions
{
    public static void ResetForm(this Form form)
    {
        foreach (Control control in form.Controls)
        {
            if (control is TextBox textBox)
                textBox.Clear();
            else if (control is MaskedTextBox maskedTextBox)
                maskedTextBox.Clear();
        }
    }
}
