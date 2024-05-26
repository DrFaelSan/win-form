using win_crud.DTOs;
using win_crud.Model;
using win_crud.Services.Interfaces;
using win_crud.Utils;

namespace win_crud.Forms;
public partial class FormList : Form
{
    private readonly IPersonService _personService;
    private readonly IAddressService _addressService;
    private FormEdit? _formEdit;
    private IEnumerable<Person> _personsOnGrid = Enumerable.Empty<Person>();
    private PersonFilterDTO? _currentFilter;

    public FormList(IPersonService personService, IAddressService addressService)
    {
        InitializeComponent();
        _personService = personService;
        _addressService = addressService;
    }

    private void FormList_Load(object sender, EventArgs e)
    {
        LoadPersons(_currentFilter);
        dgvPerson.ClearSelection();
        dgvPerson.ContextMenuStrip = ContextMenu;
        ControlBox = false;
    }

    private void LoadPersons(PersonFilterDTO? filterDTO = null)
    {
        dgvPerson.Rows.Clear();
        _currentFilter = filterDTO ?? _currentFilter;
        _personsOnGrid = _personService.GetAll(_currentFilter);
        foreach (Person person in _personsOnGrid)
            dgvPerson.Rows.Add(person.Id,
                                person.FirstName,
                                person.LastName,
                                person.Age,
                                person.Phone,
                                person.Email,
                                person.CPF);
    }

    private void BtnReport_Click(object sender, EventArgs e)
    {
        Report.BuildPersonReport(_personsOnGrid);
    }

    private void BtnClean_Click(object sender, EventArgs e)
    {
        mtbSearchAge.Text = "";
        txtSearchFirstName.Text = "";
        mtbSearchCPF.Text = "";
        LoadPersons();
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        ushort? age = ushort.TryParse(mtbSearchAge.Text, out ushort parsedAge) ? parsedAge : (ushort?)null;
        _currentFilter = PersonFilterDTO.Create(txtSearchFirstName.Text, age, mtbSearchCPF.Text);
        LoadPersons(_currentFilter);
    }

    private void EditMenuItem_Click(object sender, EventArgs e)
    {
        var person = GetSelectedPerson();
        if (person != null)
            ShowEditForm(person);
    }

    private void ShowEditForm(Person person)
    {
        if (_formEdit == null)
        {
            _formEdit = new FormEdit(person, _personService, _addressService);
            _formEdit.FormClosed += (sender, e) => _formEdit = null;
            _formEdit.MdiParent = ParentForm;
            _formEdit.Dock = DockStyle.Fill;
            _formEdit.Show();
        }
        else
        {
            _formEdit.Activate();
        }
    }

    private void DeleteMenuItem_Click(object sender, EventArgs e)
    {
        var person = GetSelectedPerson();
        if (person != null && ConfirmDeletePerson(person))
        {
            _personService.Delete(person.Id);
            _addressService.DeleteByPersonId(person.Id);
            LoadPersons(_currentFilter);
        }
    }

    private static bool ConfirmDeletePerson(Person person)
    {
        DialogResult result = MessageBox.Show($"Tem certeza de que deseja excluir {person.FullName}?",
                                              $"Confirmar Exclusão da Pessoa {person.Id}",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
        return result == DialogResult.Yes;
    }

    private Person? GetSelectedPerson()
    {
        if (dgvPerson.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = dgvPerson.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            return _personService.GetById(id);
        }
        else
        {
            MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
    }

    private ContextMenuStrip ContextMenu
    {
        get
        {
            ContextMenuStrip contextMenuStrip = new();
            ToolStripMenuItem editMenuItem = new("Editar");
            ToolStripMenuItem deleteMenuItem = new("Excluir");

            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            contextMenuStrip.Items.Add(editMenuItem);
            contextMenuStrip.Items.Add(deleteMenuItem);
            return contextMenuStrip;
        }
    }
}