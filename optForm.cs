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
        public optForm()
        {
            InitializeComponent();
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
            homepage home = new homepage(this);
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

    }
}
