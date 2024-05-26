using win_crud.Model;
using win_crud.Services.Interfaces;

namespace win_crud.Forms;
public partial class FormAdd : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    public event EventHandler<Person>? PersonAdded;

    public FormAdd(IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            Address address = GetAddressForm();
            Person person = GetPersonForm();

            if (_personService.IsValid(person) && _addressService.IsValid(address))
            {
                Person? addedPerson = _personService.Create(person);
                if (addedPerson != null)
                {
                    address.PersonId = addedPerson.Id;
                    _addressService.Create(address);
                    PersonAdded?.Invoke(this, addedPerson);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao criar pessoa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void ClearFields()
    {
        // Limpar campos de Pessoa
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        txtEmail.Text = string.Empty;
        mtbCelPhone.Text = string.Empty;
        mtbPhone.Text = string.Empty;
        mtbCPF.Text = string.Empty;
        mtbAge.Text = string.Empty;

        // Limpar campos de Endereço
        mtbZipCode.Text = string.Empty;
        txtStreet.Text = string.Empty;
        txtCountry.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtState.Text = string.Empty;
        txtUF.Text = string.Empty;
        txtNumber.Text = string.Empty;
    }

    public Person GetPersonForm() => new Person
    {
        FirstName = txtFirstName.Text,
        LastName = txtLastName.Text,
        Email = txtEmail.Text,
        CelPhone = mtbCelPhone.Text,
        Phone = mtbPhone.Text,
        Age = short.Parse(mtbAge.Text),
        CPF = mtbCPF.Text,
    };

    public Address GetAddressForm() => new Address
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