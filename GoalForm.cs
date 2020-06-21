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
    public partial class GoalForm : Form
    {
        private int goal = -1;
        public GoalForm()
        {
            InitializeComponent();
        }

        public int get_goal()
        {
            return this.goal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.goal = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.goal = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.goal = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GoalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.goal == -1)
            {
                MessageBox.Show("未选择！", "提示");
                e.Cancel = true;
            }
        }
    }
}
