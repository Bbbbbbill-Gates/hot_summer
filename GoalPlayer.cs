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
    public partial class GoalPlayer : Form
    {
        private bool isBtn = false;
        private int mge = -1;
        private string str;

        public GoalPlayer()
        {
            InitializeComponent();
        }

        public string get_str()
        {
            return this.str;
        }

        private void GoalPlayer_Load(object sender, EventArgs e)
        {
            this.str = "";
        }

        /// <summary>
        /// 检索输入的信息是否符合要求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check()
        {
            int row = dataGridView1.RowCount;
            for (int i = 0; i < row; i++)
            {
                if ((dataGridView1[0, i].Value is null && dataGridView1[1, i].Value is null) || (dataGridView1[0, i].Value.ToString() == "" && dataGridView1[1, i].Value.ToString() == ""))
                {
                    continue;
                }
                else if (dataGridView1[0, i].Value.ToString() == "" || dataGridView1[1, i].Value.ToString() == "")
                {
                    this.mge = -1;
                    return;
                }
                else
                {
                    this.mge = 0;
                }
            }
        }

        /// <summary>
        /// 完成按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finish_Click(object sender, EventArgs e)
        {

            //检查输入信息是否合格
            this.check();
            if (this.mge == -1)
            {
                MessageBox.Show("未输入完整信息！", "提示");
                return;
            }

            //合格就收集信息后关闭
            int row = dataGridView1.RowCount;
            for (int i = 0; i < row; i++)
            {
                if ((dataGridView1[0, i].Value is null && dataGridView1[1, i].Value is null) || (dataGridView1[0, i].Value.ToString() == "" && dataGridView1[1, i].Value.ToString() == ""))
                {
                    continue;
                }
                else
                {
                    str += (" " + dataGridView1[0, i].Value.ToString() + " " + dataGridView1[1, i].Value.ToString());
                }
            }

            //MessageBox.Show(str);
            this.isBtn = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GoalPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (! this.isBtn)
            {
                MessageBox.Show("不可关闭！", "提示");
                e.Cancel = true;
            }
        }
    }
}
