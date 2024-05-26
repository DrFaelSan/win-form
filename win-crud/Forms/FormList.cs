using System.Data;
using win_crud.DTOs;
using win_crud.Model;
using win_crud.Services.Interfaces;
using win_crud.Utils;

namespace win_crud.Forms;
public partial class FormList : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    IEnumerable<Person> PersonsOnGrid { get; set; } = Enumerable.Empty<Person>();
    FormEdit? formEdit;

    public static DataTable DataSource
    {
        get
        {
            DataTable dataTable = new();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Sobrenome", typeof(string));
            dataTable.Columns.Add("Idade", typeof(ushort));
            dataTable.Columns.Add("Telefone", typeof(string));
            dataTable.Columns.Add("E-mail", typeof(string));
            dataTable.Columns.Add("CPF", typeof(string));

            return dataTable;
        }
    }

    public ContextMenuStrip ContextMenu
    {
        get
        {
            // Criar o ContextMenuStrip
            ContextMenuStrip contextMenuStrip = new();

            // Adicionar itens de menu para edição e exclusão
            ToolStripMenuItem editMenuItem = new("Editar");
            ToolStripMenuItem deleteMenuItem = new("Excluir");

            // Definir eventos de clique para os itens de menu
            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            // Adicionar os itens de menu ao ContextMenuStrip
            contextMenuStrip.Items.Add(editMenuItem);
            contextMenuStrip.Items.Add(deleteMenuItem);
            return contextMenuStrip;
        }
    }

    public FormList(IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
    }

    private void FormList_Load(object sender, EventArgs e)
    {
        LoadPersons();
        dgvPerson.ClearSelection();
        dgvPerson.ContextMenuStrip = ContextMenu;
        ControlBox = false;
    }

    private void EditMenuItem_Click(object sender, EventArgs e)
    {
        var person = GetSelectedRow();
        if (person is not null)
        {
            FormEdit_FormClosed(null, null);
            if (formEdit is null)
            {
                formEdit = new FormEdit(person, _personService, _addressService);
                formEdit.FormClosed += FormEdit_FormClosed;
                formEdit.MdiParent = ParentForm;
                formEdit.Dock = DockStyle.Fill;
                formEdit.Show();
            }
            else
                formEdit.Activate();
        }
    }

    public void LoadPersons(PersonFilterDTO? filterDTO = null)
    {
        dgvPerson.Rows.Clear();
        IEnumerable<Person> persons = _personService.GetAll(filterDTO);
        PersonsOnGrid = persons;
        foreach (Person person in persons)
            dgvPerson.Rows.Add(person.Id,
                                person.FirstName,
                                person.LastName,
                                person.Age,
                                person.Phone,
                                person.Email,
                                person.CPF);
    }

    private void FormEdit_FormClosed(object? sender, FormClosedEventArgs e)
    {
        formEdit = null;
        LoadPersons();
    }

    private void DeleteMenuItem_Click(object sender, EventArgs e)
    {
        var person = GetSelectedRow();
        if (person is not null)
        {
            DialogResult result = MessageBox.Show($"Tem certeza de que deseja excluir {person.FullName}?",
                                                  $"Confirmar Exclusão da Pessoa {person.Id}",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _personService.Delete(person.Id);
                _addressService.DeleteByPersonId(person.Id);
                dgvPerson.Rows.Remove(dgvPerson.SelectedRows[0]);
            }
        }
        else
            MessageBox.Show("Nenhuma linha selecionada para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private Person? GetSelectedRow()
    {
        if (dgvPerson.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = dgvPerson.SelectedRows[0];
            var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            return _personService.GetById(id);
        }
        else
        {
            MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
    }

    //Filtrar Consulta
    private void BtnSearch_Click(object sender, EventArgs e)
    {
        ushort? age = null;
        if (ushort.TryParse(mtbSearchAge.Text, out ushort parsedAge))
            age = parsedAge;

        PersonFilterDTO filter = PersonFilterDTO.Create(txtSearchFirstName.Text, age, mtbSearchCPF.Text);
        LoadPersons(filter);
    }

    //Relatório
    private void BtnReport_Click(object sender, EventArgs e)
        => Report.BuildPersonReport(PersonsOnGrid);

    private void BtnClean_Click(object sender, EventArgs e)
    {
        mtbSearchAge.Text = "";
        txtSearchFirstName.Text = "";
        mtbSearchCPF.Text = "";
        LoadPersons(null);
    }
}
