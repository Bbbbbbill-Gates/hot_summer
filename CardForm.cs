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
    public partial class CardForm : Form
    {
        private int card = -1;

        public CardForm()
        {
            InitializeComponent();
        }

        public int get_card()
        {
            return this.card;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.card = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.card = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.card = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.card == -1)
            {
                MessageBox.Show("未选择！", "提示");
                e.Cancel = true;
            }
        }
    }
}
