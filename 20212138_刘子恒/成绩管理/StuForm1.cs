using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理
{
    public partial class StuForm1 : Form
    {
        public StuForm1()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyPassword mainframe = new modifyPassword();
            mainframe.BringToFront();
            mainframe.Show();

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseCour mainframe = new ChooseCour();
            mainframe.BringToFront();
            mainframe.Show();

        }

        private void 查看成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeeScores mainframe = new SeeScores();
            mainframe.BringToFront();
            mainframe.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            modifyPassword mainframe = new modifyPassword();
            mainframe.BringToFront();
            mainframe.Show();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SeeScores mainframe = new SeeScores();
            mainframe.BringToFront();
            mainframe.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ChooseCour mainframe = new ChooseCour();
            mainframe.BringToFront();
            mainframe.Show();

        }
    }
}
