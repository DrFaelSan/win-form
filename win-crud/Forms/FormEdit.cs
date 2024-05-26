using win_crud.Model;
using win_crud.Services.Interfaces;

namespace win_crud.Forms;
public partial class FormEdit : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    private readonly Person Person;

    public FormEdit(Person person, IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
        Person = person;
        InitializeControls();
    }

    public void InitializeControls()
    {
        var address = _addressService.FindByPersonId(Person.Id);
        txtStreet.Text = address?.Street;
        txtCity.Text = address?.City;
        txtState.Text = address?.State;
        mtbZipCode.Text = address?.ZipCode;
        txtNumber.Text = address?.Number;
        txtUF.Text = address?.UF;
        txtCountry.Text = address?.Country;

        txtFirstName.Text = Person.FirstName;
        txtLastName.Text = Person.LastName;
        mtbAge.Text = Person.Age.ToString();
        mtbPhone.Text = Person.Phone;
        mtbCelPhone.Text = Person.CelPhone;
        txtEmail.Text = Person.Email;
        mtbCPF.Text = Person.CPF;
    }

    private void FormEdit_Load(object sender, EventArgs e)
    {
        ControlBox = false;
        InitializeControls();
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        Address address = GetAddressFromForm();
        Person person = GetPersonFromForm();

        if (_addressService.IsValid(address) && _personService.IsValid(person))
        {
            _personService.Update(Person.Id, person);
            _addressService.UpdateByPersonId(Person.Id, address);
            Close();
        }      
        else ClearFields();
    }

    public void ClearFields()
    {
        ////Pessoa
        //txtFirstName.Text = string.Empty;
        //txtLastName.Text = string.Empty;
        //txtEmail.Text = string.Empty;
        //mtbCelPhone.Text = string.Empty;
        //mtbPhone.Text = string.Empty;
        //mtbCPF.Text = string.Empty;
        //mtbAge.Text = string.Empty;

        ////Endereço
        //mtbZipCode.Text = string.Empty;
        //txtStreet.Text = string.Empty;
        //txtCountry.Text = string.Empty;
        //txtCity.Text = string.Empty;
        //txtState.Text = string.Empty;
        //txtUF.Text = string.Empty;
        //txtNumber.Text = string.Empty;

        foreach (Control control in Controls)
        {
            if (control is TextBox textBox)
            {
                textBox.Clear();
            }
            else if (control is MaskedTextBox maskedTextBox)
            {
                maskedTextBox.Clear();
            }
        }
    }
    public Person GetPersonFromForm()
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

    public Address GetAddressFromForm() => new()
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
