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
    public partial class AdmForm2 : Form
    {
        public AdmForm2()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyPassword mainframe = new modifyPassword();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void 添加教务员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStuInfo mainframe = new addStuInfo();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void 删改学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerModDel mainframe = new SerModDel();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void 录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStuScore mainframe = new addStuScore();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void 查看成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeeScores mainframe = new SeeScores();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            modifyPassword mainframe = new modifyPassword();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addStuInfo mainframe = new addStuInfo();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SerModDel mainframe = new SerModDel();
            mainframe.BringToFront();
            mainframe.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SeeScores mainframe = new SeeScores();
            mainframe.BringToFront();
            mainframe.Show();
        }
    }
}
