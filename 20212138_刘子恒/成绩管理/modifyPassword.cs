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

namespace 成绩管理
{
    //修改密码
    public partial class modifyPassword : Form
    {
        public modifyPassword()
        {
            InitializeComponent();
        }

        private void modifyPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpass = textBox1.Text;
            string value;
            string passwd = textBox2.Text;
            string quepasswd = textBox3.Text;
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
           
            if (passwd == "" || quepasswd == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (quepasswd != passwd)
                {
                    MessageBox.Show("两次输入的密码不一致!");
                }
                else
                {

                    if (loginForm.getRole() == "学生")
                    {
                        //验证旧密码是否正确
                       if(oldpass != loginForm.password)
                        {
                            MessageBox.Show("旧密码输入错误");
                        }
                        else
                        {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update 学生表 set 密码 ='" + passwd + "' where 姓名 = '" + loginForm.getUserName() + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");
                        }
                        

                    }
                    else
                    {
                        //验证旧密码是否正确
                        if (oldpass != loginForm.password)
                        {
                            MessageBox.Show("旧密码输入错误");
                        }
                        else
                        {
                         SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update 用户表 set 密码 ='" + passwd + "' where 姓名 = '" + loginForm.getUserName() + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");
                        }
                       

                    }


                }
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
