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
    public partial class CloseForm : Form
    {
        private int opt = -1;

        public CloseForm()
        {
            InitializeComponent();
        }

        public int get_opt()
        {
            return this.opt;
        }

        private void CloseForm_Load(object sender, EventArgs e)
        {
            this.opt = -1;
        }

        /// <summary>
        /// 未选择不能关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.opt == -1)
            {
                MessageBox.Show("未选择！", "提示");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.opt = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.opt = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
