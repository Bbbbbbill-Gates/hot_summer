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
    public partial class CardTeam : Form
    {
        private int team = -1;

        public CardTeam()
        {
            InitializeComponent();
        }

        public int get_team()
        {
            return this.team;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.team = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.team = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CardTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.team == -1)
            {
                MessageBox.Show("未选择！", "提示");
                e.Cancel = true;
            }
        }

        private void CardTeam_Load(object sender, EventArgs e)
        {
            this.team = -1;
        }
    }
}
