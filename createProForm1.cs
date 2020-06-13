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
    public partial class createProForm1 : Form
    {
        private string gameCategory;
        private DateTime gameTime;
        private string address;
        private optForm lastForm;
        public createProForm1(optForm optform)
        {
            InitializeComponent();
            this.lastForm = optform;
        }

        /// <summary>
        /// 控件发生变化，获取相应的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gameCategory = comboBox1.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.gameTime = dateTimePicker1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.address = textBox1.Text;
        }

        /// <summary>
        /// 点击下一步时，检查是否获取足够的信息，且在数据库中核验信息是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            //检查信息是否完整，不完整的获取相应焦点
            if (this.gameCategory == null || comboBox1.SelectedIndex.ToString() == null)
            {
                MessageBox.Show("请选择比赛类别！", "提示");
                comboBox1.Focus();
                return;
            }
            if (this.gameTime == null)
            {
                MessageBox.Show("请选择比赛时间！", "提示");
                dateTimePicker1.Focus();
                return;
            }
            if (this.address == null || this.address == "")
            {
                MessageBox.Show("请输入地址信息","提示");
                textBox1.Focus();
                return;
            }

            //获取在哪里查询
            string DBServer = "localhost";
            string DBname = "test_schema";
            string DBuserName = "root";
            string DBpassword = "ca.0123";
            string tableName = "test_table1";
            string testTime = "idtest_time";
            string testAdress = "test_address";

            /*
            //数据库中检查比赛信息
            //检查比赛信息 开始
            MySqlCommand cmd;
            MySqlConnection conn;
            long num;

            string connstring = "Server=" + DBServer + ";Database =" + DBname + ";Uid=" + DBuserName + ";Pwd=" + DBpassword + ";";

            conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "select count(*) from " + tableName + " where " + testTime + "='" + this.gameTime + "' and " + testAdress + "='" + this.address + "';";
            cmd = new MySqlCommand(query, conn);

            num = (long)cmd.ExecuteScalar();
            if (num != 0l) isSuccess = true;
            else isSuccess = false;

            conn.Close();
            //检查比赛信息 结束
            */

            //test
            isSuccess = true;

            if (isSuccess)
            {
                this.Hide();
                createProForm2 next = new createProForm2(this, this.lastForm);
                next.StartPosition = FormStartPosition.CenterScreen;
                next.Show();
            }
            else
            {
                MessageBox.Show("比赛信息错误，请检查重试！","提示");
            }
        }

        /// <summary>
        /// 点击退出返回主页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.lastForm.Show();
        }

        
    }
}
