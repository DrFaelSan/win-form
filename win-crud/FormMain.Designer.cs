namespace win_crud
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            sidebar = new FlowLayoutPanel();
            pnList = new Panel();
            btnList = new Button();
            pnAdd = new Panel();
            btnAdd = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnMenu = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            pnList.SuspendLayout();
            pnAdd.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(196, 210, 245);
            sidebar.Controls.Add(pnList);
            sidebar.Controls.Add(pnAdd);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(250, 673);
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
            btnList.BackColor = Color.FromArgb(196, 210, 245);
            btnList.Cursor = Cursors.Hand;
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
            btnAdd.BackColor = Color.FromArgb(196, 210, 245);
            btnAdd.Cursor = Cursors.Hand;
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(196, 210, 245);
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
            btnMenu.Cursor = Cursors.Hand;
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
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 673);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(sidebar);
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimumSize = new Size(1080, 720);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WIN FORM CRUD";
            sidebar.ResumeLayout(false);
            pnList.ResumeLayout(false);
            pnAdd.ResumeLayout(false);
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
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
