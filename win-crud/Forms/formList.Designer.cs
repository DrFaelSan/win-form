namespace win_crud.Forms;

partial class FormList
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
        dgvPerson = new DataGridView();
        Id = new DataGridViewTextBoxColumn();
        FirstName = new DataGridViewTextBoxColumn();
        LastName = new DataGridViewTextBoxColumn();
        Age = new DataGridViewTextBoxColumn();
        Phone = new DataGridViewTextBoxColumn();
        Email = new DataGridViewTextBoxColumn();
        CPF = new DataGridViewTextBoxColumn();
        plList = new Panel();
        plFiltro = new Panel();
        mtbSearchAge = new MaskedTextBox();
        lblAge = new Label();
        mtbSearchCPF = new MaskedTextBox();
        lblCPF = new Label();
        lblFirstName = new Label();
        txtSearchFirstName = new TextBox();
        lblFilter = new Label();
        btnSearch = new PictureBox();
        btnReport = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
        plList.SuspendLayout();
        plFiltro.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
        ((System.ComponentModel.ISupportInitialize)btnReport).BeginInit();
        SuspendLayout();
        // 
        // dgvPerson
        // 
        dgvPerson.AllowUserToAddRows = false;
        dgvPerson.AllowUserToDeleteRows = false;
        dgvPerson.AllowUserToOrderColumns = true;
        dgvPerson.AllowUserToResizeColumns = false;
        dgvPerson.AllowUserToResizeRows = false;
        dgvPerson.BackgroundColor = Color.White;
        dgvPerson.BorderStyle = BorderStyle.None;
        dgvPerson.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgvPerson.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 128, 255);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(235, 230, 255);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 230, 255);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvPerson.ColumnHeadersHeight = 35;
        dgvPerson.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Age, Phone, Email, CPF });
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.BackColor = Color.White;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(235, 230, 255);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(100, 100, 180);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvPerson.DefaultCellStyle = dataGridViewCellStyle4;
        dgvPerson.Dock = DockStyle.Fill;
        dgvPerson.EnableHeadersVisualStyles = false;
        dgvPerson.GridColor = Color.LightGray;
        dgvPerson.Location = new Point(0, 0);
        dgvPerson.MultiSelect = false;
        dgvPerson.Name = "dgvPerson";
        dgvPerson.ReadOnly = true;
        dgvPerson.RowHeadersVisible = false;
        dgvPerson.RowHeadersWidth = 25;
        dgvPerson.RowTemplate.DividerHeight = 1;
        dgvPerson.RowTemplate.Height = 25;
        dgvPerson.RowTemplate.Resizable = DataGridViewTriState.True;
        dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPerson.Size = new Size(786, 501);
        dgvPerson.TabIndex = 0;
        // 
        // Id
        // 
        Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Id.HeaderText = "ID";
        Id.MinimumWidth = 6;
        Id.Name = "Id";
        Id.ReadOnly = true;
        // 
        // FirstName
        // 
        FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        FirstName.HeaderText = "Nome";
        FirstName.MinimumWidth = 6;
        FirstName.Name = "FirstName";
        FirstName.ReadOnly = true;
        // 
        // LastName
        // 
        LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        LastName.HeaderText = "Sobrenome";
        LastName.MinimumWidth = 6;
        LastName.Name = "LastName";
        LastName.ReadOnly = true;
        // 
        // Age
        // 
        Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Age.HeaderText = "Idade";
        Age.MinimumWidth = 6;
        Age.Name = "Age";
        Age.ReadOnly = true;
        // 
        // Phone
        // 
        Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Phone.HeaderText = "Telefone";
        Phone.MinimumWidth = 6;
        Phone.Name = "Phone";
        Phone.ReadOnly = true;
        // 
        // Email
        // 
        Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Email.HeaderText = "E-mail";
        Email.MinimumWidth = 6;
        Email.Name = "Email";
        Email.ReadOnly = true;
        // 
        // CPF
        // 
        CPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        CPF.HeaderText = "CPF";
        CPF.MinimumWidth = 6;
        CPF.Name = "CPF";
        CPF.ReadOnly = true;
        // 
        // plList
        // 
        plList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        plList.Controls.Add(dgvPerson);
        plList.Location = new Point(9, 120);
        plList.Margin = new Padding(0);
        plList.MinimumSize = new Size(720, 100);
        plList.Name = "plList";
        plList.Size = new Size(786, 501);
        plList.TabIndex = 1;
        // 
        // plFiltro
        // 
        plFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        plFiltro.BackColor = Color.FromArgb(128, 128, 255);
        plFiltro.Controls.Add(mtbSearchAge);
        plFiltro.Controls.Add(lblAge);
        plFiltro.Controls.Add(mtbSearchCPF);
        plFiltro.Controls.Add(lblCPF);
        plFiltro.Controls.Add(lblFirstName);
        plFiltro.Controls.Add(txtSearchFirstName);
        plFiltro.Controls.Add(lblFilter);
        plFiltro.Location = new Point(9, 9);
        plFiltro.Margin = new Padding(0);
        plFiltro.Name = "plFiltro";
        plFiltro.Size = new Size(447, 100);
        plFiltro.TabIndex = 2;
        // 
        // mtbSearchAge
        // 
        mtbSearchAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        mtbSearchAge.Cursor = Cursors.Hand;
        mtbSearchAge.Location = new Point(352, 68);
        mtbSearchAge.Mask = "00";
        mtbSearchAge.Name = "mtbSearchAge";
        mtbSearchAge.Size = new Size(53, 27);
        mtbSearchAge.TabIndex = 87;
        mtbSearchAge.TextAlign = HorizontalAlignment.Center;
        // 
        // lblAge
        // 
        lblAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblAge.AutoSize = true;
        lblAge.BackColor = Color.Transparent;
        lblAge.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        lblAge.ForeColor = Color.White;
        lblAge.Location = new Point(352, 39);
        lblAge.Name = "lblAge";
        lblAge.Size = new Size(53, 23);
        lblAge.TabIndex = 88;
        lblAge.Text = "Idade";
        // 
        // mtbSearchCPF
        // 
        mtbSearchCPF.Cursor = Cursors.Hand;
        mtbSearchCPF.Location = new Point(213, 68);
        mtbSearchCPF.Mask = "000.000.000-00";
        mtbSearchCPF.Name = "mtbSearchCPF";
        mtbSearchCPF.Size = new Size(125, 27);
        mtbSearchCPF.TabIndex = 85;
        mtbSearchCPF.TextAlign = HorizontalAlignment.Center;
        // 
        // lblCPF
        // 
        lblCPF.AutoSize = true;
        lblCPF.BackColor = Color.Transparent;
        lblCPF.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        lblCPF.ForeColor = Color.White;
        lblCPF.Location = new Point(213, 39);
        lblCPF.Name = "lblCPF";
        lblCPF.Size = new Size(40, 23);
        lblCPF.TabIndex = 86;
        lblCPF.Text = "CPF";
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.BackColor = Color.Transparent;
        lblFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        lblFirstName.ForeColor = Color.White;
        lblFirstName.Location = new Point(23, 39);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(57, 23);
        lblFirstName.TabIndex = 84;
        lblFirstName.Text = "Nome";
        // 
        // txtSearchFirstName
        // 
        txtSearchFirstName.Cursor = Cursors.Hand;
        txtSearchFirstName.Location = new Point(23, 68);
        txtSearchFirstName.Name = "txtSearchFirstName";
        txtSearchFirstName.PlaceholderText = "Pequise o nome";
        txtSearchFirstName.Size = new Size(180, 27);
        txtSearchFirstName.TabIndex = 83;
        // 
        // lblFilter
        // 
        lblFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblFilter.AutoSize = true;
        lblFilter.BackColor = Color.Transparent;
        lblFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
        lblFilter.ForeColor = Color.White;
        lblFilter.Location = new Point(16, 14);
        lblFilter.Margin = new Padding(0);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new Size(64, 25);
        lblFilter.TabIndex = 82;
        lblFilter.Text = "Filtros";
        // 
        // btnSearch
        // 
        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSearch.Cursor = Cursors.Hand;
        btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
        btnSearch.Location = new Point(469, 67);
        btnSearch.Margin = new Padding(0);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(60, 42);
        btnSearch.SizeMode = PictureBoxSizeMode.CenterImage;
        btnSearch.TabIndex = 89;
        btnSearch.TabStop = false;
        btnSearch.Click += BtnSearch_Click;
        // 
        // btnReport
        // 
        btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnReport.Cursor = Cursors.Hand;
        btnReport.Image = (Image)resources.GetObject("btnReport.Image");
        btnReport.Location = new Point(469, 9);
        btnReport.Margin = new Padding(0);
        btnReport.Name = "btnReport";
        btnReport.Size = new Size(60, 42);
        btnReport.SizeMode = PictureBoxSizeMode.CenterImage;
        btnReport.TabIndex = 90;
        btnReport.TabStop = false;
        btnReport.Click += BtnReport_Click;
        // 
        // FormList
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(196, 210, 245);
        ClientSize = new Size(804, 630);
        Controls.Add(btnReport);
        Controls.Add(btnSearch);
        Controls.Add(plFiltro);
        Controls.Add(plList);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(804, 600);
        Name = "FormList";
        Text = "formList";
        Load += FormList_Load;
        ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
        plList.ResumeLayout(false);
        plFiltro.ResumeLayout(false);
        plFiltro.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
        ((System.ComponentModel.ISupportInitialize)btnReport).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dgvPerson;
    private Panel plList;
    private Panel plFiltro;
    private Label lblFirstName;
    private TextBox txtSearchFirstName;
    private MaskedTextBox mtbSearchCPF;
    private Label lblCPF;
    private MaskedTextBox mtbSearchAge;
    private Label lblAge;
    private PictureBox btnSearch;
    private PictureBox btnReport;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn FirstName;
    private DataGridViewTextBoxColumn LastName;
    private DataGridViewTextBoxColumn Age;
    private DataGridViewTextBoxColumn Phone;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn CPF;
    private Label lblFilter;
}