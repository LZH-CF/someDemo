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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 成绩管理
{
    public partial class SerModDel : Form
    {
        string filePath;//用于传递文件路径
        public SerModDel()
        {
            InitializeComponent();
        }

        private void SerModDel_Load(object sender, EventArgs e)
        {
            //填充信息框
            this.getRusult();
            //填充班级框
            string query = "SELECT DISTINCT 班级 FROM 学生表";
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["班级"].ToString());
                }

                reader.Close();
            }
        }
        //用于初始化显示学生信息
        private void getRusult()
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            //textBox1.Text.Trim()  textBox2.Text.Trim()
            string sql = "select 学号 as 学号,姓名 as 姓名,性别 as 性别,出生日期 as 出生日期,班级 as 班级,密码 as 密码,照片 as 照片 from 学生表";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
        //初始化修改模块
        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DataGridViewCell selectedCell = dataGridView1.SelectedRows[0].Cells[6];
            //把照片传给pictureBox
            if (selectedCell.Value != DBNull.Value)
            {
                byte[] imageData = (byte[])selectedCell.Value;
                Image image;

                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }

                pictureBox1.Image = image;
            }
        }
        //浏览照片
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                // 将选中的图片显示在PictureBox中
                Image image = Image.FromFile(filePath);
                pictureBox1.Image = image;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //写回数据库
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();

            byte[] imageData = ReadImageFile(filePath);
            string gender = comboBox2.SelectedItem.ToString();

            string sql = "update 学生表 set 姓名 = '" + textBox5.Text + "',性别 = '" + gender + "' ,出生日期 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ,班级 = '" + textBox3.Text + "' ,密码 = '" + textBox4.Text + "',照片 =@ImageData where 学号 = '" + textBox6.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ImageData", imageData);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("更改成功！");
                this.getRusult();
            }
            conn.Close();
        }
        //取消
        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Empty;
            textBox5.Text = string.Empty;
            comboBox2.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            pictureBox1.Image = null;
        }
        static byte[] ReadImageFile(string imagePath)
        {
            using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }
        }
        //删除选中的学生信息
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();

            string sql = "delete from  学生表  where  学号 = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
                this.getRusult();
            }

            conn.Close();
        }
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            //清空信息框
            while (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
            }
            //当三个条件为空时
            if (comboBox1.Text == "" && textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("请输入查询信息！");
            }
            //班级组合框选中，姓名，学号为空
            else if (comboBox1.Text != "" && textBox1.Text == "" && textBox2.Text == "")
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                string sql = "select 学号 as 学号,姓名 as 姓名,性别 as 性别,出生日期 as 出生日期,班级 as 班级,密码 as 密码,照片 as 照片 from 学生表 where 班级 = '" + comboBox1.SelectedItem.ToString() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            //班级框为空，姓名框不空，学号空
            else if (textBox1.Text != "" && comboBox1.Text == "" && textBox2.Text == "")
            {

                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select 学号 as 学号,姓名 as 姓名,性别 as 性别,出生日期 as 出生日期,班级 as 班级,密码 as 密码,照片 as 照片 from 学生表 where 姓名 = '" + textBox1.Text + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();


            }
            //班级框和姓名框不为空，学号空
            else if (textBox1.Text != "" && comboBox1.Text != "" && textBox2.Text == "")
            {

                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select 学号 as 学号,姓名 as 姓名,性别 as 性别,出生日期 as 出生日期,班级 as 班级,密码 as 密码,照片 as 照片 from 学生表 where 班级 = '" + comboBox1.SelectedItem.ToString() + "' and 姓名 = '" + textBox1.Text + "' ";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            //若学号不为空，则按学号查找，可忽略其他条件
            else
            {

                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select 学号 as 学号,姓名 as 姓名,性别 as 性别,出生日期 as 出生日期,班级 as 班级,密码 as 密码,照片 as 照片 from 学生表 where 学号 = '"+textBox2.Text+"'";
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
