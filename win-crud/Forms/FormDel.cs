using win_crud.Services.Interfaces;

namespace win_crud.Forms;
public partial class FormDel : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;

    public FormDel(IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
    }

    private void FormDel_Load(object sender, EventArgs e)
    {
        ControlBox = false;
    }
}
