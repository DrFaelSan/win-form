using win_crud.Forms;
using win_crud.Utils;

namespace win_crud;

public partial class Form1 : Form
{
    private bool SiderbarExpand = true;
    FormList? formList;
    FormAdd? formAdd;
    FormEdit? formEdit;
    FormDel? formDel;

    public Form1()
    {
        InitializeComponent();
        MdiProp();
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
        if (formList is null)
        {
            formList = new FormList();
            formList.FormClosed += FormList_FormClosed;
            formList.MdiParent = this;
            formList.Dock = DockStyle.Fill;
            formList.Show();
        }
        else
            formList.Activate();
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        if (formAdd is null)
        {
            formAdd = new FormAdd();
            formAdd.FormClosed += FormAdd_FormClosed;
            formAdd.MdiParent = this;
            formAdd.Dock = DockStyle.Fill;
            formAdd.Show();
        }
        else
            formAdd.Activate();
    }

    private void BtnEdit_Click(object sender, EventArgs e)
    {
        if (formEdit is null)
        {
            formEdit = new FormEdit();
            formEdit.FormClosed += FormEdit_FormClosed;
            formEdit.MdiParent = this;
            formEdit.Dock = DockStyle.Fill;
            formEdit.Show();
        }
        else
            formEdit.Activate();
    }

    private void BtnDel_Click(object sender, EventArgs e)
    {
        if (formDel is null)
        {
            formDel = new FormDel();
            formDel.FormClosed += FormDel_FormClosed;
            formDel.MdiParent = this;
            formDel.Dock = DockStyle.Fill;
            formDel.Show();
        }
        else
            formDel.Activate();
    }


    private void FormList_FormClosed(object? sender, FormClosedEventArgs e)
       => formList = null;

    private void FormDel_FormClosed(object? sender, FormClosedEventArgs e)
        => formDel = null;

    private void FormAdd_FormClosed(object? sender, FormClosedEventArgs e)
        => formAdd = null;

    private void FormEdit_FormClosed(object? sender, FormClosedEventArgs e)
        => formEdit = null;
}
