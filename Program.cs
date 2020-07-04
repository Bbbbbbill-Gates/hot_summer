using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hot_summer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dataCollectForm(new optForm("123456")));
            //Application.Run(new createProForm2(null));
            //Application.Run(new signIn());
            //Application.Run(new homepage(new optForm("123456"), "123456"));
        }
    }
}
