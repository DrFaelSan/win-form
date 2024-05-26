using win_crud.Forms;
using win_crud.Model;
using win_crud.Services.Interfaces;
using win_crud.Utils;

namespace win_crud;

public partial class FormMain : Form
{
    private bool SiderbarExpand = true;
    FormList? formList;
    FormAdd? formAdd;
    private readonly IAddressService _addressService;
    private readonly IPersonService _personService;
    public FormMain(IAddressService addressService, IPersonService personService)
    {
        InitializeComponent();
        MdiProp();
        //MaximizeBox = false;
        _addressService = addressService;
        _personService = personService;
    }

    private void MdiProp()
    {
        this.SetBevel(false);
        if (Controls.OfType<MdiClient>().Any())
            Controls.OfType<MdiClient>().First().BackColor = Color.FromArgb(232, 234, 237);
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
        => sidebarTransition.Start();

    private void BtnList_Click(object sender, EventArgs e)
    {
            ResetAllForms();
            formList = new FormList(_personService, _addressService);
            formList.FormClosed += FormList_FormClosed;
            formList.MdiParent = this;
            formList.Dock = DockStyle.Fill;
            formList.Show();
    }

    private void ResetAllForms()
    {
        formList = null;
        formAdd = null;
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        ResetAllForms();
        formAdd = new FormAdd(_personService, _addressService);
        formAdd.FormClosed += FormAdd_FormClosed;
        formAdd.PersonAdded += (sender, newPerson) =>
        {
            Person? person = _personService.Create(newPerson);
            if (person is not null) formAdd.Close();
            else formAdd.ClearFields();
        };
        formAdd.MdiParent = this;
        formAdd.Dock = DockStyle.Fill;
        formAdd.Show();
    }

    private void FormList_FormClosed(object? sender, FormClosedEventArgs e)
       => formList = null;

    private void FormAdd_FormClosed(object? sender, FormClosedEventArgs e)
        => formAdd = null;
}
