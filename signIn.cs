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
            
            //获取在哪里查询
            string DBServer = "localhost";
            string DBname = "test_schema";
            string DBuserName = "root";
            string DBpassword = "ca.0123";
            string tableName = "test_table";
            string userNameCol = "idtest_table";
            string passwordCol = "test_tablecol1";

            //数据库中检查用户名和密码, 只实现了查询数字
            //检查用户名和密码 开始
            MySqlCommand cmd;
            MySqlConnection conn;
            long num;

            string connstring = "Server=" + DBServer + ";Database =" + DBname + ";Uid=" + DBuserName + ";Pwd=" + DBpassword + ";";

            conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "select count(*) from " + tableName + " where " + userNameCol + "=" + username + " and " + passwordCol + "='" + password + "';";
            cmd = new MySqlCommand(query, conn);

            num = (long)cmd.ExecuteScalar();
            if (num != 0l) isSuccess = true;
            else isSuccess = false;
            
            conn.Close(); 
            //检查用户名和密码 结束

            //输入正确则打开主页面，不正确提示用户名或密码错误，清空密码，密码框获得焦点
            if (isSuccess)
            {
                MessageBox.Show("登陆成功！", "提示");

                //打开主页面
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

    }
}
