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
using DBOperation;

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

                this.label2.Visible = true;
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label5.Visible = true;
                this.label6.Visible = true;

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

                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label5.Visible = false;
                this.label6.Visible = false;
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void load_user()
        {
            //要查询的信息
            string UserPhone = "UserPhone";
            string UserName = "UserName";
            string UserEmail = "UserEmail";
            string UserAdd = "UserAdd";

            //开始查询
            DBO dbo = new DBO();
            dbo.Open();
            string tableName = "user_table";
            string userNameCol = "user_id";
            string mge = dbo.FindRow(tableName, userNameCol, this.userID);
            dbo.Close();
            //查询 结束
            if ( mge == null )
            {
                MessageBox.Show("未查找到！", "错误");
                return;
            }
            string[] splitChar = { "," };
            string[] result = mge.Split( splitChar, StringSplitOptions.None);
            
            this.phone = result[1];
            this.username = result[2];
            this.email = result[4];
            this.add = result[6];

            this.refreshLbl();
            //MessageBox.Show(mge);
        }

        private void refreshLbl()
        {
            //lbl2是头像
            this.label1.Text = this.userID;
            this.label3.Text = this.userID;
            this.label4.Text = this.phone;
            this.label5.Text = this.email;
            this.label6.Text = this.add;

        }

        /// <summary>
        /// 加载窗口时，加载用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homepage_Load(object sender, EventArgs e)
        {
            this.load_user();
        }
    }
}
