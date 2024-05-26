namespace win_crud.Forms;

partial class FormAdd
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
        panel1 = new Panel();
        btnSave = new Button();
        lblSubTitle2 = new Label();
        lblSubTitle = new Label();
        mtbCelPhone = new MaskedTextBox();
        mtbPhone = new MaskedTextBox();
        txtCountry = new TextBox();
        lblCountry = new Label();
        txtNumber = new TextBox();
        lblNumber = new Label();
        txtUF = new TextBox();
        lblUF = new Label();
        txtState = new TextBox();
        lblState = new Label();
        txtCity = new TextBox();
        lblCity = new Label();
        txtStreet = new TextBox();
        lblStreet = new Label();
        lblZipCode = new Label();
        mtbZipCode = new MaskedTextBox();
        label17 = new Label();
        lblCelPhone = new Label();
        lblFirstName = new Label();
        txtEmail = new TextBox();
        mtbAge = new MaskedTextBox();
        lblEmail = new Label();
        txtFirstName = new TextBox();
        lblAge = new Label();
        mtbCPF = new MaskedTextBox();
        txtLastName = new TextBox();
        lblCPF = new Label();
        lblPhone = new Label();
        lblLastName = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(128, 128, 255);
        panel1.Controls.Add(btnSave);
        panel1.Controls.Add(lblSubTitle2);
        panel1.Controls.Add(lblSubTitle);
        panel1.Controls.Add(mtbCelPhone);
        panel1.Controls.Add(mtbPhone);
        panel1.Controls.Add(txtCountry);
        panel1.Controls.Add(lblCountry);
        panel1.Controls.Add(txtNumber);
        panel1.Controls.Add(lblNumber);
        panel1.Controls.Add(txtUF);
        panel1.Controls.Add(lblUF);
        panel1.Controls.Add(txtState);
        panel1.Controls.Add(lblState);
        panel1.Controls.Add(txtCity);
        panel1.Controls.Add(lblCity);
        panel1.Controls.Add(txtStreet);
        panel1.Controls.Add(lblStreet);
        panel1.Controls.Add(lblZipCode);
        panel1.Controls.Add(mtbZipCode);
        panel1.Controls.Add(label17);
        panel1.Controls.Add(lblCelPhone);
        panel1.Controls.Add(lblFirstName);
        panel1.Controls.Add(txtEmail);
        panel1.Controls.Add(mtbAge);
        panel1.Controls.Add(lblEmail);
        panel1.Controls.Add(txtFirstName);
        panel1.Controls.Add(lblAge);
        panel1.Controls.Add(mtbCPF);
        panel1.Controls.Add(txtLastName);
        panel1.Controls.Add(lblCPF);
        panel1.Controls.Add(lblPhone);
        panel1.Controls.Add(lblLastName);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(5, 5);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(794, 570);
        panel1.TabIndex = 37;
        // 
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnSave.BackColor = Color.FromArgb(196, 210, 245);
        btnSave.Cursor = Cursors.Hand;
        btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(241, 478);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(312, 56);
        btnSave.TabIndex = 15;
        btnSave.Text = "Salvar";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += BtnSave_Click;
        // 
        // lblSubTitle2
        // 
        lblSubTitle2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblSubTitle2.AutoSize = true;
        lblSubTitle2.BackColor = Color.Transparent;
        lblSubTitle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
        lblSubTitle2.ForeColor = Color.White;
        lblSubTitle2.Location = new Point(46, 293);
        lblSubTitle2.Margin = new Padding(0);
        lblSubTitle2.Name = "lblSubTitle2";
        lblSubTitle2.Size = new Size(91, 25);
        lblSubTitle2.TabIndex = 82;
        lblSubTitle2.Text = "Endereço";
        // 
        // lblSubTitle
        // 
        lblSubTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblSubTitle.AutoSize = true;
        lblSubTitle.BackColor = Color.Transparent;
        lblSubTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
        lblSubTitle.ForeColor = Color.White;
        lblSubTitle.Location = new Point(47, 59);
        lblSubTitle.Margin = new Padding(0);
        lblSubTitle.Name = "lblSubTitle";
        lblSubTitle.Size = new Size(141, 25);
        lblSubTitle.TabIndex = 81;
        lblSubTitle.Text = "Dados pessoais";
        // 
        // mtbCelPhone
        // 
        mtbCelPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mtbCelPhone.Cursor = Cursors.Hand;
        mtbCelPhone.Location = new Point(398, 186);
        mtbCelPhone.Mask = "(99) 00000-0000";
        mtbCelPhone.Name = "mtbCelPhone";
        mtbCelPhone.Size = new Size(380, 27);
        mtbCelPhone.TabIndex = 4;
        mtbCelPhone.TextAlign = HorizontalAlignment.Center;
        // 
        // mtbPhone
        // 
        mtbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        mtbPhone.Cursor = Cursors.Hand;
        mtbPhone.Location = new Point(46, 252);
        mtbPhone.Mask = "(00) 0000-0000";
        mtbPhone.Name = "mtbPhone";
        mtbPhone.Size = new Size(113, 27);
        mtbPhone.TabIndex = 5;
        // 
        // txtCountry
        // 
        txtCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtCountry.Cursor = Cursors.Hand;
        txtCountry.Location = new Point(548, 356);
        txtCountry.Name = "txtCountry";
        txtCountry.PlaceholderText = "Digite seu país de origem";
        txtCountry.Size = new Size(227, 27);
        txtCountry.TabIndex = 10;
        // 
        // lblCountry
        // 
        lblCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblCountry.AutoSize = true;
        lblCountry.BackColor = Color.Transparent;
        lblCountry.ForeColor = Color.LightGray;
        lblCountry.Location = new Point(548, 333);
        lblCountry.Name = "lblCountry";
        lblCountry.Size = new Size(34, 20);
        lblCountry.TabIndex = 77;
        lblCountry.Text = "País";
        // 
        // txtNumber
        // 
        txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtNumber.Cursor = Cursors.Hand;
        txtNumber.Location = new Point(671, 425);
        txtNumber.Name = "txtNumber";
        txtNumber.PlaceholderText = "ex.: 123";
        txtNumber.Size = new Size(104, 27);
        txtNumber.TabIndex = 14;
        txtNumber.TextAlign = HorizontalAlignment.Center;
        // 
        // lblNumber
        // 
        lblNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblNumber.AutoSize = true;
        lblNumber.BackColor = Color.Transparent;
        lblNumber.ForeColor = Color.LightGray;
        lblNumber.Location = new Point(671, 399);
        lblNumber.Name = "lblNumber";
        lblNumber.Size = new Size(63, 20);
        lblNumber.TabIndex = 76;
        lblNumber.Text = "Número";
        // 
        // txtUF
        // 
        txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        txtUF.Cursor = Cursors.Hand;
        txtUF.Location = new Point(548, 425);
        txtUF.Name = "txtUF";
        txtUF.PlaceholderText = "ex.: SP";
        txtUF.Size = new Size(94, 27);
        txtUF.TabIndex = 13;
        txtUF.TextAlign = HorizontalAlignment.Center;
        // 
        // lblUF
        // 
        lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblUF.AutoSize = true;
        lblUF.BackColor = Color.Transparent;
        lblUF.ForeColor = Color.LightGray;
        lblUF.Location = new Point(548, 399);
        lblUF.Name = "lblUF";
        lblUF.Size = new Size(26, 20);
        lblUF.TabIndex = 74;
        lblUF.Text = "UF";
        // 
        // txtState
        // 
        txtState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        txtState.Cursor = Cursors.Hand;
        txtState.Location = new Point(298, 425);
        txtState.Name = "txtState";
        txtState.PlaceholderText = "Digite seu estado";
        txtState.Size = new Size(233, 27);
        txtState.TabIndex = 12;
        // 
        // lblState
        // 
        lblState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblState.AutoSize = true;
        lblState.BackColor = Color.Transparent;
        lblState.ForeColor = Color.LightGray;
        lblState.Location = new Point(299, 399);
        lblState.Name = "lblState";
        lblState.Size = new Size(60, 20);
        lblState.TabIndex = 70;
        lblState.Text = "Estado*";
        // 
        // txtCity
        // 
        txtCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        txtCity.Cursor = Cursors.Hand;
        txtCity.Location = new Point(44, 425);
        txtCity.Name = "txtCity";
        txtCity.PlaceholderText = "Digite sua cidade";
        txtCity.Size = new Size(237, 27);
        txtCity.TabIndex = 11;
        // 
        // lblCity
        // 
        lblCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblCity.AutoSize = true;
        lblCity.BackColor = Color.Transparent;
        lblCity.ForeColor = Color.LightGray;
        lblCity.Location = new Point(45, 399);
        lblCity.Name = "lblCity";
        lblCity.Size = new Size(62, 20);
        lblCity.TabIndex = 67;
        lblCity.Text = "Cidade*";
        // 
        // txtStreet
        // 
        txtStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        txtStreet.Cursor = Cursors.Hand;
        txtStreet.Location = new Point(297, 356);
        txtStreet.Name = "txtStreet";
        txtStreet.PlaceholderText = "Digite seu endereço";
        txtStreet.Size = new Size(234, 27);
        txtStreet.TabIndex = 9;
        // 
        // lblStreet
        // 
        lblStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblStreet.AutoSize = true;
        lblStreet.BackColor = Color.Transparent;
        lblStreet.ForeColor = Color.LightGray;
        lblStreet.Location = new Point(299, 333);
        lblStreet.Name = "lblStreet";
        lblStreet.Size = new Size(101, 20);
        lblStreet.TabIndex = 66;
        lblStreet.Text = "Lougradouro*";
        // 
        // lblZipCode
        // 
        lblZipCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblZipCode.AutoSize = true;
        lblZipCode.BackColor = Color.Transparent;
        lblZipCode.ForeColor = Color.LightGray;
        lblZipCode.Location = new Point(45, 333);
        lblZipCode.Name = "lblZipCode";
        lblZipCode.Size = new Size(40, 20);
        lblZipCode.TabIndex = 65;
        lblZipCode.Text = "CEP*";
        // 
        // mtbZipCode
        // 
        mtbZipCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        mtbZipCode.Cursor = Cursors.Hand;
        mtbZipCode.Location = new Point(44, 356);
        mtbZipCode.Mask = "00000-000";
        mtbZipCode.Name = "mtbZipCode";
        mtbZipCode.Size = new Size(237, 27);
        mtbZipCode.TabIndex = 8;
        mtbZipCode.TextAlign = HorizontalAlignment.Center;
        // 
        // label17
        // 
        label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label17.AutoSize = true;
        label17.BackColor = Color.Transparent;
        label17.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
        label17.ForeColor = Color.White;
        label17.Location = new Point(264, 16);
        label17.Margin = new Padding(0);
        label17.Name = "label17";
        label17.Size = new Size(267, 38);
        label17.TabIndex = 50;
        label17.Text = "Cadastro de Pessoa";
        // 
        // lblCelPhone
        // 
        lblCelPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblCelPhone.AutoSize = true;
        lblCelPhone.BackColor = Color.Transparent;
        lblCelPhone.ForeColor = Color.LightGray;
        lblCelPhone.Location = new Point(400, 163);
        lblCelPhone.Name = "lblCelPhone";
        lblCelPhone.Size = new Size(116, 20);
        lblCelPhone.TabIndex = 63;
        lblCelPhone.Text = "Telefone Celular";
        // 
        // lblFirstName
        // 
        lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblFirstName.AutoSize = true;
        lblFirstName.BackColor = Color.Transparent;
        lblFirstName.ForeColor = Color.LightGray;
        lblFirstName.Location = new Point(47, 98);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(56, 20);
        lblFirstName.TabIndex = 51;
        lblFirstName.Text = "Nome*";
        // 
        // txtEmail
        // 
        txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        txtEmail.Cursor = Cursors.Hand;
        txtEmail.Location = new Point(46, 186);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "Digite seu e-mail";
        txtEmail.Size = new Size(332, 27);
        txtEmail.TabIndex = 3;
        // 
        // mtbAge
        // 
        mtbAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mtbAge.Cursor = Cursors.Hand;
        mtbAge.Location = new Point(398, 252);
        mtbAge.Mask = "00";
        mtbAge.Name = "mtbAge";
        mtbAge.Size = new Size(379, 27);
        mtbAge.TabIndex = 7;
        mtbAge.TextAlign = HorizontalAlignment.Center;
        // 
        // lblEmail
        // 
        lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblEmail.AutoSize = true;
        lblEmail.BackColor = Color.Transparent;
        lblEmail.ForeColor = Color.LightGray;
        lblEmail.Location = new Point(47, 163);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(52, 20);
        lblEmail.TabIndex = 61;
        lblEmail.Text = "E-mail";
        // 
        // txtFirstName
        // 
        txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        txtFirstName.Cursor = Cursors.Hand;
        txtFirstName.Location = new Point(46, 121);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.PlaceholderText = "Digite seu nome";
        txtFirstName.Size = new Size(332, 27);
        txtFirstName.TabIndex = 1;
        // 
        // lblAge
        // 
        lblAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblAge.AutoSize = true;
        lblAge.BackColor = Color.Transparent;
        lblAge.ForeColor = Color.LightGray;
        lblAge.Location = new Point(400, 229);
        lblAge.Name = "lblAge";
        lblAge.Size = new Size(47, 20);
        lblAge.TabIndex = 52;
        lblAge.Text = "Idade";
        // 
        // mtbCPF
        // 
        mtbCPF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        mtbCPF.Cursor = Cursors.Hand;
        mtbCPF.Location = new Point(182, 252);
        mtbCPF.Mask = "000.000.000-00";
        mtbCPF.Name = "mtbCPF";
        mtbCPF.Size = new Size(196, 27);
        mtbCPF.TabIndex = 6;
        mtbCPF.TextAlign = HorizontalAlignment.Center;
        // 
        // txtLastName
        // 
        txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtLastName.Cursor = Cursors.Hand;
        txtLastName.Location = new Point(399, 121);
        txtLastName.Name = "txtLastName";
        txtLastName.PlaceholderText = "Digite seu sobrenome";
        txtLastName.Size = new Size(379, 27);
        txtLastName.TabIndex = 2;
        // 
        // lblCPF
        // 
        lblCPF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblCPF.AutoSize = true;
        lblCPF.BackColor = Color.Transparent;
        lblCPF.ForeColor = Color.LightGray;
        lblCPF.Location = new Point(182, 229);
        lblCPF.Name = "lblCPF";
        lblCPF.Size = new Size(33, 20);
        lblCPF.TabIndex = 54;
        lblCPF.Text = "CPF";
        // 
        // lblPhone
        // 
        lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblPhone.AutoSize = true;
        lblPhone.BackColor = Color.Transparent;
        lblPhone.ForeColor = Color.LightGray;
        lblPhone.Location = new Point(47, 229);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(97, 20);
        lblPhone.TabIndex = 53;
        lblPhone.Text = "Telefone Fixo";
        // 
        // lblLastName
        // 
        lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblLastName.AutoSize = true;
        lblLastName.BackColor = Color.Transparent;
        lblLastName.ForeColor = Color.LightGray;
        lblLastName.Location = new Point(399, 98);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(92, 20);
        lblLastName.TabIndex = 59;
        lblLastName.Text = "Sobrenome*";
        // 
        // FormAdd
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(196, 210, 245);
        ClientSize = new Size(804, 580);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(804, 580);
        Name = "FormAdd";
        Padding = new Padding(5);
        Text = "formAdd";
        TransparencyKey = Color.White;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private TextBox txtCountry;
    private Label lblCountry;
    private TextBox txtNumber;
    private Label lblNumber;
    private TextBox txtUF;
    private Label lblUF;
    private TextBox txtState;
    private Label lblState;
    private TextBox txtCity;
    private Label lblCity;
    private TextBox txtStreet;
    private Label lblStreet;
    private Label lblZipCode;
    private MaskedTextBox mtbZipCode;
    private Label label17;
    private Label lblCelPhone;
    private Label lblFirstName;
    private TextBox txtEmail;
    private MaskedTextBox mtbAge;
    private Label lblEmail;
    private TextBox txtFirstName;
    private Label lblAge;
    private TextBox txtLastName;
    private Label lblPhone;
    private Label lblLastName;
    private MaskedTextBox mtbPhone;
    private MaskedTextBox mtbCPF;
    private Label lblCPF;
    private MaskedTextBox mtbCelPhone;
    private Label lblSubTitle;
    private Label lblSubTitle2;
    private Button btnSave;
}