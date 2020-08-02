using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBOperation;

namespace hot_summer
{
    public partial class signIn : Form
    {
        private string username;
        private string password;

        public signIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击登陆按钮，检查输入后，从数据库中查找用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sign_Click(object sender, EventArgs e)
        {
            this.username = text_userName.Text;
            this.password = text_password.Text;
            bool isSuccess = false;
            
            //检查用户名和密码不能为空，为空者获得相应的输入焦点，并且函数return
            if (this.username == "" || this.username == null)
            {
                MessageBox.Show("请输入用户名！", "错误");
                text_userName.Focus();
                return;
            }
            if (this.password == "" || this.password == null)
            {
                MessageBox.Show("请输入密码！", "错误");
                text_password.Focus();
                return;
            }

            //要查询的信息
            string tableName = "user_table";
            string userNameCol = "user_id";
            string passwordCol = "user_pwd";

            //数据库中检查用户名和密码
            //检查用户名和密码 开始
            DBO dbo = new DBO();
            dbo.Open();
            isSuccess = dbo.IsAllExisted(tableName, userNameCol, "123456", passwordCol, "123456");
            dbo.Close();
            //检查用户名和密码 结束

            //输入正确则打开主页面，不正确提示用户名或密码错误，清空密码，密码框获得焦点
            if (isSuccess)
            {
                MessageBox.Show("登陆成功！", "提示");

                //打开主页面
                this.Hide();
                optForm optform = new optForm(this.username);
                optform.StartPosition = FormStartPosition.CenterScreen;
                optform.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！","提示");
                text_password.Text = "";
                text_password.Focus();
            }
        }

        /// <summary>
        /// 密码输入框检测回车键，按下回车登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                sign_Click(null, null);
            }
        }

        /// <summary>
        /// 按下取消按钮，退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signIn_Load(object sender, EventArgs e)
        {
            /*DBO dbo = new DBO();
            dbo.Open();
            string tableName = "user_table";
            string userNameCol = "user_id";
            string passwordCol = "user_pwd";
            string mge = dbo.FindRow(tableName, userNameCol, "123456");
            MessageBox.Show(mge);*/
        }
    }
}
