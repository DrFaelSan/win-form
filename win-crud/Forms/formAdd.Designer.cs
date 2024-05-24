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
        lblTitle = new Label();
        btnSave = new Button();
        gpPersonRegister = new GroupBox();
        txtEmail = new TextBox();
        label2 = new Label();
        label8 = new Label();
        label4 = new Label();
        txtLastName = new TextBox();
        label6 = new Label();
        label3 = new Label();
        label7 = new Label();
        mtbDocument = new MaskedTextBox();
        txtName = new TextBox();
        mtbPhone = new MaskedTextBox();
        mtbAge = new MaskedTextBox();
        gpAddresRegister = new GroupBox();
        txtNumber = new TextBox();
        lblNumber = new Label();
        txtUF = new TextBox();
        label1 = new Label();
        txtState = new TextBox();
        lblState = new Label();
        txtCity = new TextBox();
        lblCity = new Label();
        txtStreet = new TextBox();
        lblStreet = new Label();
        lblZipCode = new Label();
        mtbZipCode = new MaskedTextBox();
        gpPersonRegister.SuspendLayout();
        gpAddresRegister.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.Top;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        lblTitle.Location = new Point(265, 9);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(274, 38);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Cadastro de Pessoa";
        // 
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Bottom;
        btnSave.Location = new Point(265, 543);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(274, 57);
        btnSave.TabIndex = 17;
        btnSave.Text = "Salvar";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // gpPersonRegister
        // 
        gpPersonRegister.Anchor = AnchorStyles.Top;
        gpPersonRegister.Controls.Add(txtEmail);
        gpPersonRegister.Controls.Add(label2);
        gpPersonRegister.Controls.Add(label8);
        gpPersonRegister.Controls.Add(label4);
        gpPersonRegister.Controls.Add(txtLastName);
        gpPersonRegister.Controls.Add(label6);
        gpPersonRegister.Controls.Add(label3);
        gpPersonRegister.Controls.Add(label7);
        gpPersonRegister.Controls.Add(mtbDocument);
        gpPersonRegister.Controls.Add(txtName);
        gpPersonRegister.Controls.Add(mtbPhone);
        gpPersonRegister.Controls.Add(mtbAge);
        gpPersonRegister.Location = new Point(24, 50);
        gpPersonRegister.Name = "gpPersonRegister";
        gpPersonRegister.Size = new Size(409, 475);
        gpPersonRegister.TabIndex = 18;
        gpPersonRegister.TabStop = false;
        gpPersonRegister.Text = "Dados";
        // 
        // txtEmail
        // 
        txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtEmail.Location = new Point(17, 199);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "Digite seu e-mail";
        txtEmail.Size = new Size(243, 27);
        txtEmail.TabIndex = 30;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 40);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 19;
        label2.Text = "Nome";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(17, 176);
        label8.Name = "label8";
        label8.Size = new Size(52, 20);
        label8.TabIndex = 29;
        label8.Text = "E-mail";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(17, 239);
        label4.Name = "label4";
        label4.Size = new Size(47, 20);
        label4.TabIndex = 20;
        label4.Text = "Idade";
        // 
        // txtLastName
        // 
        txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLastName.Location = new Point(17, 133);
        txtLastName.Name = "txtLastName";
        txtLastName.PlaceholderText = "Digite seu sobrenome";
        txtLastName.Size = new Size(243, 27);
        txtLastName.TabIndex = 28;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(17, 309);
        label6.Name = "label6";
        label6.Size = new Size(66, 20);
        label6.TabIndex = 21;
        label6.Text = "Telefone";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 110);
        label3.Name = "label3";
        label3.Size = new Size(86, 20);
        label3.TabIndex = 27;
        label3.Text = "Sobrenome";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(18, 380);
        label7.Name = "label7";
        label7.Size = new Size(33, 20);
        label7.TabIndex = 22;
        label7.Text = "CPF";
        // 
        // mtbDocument
        // 
        mtbDocument.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        mtbDocument.Location = new Point(18, 403);
        mtbDocument.Mask = "000.000.000-00";
        mtbDocument.Name = "mtbDocument";
        mtbDocument.Size = new Size(125, 27);
        mtbDocument.TabIndex = 26;
        // 
        // txtName
        // 
        txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtName.Location = new Point(17, 63);
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Digite seu nome";
        txtName.Size = new Size(243, 27);
        txtName.TabIndex = 23;
        // 
        // mtbPhone
        // 
        mtbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        mtbPhone.Location = new Point(18, 332);
        mtbPhone.Mask = "(00) 00000-0000";
        mtbPhone.Name = "mtbPhone";
        mtbPhone.Size = new Size(125, 27);
        mtbPhone.TabIndex = 25;
        // 
        // mtbAge
        // 
        mtbAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        mtbAge.Location = new Point(17, 262);
        mtbAge.Mask = "00";
        mtbAge.Name = "mtbAge";
        mtbAge.Size = new Size(33, 27);
        mtbAge.TabIndex = 24;
        mtbAge.TextAlign = HorizontalAlignment.Center;
        // 
        // gpAddresRegister
        // 
        gpAddresRegister.Anchor = AnchorStyles.Top;
        gpAddresRegister.Controls.Add(txtNumber);
        gpAddresRegister.Controls.Add(lblNumber);
        gpAddresRegister.Controls.Add(txtUF);
        gpAddresRegister.Controls.Add(label1);
        gpAddresRegister.Controls.Add(txtState);
        gpAddresRegister.Controls.Add(lblState);
        gpAddresRegister.Controls.Add(txtCity);
        gpAddresRegister.Controls.Add(lblCity);
        gpAddresRegister.Controls.Add(txtStreet);
        gpAddresRegister.Controls.Add(lblStreet);
        gpAddresRegister.Controls.Add(lblZipCode);
        gpAddresRegister.Controls.Add(mtbZipCode);
        gpAddresRegister.Location = new Point(458, 50);
        gpAddresRegister.Name = "gpAddresRegister";
        gpAddresRegister.Size = new Size(306, 475);
        gpAddresRegister.TabIndex = 19;
        gpAddresRegister.TabStop = false;
        gpAddresRegister.Text = "Endereço";
        // 
        // txtNumber
        // 
        txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNumber.Location = new Point(17, 403);
        txtNumber.Name = "txtNumber";
        txtNumber.Size = new Size(243, 27);
        txtNumber.TabIndex = 36;
        txtNumber.TextAlign = HorizontalAlignment.Center;
        // 
        // lblNumber
        // 
        lblNumber.AutoSize = true;
        lblNumber.Location = new Point(17, 380);
        lblNumber.Name = "lblNumber";
        lblNumber.Size = new Size(63, 20);
        lblNumber.TabIndex = 35;
        lblNumber.Text = "Número";
        // 
        // txtUF
        // 
        txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtUF.Location = new Point(18, 338);
        txtUF.Name = "txtUF";
        txtUF.Size = new Size(75, 27);
        txtUF.TabIndex = 34;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 315);
        label1.Name = "label1";
        label1.Size = new Size(26, 20);
        label1.TabIndex = 33;
        label1.Text = "UF";
        // 
        // txtState
        // 
        txtState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtState.Location = new Point(18, 272);
        txtState.Name = "txtState";
        txtState.PlaceholderText = "Digite seu estado";
        txtState.Size = new Size(243, 27);
        txtState.TabIndex = 32;
        // 
        // lblState
        // 
        lblState.AutoSize = true;
        lblState.Location = new Point(18, 249);
        lblState.Name = "lblState";
        lblState.Size = new Size(54, 20);
        lblState.TabIndex = 31;
        lblState.Text = "Estado";
        // 
        // txtCity
        // 
        txtCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCity.Location = new Point(17, 199);
        txtCity.Name = "txtCity";
        txtCity.PlaceholderText = "Digite sua cidade";
        txtCity.Size = new Size(243, 27);
        txtCity.TabIndex = 30;
        // 
        // lblCity
        // 
        lblCity.AutoSize = true;
        lblCity.Location = new Point(17, 176);
        lblCity.Name = "lblCity";
        lblCity.Size = new Size(56, 20);
        lblCity.TabIndex = 29;
        lblCity.Text = "Cidade";
        // 
        // txtStreet
        // 
        txtStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtStreet.Location = new Point(17, 133);
        txtStreet.Name = "txtStreet";
        txtStreet.PlaceholderText = "Digite seu endereço";
        txtStreet.Size = new Size(243, 27);
        txtStreet.TabIndex = 28;
        // 
        // lblStreet
        // 
        lblStreet.AutoSize = true;
        lblStreet.Location = new Point(17, 110);
        lblStreet.Name = "lblStreet";
        lblStreet.Size = new Size(95, 20);
        lblStreet.TabIndex = 27;
        lblStreet.Text = "Lougradouro";
        // 
        // lblZipCode
        // 
        lblZipCode.AutoSize = true;
        lblZipCode.Location = new Point(18, 40);
        lblZipCode.Name = "lblZipCode";
        lblZipCode.Size = new Size(34, 20);
        lblZipCode.TabIndex = 22;
        lblZipCode.Text = "CEP";
        // 
        // mtbZipCode
        // 
        mtbZipCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        mtbZipCode.Location = new Point(18, 63);
        mtbZipCode.Mask = "00000-000";
        mtbZipCode.Name = "mtbZipCode";
        mtbZipCode.Size = new Size(104, 27);
        mtbZipCode.TabIndex = 26;
        mtbZipCode.TextAlign = HorizontalAlignment.Center;
        // 
        // FormAdd
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(804, 630);
        Controls.Add(gpAddresRegister);
        Controls.Add(gpPersonRegister);
        Controls.Add(btnSave);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(804, 630);
        Name = "FormAdd";
        Text = "formAdd";
        TransparencyKey = Color.White;
        Load += formAdd_Load;
        gpPersonRegister.ResumeLayout(false);
        gpPersonRegister.PerformLayout();
        gpAddresRegister.ResumeLayout(false);
        gpAddresRegister.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Button btnSave;
    private GroupBox gpPersonRegister;
    private TextBox txtEmail;
    private Label label2;
    private Label label8;
    private Label label4;
    private TextBox txtLastName;
    private Label label6;
    private Label label3;
    private Label label7;
    private MaskedTextBox mtbDocument;
    private TextBox txtName;
    private MaskedTextBox mtbPhone;
    private MaskedTextBox mtbAge;
    private GroupBox gpAddresRegister;
    private TextBox txtCity;
    private Label lblCity;
    private TextBox txtStreet;
    private Label lblStreet;
    private Label lblZipCode;
    private MaskedTextBox mtbZipCode;
    private TextBox txtUF;
    private Label label1;
    private TextBox txtState;
    private Label lblState;
    private TextBox txtNumber;
    private Label lblNumber;
}