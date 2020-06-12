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

        public homepage(optForm opt)
        {
            InitializeComponent();

            userBtn_Click(null, null);

            this.last = opt;
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
    }
}
