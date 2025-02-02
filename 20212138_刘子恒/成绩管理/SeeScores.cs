using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 成绩管理
{
    public partial class SeeScores : Form
    {
        public SeeScores()
        {
            InitializeComponent();
        }

        private void SeeScores_Load(object sender, EventArgs e)
        {
            if (loginForm.role == "教务员")
            {
                //初始化信息框
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                string sql = "select 学生表.学号 as 学号,学生表.姓名 as 姓名,课程表.课程号 as 课程号,课程表.课程名 as 课程名,成绩表.成绩 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            else
            {
                textBox2.Enabled = false;
                //初始化信息框
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                string sql = "select 学生表.学号 as 学号,学生表.姓名 as 姓名,课程表.课程号 as 课程号,课程表.课程名 as 课程名,成绩表.成绩 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号 and 成绩表.学号 = '" + ChooseCour.getXuehao() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginForm.role == "教务员")
            {
                //查询
                //清空信息框
                while (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.DataSource = null;
                }
                //当两条件为空时
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("请输入查询信息！");
                }
                //课程不空，学号空
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    string sql = "select 学生表.学号 as 学号,学生表.姓名 as 姓名,课程表.课程号 as 课程号,课程表.课程名 as 课程名,成绩表.成绩 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号 and 课程表.课程名 = '" + textBox1.Text + "'";
                    SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    //载入基本信息
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    conn.Close();
                }
                //课程空，学号不空
                else if (textBox1.Text == "" && textBox2.Text != "")
                {

                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    string sql = "select 学生表.学号 as 学号,学生表.姓名 as 姓名,课程表.课程号 as 课程号,课程表.课程名 as 课程名,成绩表.成绩 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号 and 成绩表.学号 = '" + textBox2.Text + "'";
                    SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    //载入基本信息
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    conn.Close();
                }
                //条件都不空
                else if (textBox1.Text != "" && textBox2.Text != "")
                {

                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    string sql = "select 学生表.学号 as 学号,学生表.姓名 as 姓名,课程表.课程号 as 课程号,课程表.课程名 as 课程名,成绩表.成绩 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号 and 成绩表.学号 = '" + textBox2.Text + "' and 课程表.课程名 = '" + textBox1.Text + "'";
                    SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    //载入基本信息
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    conn.Close();
                }

            }//if
            if (loginForm.role == "学生")
            {
                //查询
                //清空信息框
                while (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.DataSource = null;
                }
                //当条件为空时
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入查询信息！");
                }
                //课程不空
                else
                {
                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    string sql = "select 学生表.学号 as 学号,学生表.姓名 as 姓名,课程表.课程号 as 课程号,课程表.课程名 as 课程名,成绩表.成绩 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号 and 课程表.课程名 = '" + textBox1.Text + "'and 成绩表.学号 = '" + ChooseCour.getXuehao() + "' ";
                    SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    //载入基本信息
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    conn.Close();
                }
            }
        }
    }
}
