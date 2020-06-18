using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace hot_summer
{
    public partial class gamePlay : Form
    {
        private dataCollectForm data;
        /// <summary>
        /// 构造函数初始化播放窗口在屏幕中的位置
        /// </summary>
        public gamePlay(dataCollectForm home)
        {
            InitializeComponent();
            int x = Screen.PrimaryScreen.WorkingArea.Left;
            int y = 200;
            this.Location = new Point(x, y);

            this.data = home;
        }

        /// <summary>
        /// 获取播放器
        /// </summary>
        /// <returns></returns>
        public AxWindowsMediaPlayer getPlayer()
        {
            return axWindowsMediaPlayer1;
        }

        /// <summary>
        /// 加载时获取比赛录像的路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gamePlay_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 调整播放窗口时，同时改变播放器大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gamePlay_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = new Size(this.Size.Width, this.Size.Height-35);
        }

        private void gamePlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();


            if (data.get_isStart() && this.axWindowsMediaPlayer1.URL != null && this.axWindowsMediaPlayer1.URL != "")
            {
                if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                    data.set_stop("继续");
                    return;
                }

                if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    this.axWindowsMediaPlayer1.Ctlcontrols.play();
                    data.set_stop("暂停");
                    return;
                }
            }
        }

        private void gamePlay_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
