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
        private createProForm1 last;
        public createProForm2(createProForm1 front)
        {
            InitializeComponent();
            this.last = front;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.last.Show();
        }
    }
}
