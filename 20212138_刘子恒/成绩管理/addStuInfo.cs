using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理
{
    //新增学生
    public partial class addStuInfo : Form
    {
        string filePath;//用于传递文件路径
        public addStuInfo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = loginForm.connectionString;
            byte[] imageData = ReadImageFile(filePath);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string insertQuery = "INSERT INTO 学生表 (学号,姓名,性别,出生日期,班级,密码,照片) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox3.Text + "','" + textBox4.Text + "',@ImageData)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    //单独处理照片路径
                    command.Parameters.AddWithValue("@ImageData", imageData);
                    if(command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }
        //从文件中选择照片
        private void button1_Click(object sender, EventArgs e)
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
        //把文件路径转为字节型
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            pictureBox1.Image = null;
        }
    }
}
