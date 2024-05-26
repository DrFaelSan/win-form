using win_crud.Forms;
using win_crud.Model;
using win_crud.Services.Interfaces;
using win_crud.Utils;

namespace win_crud;

public partial class FormMain : Form
{
    private bool SiderbarExpand = true;
    FormList? _formList;
    FormAdd? _formAdd;
    private readonly IAddressService _addressService;
    private readonly IPersonService _personService;
    public FormMain(IAddressService addressService, IPersonService personService)
    {
        InitializeComponent();
        ConfigureMdiClient();
        _addressService = addressService;
        _personService = personService;
        ShowListForm();
    }

    private void ConfigureMdiClient()
    {
        this.SetBevel(false);
        if (Controls.OfType<MdiClient>().FirstOrDefault() is MdiClient mdiClient)
            mdiClient.BackColor = Color.FromArgb(232, 234, 237);
    }

    private void SidebarTransition_Tick(object sender, EventArgs e)
    {
        if (SiderbarExpand)
        {
            //Recolher
            sidebar.Width -= 5;
            if (sidebar.Width <= 83)
            {
                SiderbarExpand = false;
                sidebarTransition.Stop();
            }
        }
        else
        {
            //Expandir
            sidebar.Width += 5;
            if (sidebar.Width >= 250)
            {
                SiderbarExpand = true;
                sidebarTransition.Stop();
            }
        }
    }

    private void BtnMenu_Click(object sender, EventArgs e)
        => ToggleSidebar();

    private void BtnList_Click(object sender, EventArgs e)
        =>  ShowListForm();
    
    private void BtnAdd_Click(object sender, EventArgs e)
        =>  ShowAddForm();

    private void ShowListForm()
    {
        ResetForms();
        _formList = new FormList(_personService, _addressService);
        SetupForm(_formList);
    }

    private void ShowAddForm()
    {
        ResetForms();
        _formAdd = new FormAdd(_personService, _addressService);
        _formAdd.PersonAdded += (s, addedPerson) => { BtnList_Click(this, EventArgs.Empty); };
        SetupForm(_formAdd);
    }

    private void ToggleSidebar()
        =>  sidebarTransition.Start();

    private void SetupForm(Form form)
    {
        form.FormClosed += (sender, e) => ResetForms();
        form.MdiParent = this;
        form.Dock = DockStyle.Fill;
        form.Show();
    }

    private void ResetForms()
    {
        _formList?.Dispose();
        _formList = null;
        _formAdd?.Dispose();
        _formAdd = null;
    }
}
