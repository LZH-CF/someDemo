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
    public partial class ChooseCour : Form
    {
        public ChooseCour()
        {
            InitializeComponent();
        }

        private void ChooseCour_Load(object sender, EventArgs e)
        {
            //初始化两个信息框
            this.getRusult1();
            this.getRusult2();
        }
        
        //选课，向成绩表中插入记录
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = loginForm.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string insertQuery = "INSERT INTO 成绩表 (学号,课程号) VALUES ('" + getXuehao() + "','" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "')";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();
                    this.getRusult2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }
        //获取当前用户的学号
        public static string getXuehao()
        {
            String stuxuehao = "";
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select 学号 from 学生表 where 姓名 = '" + loginForm.getUserName() + "'";

            // 创建SQL命令对象
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                // 执行查询，并获取查询结果
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // 处理查询结果
                    while (reader.Read())
                    {
                        // 获取查询结果中的数据
                        string column1Value = reader.GetString(0);
                        stuxuehao = reader.GetString(0);
                    }
                }
            }
            conn.Close();
            return stuxuehao;
        }
        //退课
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();

            string sql = "delete from  成绩表  where  课程号 = '" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
                this.getRusult2();
            }
            conn.Close();
        }
        private void getRusult1()
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            //textBox1.Text.Trim()  textBox2.Text.Trim()
            string sql = "select 课程号 as 课程号,课程名 as 课程名,课程简介 as 课程简介,任课教师 as 任课教师,课时数 as 课时数,学分 as 学分 from 课程表";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
        private void getRusult2()
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            //textBox1.Text.Trim()  textBox2.Text.Trim()
            string sql = "select 课程表.课程号 as 课程号,课程名 as 课程名,课程简介 as 课程简介,任课教师 as 任课教师,课时数 as 课时数,学分 as 学分 from 课程表, 成绩表, 学生表 where 课程表.课程号 = 成绩表.课程号 and 成绩表.学号 = 学生表.学号 and 姓名 = '" + loginForm.getUserName() + "'";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
