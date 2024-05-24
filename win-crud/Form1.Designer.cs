namespace win_crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidebar = new FlowLayoutPanel();
            pnList = new Panel();
            btnList = new Button();
            pnAdd = new Panel();
            btnAdd = new Button();
            pnEdit = new Panel();
            btnEdit = new Button();
            pnDel = new Panel();
            btnDel = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnMenu = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            pnList.SuspendLayout();
            pnAdd.SuspendLayout();
            pnEdit.SuspendLayout();
            pnDel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.WindowText;
            sidebar.Controls.Add(pnList);
            sidebar.Controls.Add(pnAdd);
            sidebar.Controls.Add(pnEdit);
            sidebar.Controls.Add(pnDel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(250, 698);
            sidebar.TabIndex = 0;
            // 
            // pnList
            // 
            pnList.Controls.Add(btnList);
            pnList.Location = new Point(3, 3);
            pnList.Name = "pnList";
            pnList.Size = new Size(207, 39);
            pnList.TabIndex = 4;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.WindowText;
            btnList.ForeColor = Color.White;
            btnList.Image = (Image)resources.GetObject("btnList.Image");
            btnList.ImageAlign = ContentAlignment.MiddleLeft;
            btnList.Location = new Point(0, -13);
            btnList.Name = "btnList";
            btnList.Padding = new Padding(25, 5, 0, 0);
            btnList.Size = new Size(247, 66);
            btnList.TabIndex = 3;
            btnList.Text = "     Listar";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += BtnList_Click;
            // 
            // pnAdd
            // 
            pnAdd.Controls.Add(btnAdd);
            pnAdd.Location = new Point(3, 48);
            pnAdd.Name = "pnAdd";
            pnAdd.Size = new Size(207, 39);
            pnAdd.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.WindowText;
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(0, -15);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(25, 5, 0, 0);
            btnAdd.Size = new Size(247, 66);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "     Cadastrar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // pnEdit
            // 
            pnEdit.Controls.Add(btnEdit);
            pnEdit.Location = new Point(3, 93);
            pnEdit.Name = "pnEdit";
            pnEdit.Size = new Size(207, 39);
            pnEdit.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.WindowText;
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(0, -17);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(25, 5, 0, 0);
            btnEdit.Size = new Size(247, 66);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "     Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // pnDel
            // 
            pnDel.Controls.Add(btnDel);
            pnDel.Location = new Point(3, 138);
            pnDel.Name = "pnDel";
            pnDel.Size = new Size(207, 39);
            pnDel.TabIndex = 7;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.WindowText;
            btnDel.ForeColor = Color.White;
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(0, -14);
            btnDel.Name = "btnDel";
            btnDel.Padding = new Padding(25, 5, 0, 0);
            btnDel.Size = new Size(247, 66);
            btnDel.TabIndex = 3;
            btnDel.Text = "     Deletar";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += BtnDel_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnMenu);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(250, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(812, 52);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.None;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(64, 47);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += BtnMenu_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += SidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 698);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(sidebar);
            IsMdiContainer = true;
            MinimumSize = new Size(1080, 745);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WIN FORM CRUD";
            sidebar.ResumeLayout(false);
            pnList.ResumeLayout(false);
            pnAdd.ResumeLayout(false);
            pnEdit.ResumeLayout(false);
            pnDel.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnList;
        private Button btnList;
        private Panel pnAdd;
        private Button btnAdd;
        private Panel pnEdit;
        private Button btnEdit;
        private Panel pnDel;
        private Button btnDel;
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
