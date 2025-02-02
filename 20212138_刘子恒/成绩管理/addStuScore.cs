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
    public partial class addStuScore : Form
    {
        public addStuScore()
        {
            InitializeComponent();
        }

        private void addStuScore_Load(object sender, EventArgs e)
        {
            //初始化成绩框
            this.getRusult();
            dataGridView1.Columns[0].ReadOnly = true; // 设置为只读
            dataGridView1.Columns[1].ReadOnly = true; // 设置为只读
            //填充课程名框
            string query = "SELECT DISTINCT 课程名 FROM 课程表";
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["课程名"].ToString());
                }
                reader.Close();
            }
        }
        //用于初始化信息框
        private void getRusult()
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            //textBox1.Text.Trim()  textBox2.Text.Trim()
            string sql = "select 学号 as 学号,课程号 as 课程号,成绩 as 成绩 from 成绩表";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
        //筛选课程
        private void button1_Click(object sender, EventArgs e)
        {
            //清空信息框
            while (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
            }
            //当条件为空时
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请输入查询信息！");
            }
            //班级组合框选中，姓名，学号为空
            else
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                string sql = "select 学号 as 学号,成绩表.课程号 as 课程号,成绩 as 成绩 from 成绩表,课程表  where 成绩表.课程号 = 课程表.课程号 and 课程名 = '" + comboBox1.SelectedItem.ToString() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
        }
        //保存成绩
        private void button2_Click(object sender, EventArgs e)
        {
            // 假设dataGridView1是您的DataGridView控件的名称
            string columnName = "成绩"; // 替换为您要保存的列名

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // 获取行中指定列的数据
                    object cellValue = row.Cells[0].Value;
                    object cellValue1 = row.Cells[1].Value;
                    object cellValue2 = row.Cells[2].Value;
                    // 将数据更新到数据库中，这里假设您使用了SQL Server数据库
                    UpdateDataInDatabase(cellValue.ToString(), cellValue1.ToString(), columnName, cellValue2.ToString());
                }
            }

            MessageBox.Show("数据保存成功！");
        }
        // 在此实现将数据更新到数据库的逻辑
        private void UpdateDataInDatabase(string studentID, string kechengID,string columnName, string value)
        {          
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE 成绩表 SET 成绩 = @Value WHERE 学号 = @StudentID and 课程号 = @kechengID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Value", value);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@kechengID", kechengID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
