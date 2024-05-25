using win_crud.Model;
using win_crud.Services.Interfaces;

namespace win_crud.Forms;
public partial class FormList : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    FormEdit? formEdit;
    FormDel? formDel;

    public FormList(IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
    }

    private void FormList_Load(object sender, EventArgs e)
    {
        // Criar o ContextMenuStrip
        var contextMenuStrip = new ContextMenuStrip();

        // Adicionar itens de menu para edição e exclusão
        var editMenuItem = new ToolStripMenuItem("Editar");
        var deleteMenuItem = new ToolStripMenuItem("Excluir");

        // Definir eventos de clique para os itens de menu
        editMenuItem.Click += EditMenuItem_Click;
        deleteMenuItem.Click += DeleteMenuItem_Click;

        // Adicionar os itens de menu ao ContextMenuStrip
        contextMenuStrip.Items.Add(editMenuItem);
        contextMenuStrip.Items.Add(deleteMenuItem);

        // Atribuir o ContextMenuStrip ao DataGridView
        dgvPerson.ContextMenuStrip = contextMenuStrip;

        ControlBox = false;
        LoadPersons();
    }

    private void EditMenuItem_Click(object sender, EventArgs e)
    {
        var person = GetSelectedRow();
        if(person is not null)
        {
            FormEdit_FormClosed(null,null);
            if (formEdit is null)
            {
                formEdit = new FormEdit(person,_personService, _addressService);
                formEdit.FormClosed += FormEdit_FormClosed;
                formEdit.MdiParent = ParentForm;
                formEdit.Dock = DockStyle.Fill;
                formEdit.Show();
            }
            else
                formEdit.Activate();
        }
    }

    public void LoadPersons()
    {
        dgvPerson.Rows.Clear();
        var persons = _personService.GetAll();
        if (persons is not null)
        {
            foreach (Person person in persons)

                dgvPerson.Rows.Add(person.Id,
                                   person.FirstName,
                                   person.LastName,
                                   person.Age,
                                   person.Phone,
                                   person.Email,
                                   person.CPF);
        }
    }

    private void DeleteMenuItem_Click(object sender, EventArgs e)
    {
        var person = GetSelectedRow();
    }

    //private void BtnEdit_Click(object sender, EventArgs e)
    //{

    //}

    //private void BtnDel_Click(object sender, EventArgs e)
    //{
    //    if (formDel is null)
    //    {
    //        formDel = new FormDel(_personService, _addressService);
    //        formDel.FormClosed += FormDel_FormClosed;
    //        formDel.MdiParent = this;
    //        formDel.Dock = DockStyle.Fill;
    //        formDel.Show();
    //    }
    //    else
    //        formDel.Activate();
    //}

    private void FormDel_FormClosed(object? sender, FormClosedEventArgs e)
    {
        formDel = null;
        LoadPersons();
    }

    private void FormEdit_FormClosed(object? sender, FormClosedEventArgs e)
    {
        formEdit = null;
        LoadPersons();
    }

    private Person? GetSelectedRow()
    {
        if (dgvPerson.SelectedRows.Count > 0)
        {
            // Obter a linha selecionada
            DataGridViewRow selectedRow = dgvPerson.SelectedRows[0];

            object? Id = selectedRow.Cells[nameof(Id)].Value;
            if (Id is not null)
                return _personService.GetById(int.Parse($"{Id}"));
        }
        else
            MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       
        return null;
    }
}
