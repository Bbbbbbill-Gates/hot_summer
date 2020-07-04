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
    public partial class homepage : Form
    {
        private bool isRecord = false;
        private bool isUser = false;
        private optForm last;
        private string userID;

        private string username;
        private string phone;
        private string add;
        private string email;

        public homepage(optForm opt, string s)
        {
            InitializeComponent();

            userBtn_Click(null, null);

            this.last = opt;
            this.userID = s;
        }
        /// <summary>
        /// 当页面关闭,显示主页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.last.Show();
        }

        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userBtn_Click(object sender, EventArgs e)
        {
            if (! this.isUser)
            {
                this.isUser = true;

                this.headPic_lbl.Visible = true;
                this.userName_lbl.Visible = true;
                this.email_lbl.Visible = true;
                this.phone_lbl.Visible = true;
                this.address_lbl.Visible = true;
                this.change_btn.Visible = true;

                this.isRecord = false;
                this.dataGridView1.Visible = false;
                this.comboBox1.Visible = false;
                this.comboBox2.Visible = false;
                this.comboBox3.Visible = false;
                this.textBox1.Visible = false;
                this.select_btn.Visible = false;
                this.export_btn.Visible = false;
            }
        }

        /// <summary>
        /// 显示工作记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recordBtn_Click(object sender, EventArgs e)
        {
            if (! this.isRecord)
            {
                this.isRecord = true;

                this.dataGridView1.Visible = true;
                this.comboBox1.Visible = true;
                this.comboBox2.Visible = true;
                this.comboBox3.Visible = true;
                this.textBox1.Visible = true;
                this.select_btn.Visible = true;
                this.export_btn.Visible = true;

                this.isUser = false;
                this.headPic_lbl.Visible = false;
                this.userName_lbl.Visible = false;
                this.email_lbl.Visible = false;
                this.phone_lbl.Visible = false;
                this.address_lbl.Visible = false;
                this.change_btn.Visible = false;
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void load_user()
        {
            bool isSuccess = false;

            //获取在哪里查询
            string DBServer = "localhost";
            string DBname = "test_schema";
            string DBuserName = "root";
            string DBpassword = "ca.0123";
            string tableName = "usertable";
            string userNameCol = "userid";

            //要查询的信息
            string UserPhone = "UserPhone";
            string UserName = "UserName";
            string UserEmail = "UserEmail";
            string UserAdd = "UserAdd";

            //开始查询
            MySqlCommand cmd;
            MySqlConnection conn;
            long num;

            string connstring = "Server=" + DBServer + ";Database =" + DBname + ";Uid=" + DBuserName + ";Pwd=" + DBpassword + ";";

            conn = new MySqlConnection(connstring);
            conn.Open();

            //查询在服务器的相关信息
            /*string query = "select count(*) from " + tableName + " where " + userNameCol + "=" + this.userID + "';";
            cmd = new MySqlCommand(query, conn);

            num = (long)cmd.ExecuteScalar();
            if (num != 0l) isSuccess = true;*/

            conn.Close();
            //查询 结束

            //输入正确则打开主页面，不正确提示用户名或密码错误，清空密码，密码框获得焦点
            if (isSuccess)
            {
                //更新信息
            }
            else
            {
                //提示错误
            }
        }
    }
}
