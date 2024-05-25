using win_crud.Model;
using win_crud.Services.Interfaces;

namespace win_crud.Forms;
public partial class FormAdd : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    public event EventHandler<Person> PersonAdded;

    public FormAdd(IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
    }

    private void FormAdd_Load(object sender, EventArgs e)
    {
        ControlBox = false;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        Address address = GetAddressForm();

        Person? personResult = _personService.Create(GetPersonForm());
        if (personResult is not null)
        {
            address.PersonId = personResult.Id;
            _addressService.Create(address);
            Close();
        }
        else ClearFields();
    }

    public void ClearFields()
    {
        //Pessoa
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        txtEmail.Text = string.Empty;
        mtbCelPhone.Text = string.Empty;
        mtbPhone.Text = string.Empty;
        mtbCPF.Text = string.Empty;
        mtbAge.Text = string.Empty;

        //Endereço
        mtbZipCode.Text = string.Empty;
        txtStreet.Text = string.Empty;
        txtCountry.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtState.Text = string.Empty;
        txtUF.Text = string.Empty;
        txtNumber.Text = string.Empty;
    }
    public Person GetPersonForm() => new()
    {
        FirstName = txtFirstName.Text,
        LastName = txtLastName.Text,
        Email = txtEmail.Text,
        CelPhone = mtbCelPhone.Text,
        Phone = mtbPhone.Text,
        Age = ushort.Parse(mtbAge.Text),
        CPF = mtbCPF.Text,
    };
    public Address GetAddressForm() => new()
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
