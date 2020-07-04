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
    public partial class playerSelect : Form
    {
        private int mge = -1;
        private string str;
        private bool isBtn = false;

        public playerSelect()
        {
            InitializeComponent();
        }

        private void playerSelect_Load(object sender, EventArgs e)
        {
            this.mge = -1;
            this.str = "";
            this.isBtn = false;
        }

        public string get_str()
        {
            return this.str;
        }

        /// <summary>
        /// 检索输入的信息是否符合要求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check()
        {
            int row = dataGridView1.RowCount;
            for (int i = 0; i < row; i ++ )
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

            row = dataGridView2.RowCount;
            for (int i = 0; i < row; i++)
            {
                if ((dataGridView2[0, i].Value is null && dataGridView2[1, i].Value is null) || (dataGridView2[0, i].Value.ToString() == "" && dataGridView2[1, i].Value.ToString() == ""))
                {
                    continue;
                }
                else if (dataGridView2[0, i].Value.ToString() == "" || dataGridView2[1, i].Value.ToString() == "")
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
        /// 不是通过完成按钮关闭的情况，拒绝关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (! this.isBtn)
            {
                MessageBox.Show("不可关闭！", "提示");
                e.Cancel = true;
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
            for (int i = 0; i < row; i ++ )
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

            row = dataGridView2.RowCount;
            for (int i = 0; i < row; i++)
            {
                if ((dataGridView2[0, i].Value is null && dataGridView2[1, i].Value is null) || (dataGridView2[0, i].Value.ToString() == "" && dataGridView2[1, i].Value.ToString() == ""))
                {
                    continue;
                }

                else
                {
                    str += (" " + dataGridView2[0, i].Value.ToString() + " " + dataGridView2[1, i].Value.ToString());
                }
            }

            //MessageBox.Show(str);
            this.isBtn = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
