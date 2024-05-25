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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        customPanel1 = new CustomPanel();
        dgvPerson = new DataGridView();
        Id = new DataGridViewTextBoxColumn();
        FirstName = new DataGridViewTextBoxColumn();
        LastName = new DataGridViewTextBoxColumn();
        Age = new DataGridViewTextBoxColumn();
        Phone = new DataGridViewTextBoxColumn();
        Email = new DataGridViewTextBoxColumn();
        CPF = new DataGridViewTextBoxColumn();
        customPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
        SuspendLayout();
        // 
        // customPanel1
        // 
        customPanel1.BackColor = Color.White;
        customPanel1.BorderRadius = 20;
        customPanel1.Controls.Add(dgvPerson);
        customPanel1.Dock = DockStyle.Fill;
        customPanel1.ForeColor = Color.FromArgb(100, 150, 200);
        customPanel1.GradientAngle = 90F;
        customPanel1.GradientButtomColor = Color.Violet;
        customPanel1.GradientTopColor = Color.DarkViolet;
        customPanel1.Location = new Point(5, 5);
        customPanel1.Name = "customPanel1";
        customPanel1.Padding = new Padding(4, 0, 4, 15);
        customPanel1.Size = new Size(794, 620);
        customPanel1.TabIndex = 0;
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
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = Color.DarkViolet;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
        dataGridViewCellStyle1.SelectionBackColor = Color.DarkViolet;
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvPerson.ColumnHeadersHeight = 35;
        dgvPerson.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Age, Phone, Email, CPF });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 150, 200);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvPerson.DefaultCellStyle = dataGridViewCellStyle2;
        dgvPerson.Dock = DockStyle.Fill;
        dgvPerson.EnableHeadersVisualStyles = false;
        dgvPerson.GridColor = Color.LightGray;
        dgvPerson.Location = new Point(4, 0);
        dgvPerson.MultiSelect = false;
        dgvPerson.Name = "dgvPerson";
        dgvPerson.ReadOnly = true;
        dgvPerson.RowHeadersVisible = false;
        dgvPerson.RowHeadersWidth = 25;
        dgvPerson.RowTemplate.DividerHeight = 1;
        dgvPerson.RowTemplate.Height = 25;
        dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPerson.Size = new Size(786, 605);
        dgvPerson.TabIndex = 0;
        // 
        // Id
        // 
        Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Id.FillWeight = 80F;
        Id.HeaderText = "ID";
        Id.MinimumWidth = 80;
        Id.Name = "Id";
        Id.ReadOnly = true;
        // 
        // FirstName
        // 
        FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        FirstName.FillWeight = 150F;
        FirstName.HeaderText = "Nome";
        FirstName.MinimumWidth = 100;
        FirstName.Name = "FirstName";
        FirstName.ReadOnly = true;
        // 
        // LastName
        // 
        LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        LastName.FillWeight = 150F;
        LastName.HeaderText = "Sobrenome";
        LastName.MinimumWidth = 100;
        LastName.Name = "LastName";
        LastName.ReadOnly = true;
        // 
        // Age
        // 
        Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Age.FillWeight = 150F;
        Age.HeaderText = "Idade";
        Age.MinimumWidth = 100;
        Age.Name = "Age";
        Age.ReadOnly = true;
        // 
        // Phone
        // 
        Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Phone.FillWeight = 150F;
        Phone.HeaderText = "Telefone";
        Phone.MinimumWidth = 100;
        Phone.Name = "Phone";
        Phone.ReadOnly = true;
        // 
        // Email
        // 
        Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Email.FillWeight = 150F;
        Email.HeaderText = "E-mail";
        Email.MinimumWidth = 100;
        Email.Name = "Email";
        Email.ReadOnly = true;
        // 
        // CPF
        // 
        CPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        CPF.FillWeight = 150F;
        CPF.HeaderText = "CPF";
        CPF.MinimumWidth = 100;
        CPF.Name = "CPF";
        CPF.ReadOnly = true;
        // 
        // FormList
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(196, 210, 245);
        ClientSize = new Size(804, 630);
        Controls.Add(customPanel1);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(804, 630);
        Name = "FormList";
        Padding = new Padding(5);
        Text = "formList";
        Load += FormList_Load;
        customPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private CustomPanel customPanel1;
    private DataGridView dgvPerson;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn FirstName;
    private DataGridViewTextBoxColumn LastName;
    private DataGridViewTextBoxColumn Age;
    private DataGridViewTextBoxColumn Phone;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn CPF;
}