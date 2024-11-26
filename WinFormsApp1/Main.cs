using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 類別管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void 資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.Show();
        }
    }
}
