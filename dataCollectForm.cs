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
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using System.Security.Claims;

namespace hot_summer
{
    public partial class dataCollectForm : Form
    {

        private gamePlay videoForm;
        private AxWindowsMediaPlayer player;
        private double startTime;
        private double halfTime;
        private double nowTime;
        private DateTime calTime;
        private bool isStart = false;

        /// <summary>
        /// 构造函数初始化调整操作窗口在屏幕上的位置
        /// </summary>
        public dataCollectForm()
        {
            InitializeComponent();

            //调整位置
            int w = Screen.GetWorkingArea(this).Width;
            int h = Screen.GetWorkingArea(this).Height;
            this.Left = w - this.Width;
            this.Top = (h - this.Height) / 2;

            this.refereeData.Text = "主裁判：    第一助理裁判：    第二助理裁判：     第四官员：    底线裁判1：    底线裁判2：    视频助理裁判组：    ";

            this.number.Width = this.dataGridView1.Size.Width / 7;
            this.timeOfEvent.Width = this.dataGridView1.Size.Width / 7;
            this.coordinateOfReferee.Width = this.dataGridView1.Size.Width / 7;
            this.eventOfGame.Width = this.dataGridView1.Size.Width * 25 / 70;
            this.coordinateOfEvent.Width = this.dataGridView1.Size.Width / 7;

            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
        }

        /// <summary>
        /// 加载时，新建并打开播放窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCollectForm_Load(object sender, EventArgs e)
        {
            this.videoForm = new gamePlay();
            this.player = this.videoForm.getPlayer();
            this.videoForm.Show();
        }

        /// <summary>
        /// 初次点击开始获取比赛开始时间，并开始计时。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            if ( this.halfTimeChoice.SelectedItem == null )
            {
                MessageBox.Show("请选择上下半场信息！", "提示");
                this.halfTimeChoice.Focus();
                return;
            }    
            if (! this.isStart)
            {
                this.nowTime = this.startTime = this.player.Ctlcontrols.currentPosition;
                this.halfTimeChoice.SelectedIndex = 0;
                this.isStart = true;
            }

        }

        /// <summary>
        /// 点击暂停播放
        /// 暂停后点击继续播放视频.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_Click(object sender, EventArgs e)
        {
            if (this.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                this.player.Ctlcontrols.pause();
                this.stop.Text = "继续";
                return;
            }

            if (this.player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                this.player.Ctlcontrols.play();
                this.stop.Text = "暂停";
                return;
            }

        }

        /// <summary>
        /// 更新比赛时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.isStart && this.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double dif = this.player.Ctlcontrols.currentPosition - this.nowTime;
                this.nowTime = this.nowTime + dif;
                calTime = calTime.AddSeconds(dif);
                this.time.Text = "比赛时间 " + calTime.ToString("mm : ss");
            }
        }

        private Cursor GetCursor(Bitmap img, int HotSpotX = 0, int HotSpotY = 0)
        {
            Bitmap curImg = new Bitmap(img.Width * 2, img.Height * 2);
            Graphics g = Graphics.FromImage(curImg);

            g.Clear(Color.FromArgb(0, 0, 0, 0));
            g.DrawImage(img, img.Width - HotSpotX, img.Width - HotSpotY, img.Width, img.Height);

            Cursor cur = new Cursor(curImg.GetHicon());

            g.Dispose();
            curImg.Dispose();

            return cur;
        }

        /// <summary>
        /// 进入图片修改鼠标样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            string dir = @"..\..\source\formImage\m_target.png";
            Bitmap image = new Bitmap(dir);
            this.Cursor = GetCursor(image, 25, 25);
        }

        /// <summary>
        /// 退出图片修改鼠标样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void halfTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.halfTimeChoice.SelectedIndex == 0)
            {
                this.nowTime = this.halfTime = this.player.Ctlcontrols.currentPosition;
                calTime = new DateTime();
                this.time.Text = "比赛时间 " + calTime.ToString("mm : ss");
            }

            if (this.halfTimeChoice.SelectedIndex == 1)
            {
                this.nowTime = this.halfTime = this.player.Ctlcontrols.currentPosition;
                calTime = new DateTime();
                calTime = calTime.AddMinutes(45);
                this.time.Text = "比赛时间 " + calTime.ToString("mm : ss");
            }
        }

        private void 导入视频ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "媒体文件（所有类型）|*.mp4;*.mp3;*.mpeg;*.wma;*.wmv;*.wav;*.avi";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                player.URL = openFileDialog1.FileName;
            }
        }
    }
}
