using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        private MySqlCommand cmd = null;
        private MySqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String connstring = "Server=localhost;Database =test_schema;Uid=root;Pwd=ca.0123;";

            conn = new MySqlConnection(connstring);

            conn.Open();

            string insert = "INSERT INTO `test_schema`.`test_table` (`idtest_table`, `test_tablecol`, `test_tablecol1`) VALUES ('4', 'zxc', '100');";

            cmd = new MySqlCommand(insert, conn); 

            cmd.ExecuteNonQuery();

            conn.Close();  
        }
    }
}
