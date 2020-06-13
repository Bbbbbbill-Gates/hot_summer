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
    public partial class createProForm2 : Form
    {
        private optForm home;
        private createProForm1 last;
        private bool isOk_team1 = false;
        private bool isOk_team2 = false;
        private bool isOk_referee = false;

        public createProForm2(createProForm1 front, optForm opt)
        {
            InitializeComponent();
            this.last = front;
            this.home = opt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.last.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test
            isOk_referee = true;
            isOk_team1 = true;
            isOk_team2 = true;

            if (! isOk_team1)
            {
                MessageBox.Show("主队信息有误，请检查！", "提示");
                comboBox1.Focus();
                return;
            }
            if (! isOk_team2)
            {
                MessageBox.Show("主队信息有误，请检查！", "提示");
                comboBox2.Focus();
                return;
            }
            if (! isOk_referee)
            {
                MessageBox.Show("主队信息有误，请检查！", "提示");
                comboBox3.Focus();
                return;
            }

            dataCollectForm newOpt = new dataCollectForm(this.home);
            this.Hide();
            newOpt.Show();
        }
    }
}
