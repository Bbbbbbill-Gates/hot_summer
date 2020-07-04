using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hot_summer
{
    public partial class optForm : Form
    {
        private string userID;

        public optForm(string s)
        {
            InitializeComponent();

            this.userID = s;
        }

        /// <summary>
        /// btn1点击开始新建项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            createProForm1 newForm = new createProForm1(this);
            newForm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            newForm.Show();
        }

        /// <summary>
        /// 点击头像打开个人中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void headPic_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage home = new homepage(this, this.userID);
            home.StartPosition = FormStartPosition.CenterScreen;
            home.Show();
        }

        /// <summary>
        /// 窗口关闭退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 三个按钮，鼠标进入或者离开范围时改变颜色操作，共六个函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(225, 255, 255);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Control.DefaultBackColor;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(225, 255, 255);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Control.DefaultBackColor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(225, 255, 255);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Control.DefaultBackColor;
        }

        /// <summary>
        /// 打开时加载用户头像信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optForm_Load(object sender, EventArgs e)
        {
            bool isSuccess = false;

            //获取在哪里查询
            string DBServer = "localhost";
            string DBname = "test_schema";
            string DBuserName = "root";
            string DBpassword = "ca.0123";
            string tableName = "usertable";
            string userNameCol = "userid";
            string passwordCol = "userpwd";

            //数据库中检查用户名和密码, 只实现了查询数字
            //检查用户名和密码 开始
            MySqlCommand cmd;
            MySqlConnection conn;
            long num;

            string connstring = "Server=" + DBServer + ";Database =" + DBname + ";Uid=" + DBuserName + ";Pwd=" + DBpassword + ";";

            conn = new MySqlConnection(connstring);
            conn.Open();

            //查询在服务器的相对路径还是直接读取成图片？
            /*string query = "select count(*) from " + tableName + " where " + userNameCol + "=" + this.userID + "';";
            cmd = new MySqlCommand(query, conn);

            num = (long)cmd.ExecuteScalar();
            if (num != 0l) isSuccess = true;*/

            conn.Close();
            //检查用户名和密码 结束

            //输入正确则打开主页面，不正确提示用户名或密码错误，清空密码，密码框获得焦点
            if (isSuccess)
            {
                //显示头像
            }
            else
            {
                //显示默认头像
            }
        }
    }
}
