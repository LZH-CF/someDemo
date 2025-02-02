using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 成绩管理
{
    public partial class loginForm : Form
    {
        public static string connectionString = "database=CJGL;data source=.;Trusted_Connection = SSPI";
        public static string name;
        public static string role;
        public static string password;
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text.Trim();//获取当前用户名
            password = textBox2.Text.Trim();//获取当前用户密码，便于验证后续修改密码

            if (name == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请将信息输入完整！");
            }
            else
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                if (radioButton2.Checked)
                {
                    role = radioButton2.Text;
                    string sql = "select 姓名,密码 from 用户表 where  姓名='" + name +
                     "' and 密码='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();
                        AdmForm2 mainframe = new AdmForm2();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
                else if (radioButton1.Checked)
                {
                    role = radioButton1.Text;
                    string sql1 = "select 姓名,密码 from 学生表 where 姓名='" + name +
                     "' and 密码='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.Close();
                        conn.Close();
                        StuForm1 mainframe = new StuForm1();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }
        public static String getUserName()
        {
            String stuxuehao = "";
            stuxuehao = loginForm.name;
            return stuxuehao;
        }

        public static String getRole()
        {
            String role1 = "";
            role1 = role;
            return role1;
        }
    }
}