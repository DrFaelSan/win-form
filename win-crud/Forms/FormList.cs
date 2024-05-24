using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_crud.Forms;
public partial class FormList : Form
{
    public FormList()
    {
        InitializeComponent();
    }

    private void formList_Load(object sender, EventArgs e)
    {
        ControlBox = false;
    }
}
