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
        public homepage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当页面关闭，退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
