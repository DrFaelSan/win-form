using win_crud.Model;
using win_crud.Services.Interfaces;

namespace win_crud.Forms;
public partial class FormEdit : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    private readonly Person _person;

    public FormEdit(Person person, IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
        _person = person;
        InitializeControls();
    }

    private void InitializeControls()
    {
        var address = _addressService.FindByPersonId(_person.Id);
        txtStreet.Text = address?.Street;
        txtCity.Text = address?.City;
        txtState.Text = address?.State;
        mtbZipCode.Text = address?.ZipCode;
        txtNumber.Text = address?.Number;
        txtUF.Text = address?.UF;
        txtCountry.Text = address?.Country;

        txtFirstName.Text = _person.FirstName;
        txtLastName.Text = _person.LastName;
        mtbAge.Text = _person.Age.ToString();
        mtbPhone.Text = _person.Phone;
        mtbCelPhone.Text = _person.CelPhone;
        txtEmail.Text = _person.Email;
        mtbCPF.Text = _person.CPF;
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            var address = GetAddressFromForm();
            var person = GetPersonFromForm();

            if (_addressService.IsValid(address) && _personService.IsValid(person))
            {
                _personService.Update(_person.Id, person);
                _addressService.UpdateByPersonId(_person.Id, address);
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao atualizar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private Person GetPersonFromForm()
    {
        _ = short.TryParse(mtbAge.Text, out short age);

        return new Person
        {
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            Email = txtEmail.Text,
            CelPhone = mtbCelPhone.Text,
            Phone = mtbPhone.Text,
            Age = age,
            CPF = mtbCPF.Text,
        };
    }

    private Address GetAddressFromForm() => new()
    {
        ZipCode = mtbZipCode.Text,
        Street = txtStreet.Text,
        Country = txtCountry.Text,
        City = txtCity.Text,
        State = txtState.Text,
        UF = txtUF.Text,
        Number = txtNumber.Text,
    };
}