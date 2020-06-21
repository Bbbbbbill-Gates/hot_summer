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
using MySqlX.XDevAPI.Relational;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace hot_summer
{
    public partial class dataCollectForm : Form
    {
        //用于返回主页面
        private optForm home;

        //用于视频播放页面获取时间等相关操作
        private gamePlay videoForm;
        private AxWindowsMediaPlayer player;

        //时间记录
        private double startTime;
        private double halfTime;
        private double nowTime;
        private DateTime calTime;

        //是否开始
        private bool isStart = false;
        
        //用于右击事件的坐标记录
        private Point refereeP;
        private bool isEvent = false;

        private enum e{ foul, Offside, shoot, Setpiece };
        private e eState;
        private enum setPiece { directFreekick, indirectFreekick, penalty, goalKick, cornerKick, outOfBounds, midcourtKickOff };
        private setPiece setState;

        //画裁判员路线
        private Point st, now;
        private Graphics g;

        /// <summary>
        /// 构造函数初始化调整操作窗口在屏幕上的位置
        /// </summary>
        public dataCollectForm(optForm opt)
        {
            InitializeComponent();

            this.home = opt;

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

            this.g = pictureBox1.CreateGraphics();

        }

        /// <summary>
        /// 加载时，新建并打开播放窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCollectForm_Load(object sender, EventArgs e)
        {
            this.videoForm = new gamePlay(this);
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
            if ( this.player.URL == null || this.player.URL == "")
            {
                MessageBox.Show("未打开视频！", "提示");
                return;
            }
            if (! this.isStart)
            {
                this.nowTime = this.startTime = this.player.Ctlcontrols.currentPosition;
                this.halfTimeChoice.SelectedIndex = 0;
                this.isStart = true;
                this.player.Ctlcontrols.play();
                this.stop.Text = "暂停";
                this.dataGridView1.Focus();
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
            if (this.isStart && this.player.URL != null && this.player.URL != "")
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
        }

        /// <summary>
        /// 更新比赛时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.videoForm.Visible && this.isStart && this.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
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

        /// <summary>
        /// 上下半场选择后修改时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void halfTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.videoForm.Visible == false || this.player.URL == null || this.player.URL == "")
            {
                MessageBox.Show("还未打开视频!", "提示");
                return;
            }

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

        /// <summary>
        /// 导入视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 导入视频ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.videoForm.Visible == false)
            {
                this.videoForm.Visible = true;
            }

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "媒体文件（所有类型）|*.mp4;*.mp3;*.mpeg;*.wma;*.wmv;*.wav;*.avi";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                player.URL = openFileDialog1.FileName;
            }
            
        }

        /// <summary>
        /// 菜单结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult res =  MessageBox.Show("是否保存当前进度", "提示", MessageBoxButtons.YesNo);
            this.Close();
        }

        /// <summary>
        /// 菜单保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 窗口关闭前提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCollectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res =  MessageBox.Show("即将关闭程序，是否保存", "提示", MessageBoxButtons.YesNo);

            if (res == DialogResult.OK)
            {

            }
            else
            {

            }
        }

        /// <summary>
        /// 窗口关闭后打开旧的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCollectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.videoForm.Close();
            this.home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
           
            //获取坐标            
            MouseEventArgs e1 = (MouseEventArgs)e;
            Point p = new Point();
            p.X = e1.X;
            p.Y = Math.Abs(e1.Y - 450);
            //MessageBox.Show(p.ToString());

            //判断是左击还是右击
            if (e1.Button != MouseButtons.Left) return;
            
            int rowIndex = dataGridView1.Rows.Add();

            //右击事件
            if (this.isEvent)
            {
                dataGridView1[0, rowIndex].Value = rowIndex + 1;
                dataGridView1[1, rowIndex].Value = calTime.ToString("mm : ss");
                dataGridView1[2, rowIndex].Value = this.refereeP.ToString();
                dataGridView1[4, rowIndex].Value = p.ToString();

                if (this.eState == dataCollectForm.e.shoot)
                {
                    dataGridView1[3, rowIndex].Value = "射门";
                }
                if (this.eState == dataCollectForm.e.foul)
                {
                    dataGridView1[3, rowIndex].Value = "犯规";
                }
                if (this.eState == dataCollectForm.e.Offside)
                {
                    dataGridView1[3, rowIndex].Value = "越位";
                }
                if (this.eState == dataCollectForm.e.Setpiece)
                {
                    //dataGridView1[3, rowIndex].Value = "射门";
                    if (this.setState == setPiece.penalty)
                    {
                        dataGridView1[3, rowIndex].Value = "点球";
                    }
                    if (this.setState == setPiece.outOfBounds)
                    {
                        dataGridView1[3, rowIndex].Value = "界外球";
                    }
                    if (this.setState == setPiece.midcourtKickOff)
                    {
                        dataGridView1[3, rowIndex].Value = "中圈开球";
                    }
                    if (this.setState == setPiece.indirectFreekick)
                    {
                        dataGridView1[3, rowIndex].Value = "间接任意球";
                    }
                    if (this.setState == setPiece.goalKick)
                    {
                        dataGridView1[3, rowIndex].Value = "球门球";
                    }
                    if (this.setState == setPiece.directFreekick)
                    {
                        dataGridView1[3, rowIndex].Value = "直接任意球";
                    }
                    if (this.setState == setPiece.cornerKick)
                    {
                        dataGridView1[3, rowIndex].Value = "角球";
                    }
                }
            }
            else
            {
                //左击事件
                dataGridView1[0, rowIndex].Value = rowIndex + 1;
                dataGridView1[1, rowIndex].Value = calTime.ToString("mm : ss");
                dataGridView1[2, rowIndex].Value = p.ToString();
                dataGridView1[3, rowIndex].Value = "主裁判员位置移动";
            }
            //更新裁判坐标
            if (!this.isEvent)
            {
                this.now = e1.Location;
                if (this.st.X != 0 && this.st.Y != 0)
                {
                    Pen pen = new Pen(Color.Blue, 2);
                    g.DrawLine(pen, this.st, this.now);
                    pen.Dispose();
                }
                this.st = this.now;
            }

            //更新当前行
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
            this.dataGridView1.Focus();

            //事件位置选择完，结束事件标记
            this.isEvent = false;
        }

        /// <summary>
        /// 打开菜单前获取鼠标右击位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                return;
            }
            if (this.isEvent) return;

            ContextMenuStrip menu = (ContextMenuStrip)sender;
            this.refereeP = new Point(MousePosition.X - 777, Math.Abs(MousePosition.Y - 628));
            
            Point pp = this.pictureBox1.PointToClient(MousePosition);
            this.now = new Point(pp.X, pp.Y);
            //MessageBox.Show(this.now.ToString());
            if (this.st.X != 0 && this.st.Y != 0)
            {
                Pen pen = new Pen(Color.Blue, 2);
                g.DrawLine(pen, this.st, this.now);
                pen.Dispose();
            }
            this.st = this.now;
        }

        //射门
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.shoot;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        //越位
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Offside;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        //犯规
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.foul;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 点球ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.penalty;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 角球ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.cornerKick;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 界外球ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.outOfBounds;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 球门球ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.goalKick;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 中圈开球ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.midcourtKickOff;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 间接任意ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.indirectFreekick;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        private void 直接任意ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //比赛未开始不做操作
            if (!this.isStart)
            {
                MessageBox.Show("比赛还未开始，请导入视频并选择开始！", "提示");
                return;
            }
            this.isEvent = true;
            this.eState = dataCollectForm.e.Setpiece;
            this.setState = setPiece.directFreekick;
            MessageBox.Show("请选择事件位置！", "提示");
        }

        /// <summary>
        /// 检测按键实现快进快退和暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCollectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (this.isStart && this.player.URL != null && this.player.URL != "")
                {
                    if (this.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        this.player.Ctlcontrols.pause();
                        this.stop.Text = "继续";
                        
                    }
                    else if (this.player.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        this.player.Ctlcontrols.play();
                        this.stop.Text = "暂停";
                        
                    }
                }

                e.Handled = true;
                //stop_Click(null, null);
            }
            if (e.KeyCode == Keys.Right)
            {
                this.player.Ctlcontrols.currentPosition += 1;
                this.dataGridView1.Focus();
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                this.player.Ctlcontrols.currentPosition -= 1;
                this.dataGridView1.Focus();
                return;
            }
        }

        /// <summary>
        /// 双击选择事件的相关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView d = (DataGridView)sender;
            if (e.ColumnIndex != 3) return;
            string con = (string)d[e.ColumnIndex, e.RowIndex].Value;
            if (con == null) return;
            if (con.Contains("犯规") && ! con.Contains("红牌") && ! con.Contains("黄牌"))
            {
                int card = -1;
                using (CardForm frm = new CardForm())
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        card = frm.get_card();
                    }
                }

                if (card == 0)
                {
                    d[e.ColumnIndex, e.RowIndex].Value = d[e.ColumnIndex, e.RowIndex].Value + " " + "无牌";
                }
                else if (card == 1)
                {
                    d[e.ColumnIndex, e.RowIndex].Value = d[e.ColumnIndex, e.RowIndex].Value + " " + "黄牌";
                }
                else if (card == 2)
                {
                    d[e.ColumnIndex, e.RowIndex].Value = d[e.ColumnIndex, e.RowIndex].Value + " " + "红牌";
                }
            }
            else if(!con.Contains("越位") && !con.Contains("界外球"))
            {
                int team = -1;
                using (TeamForm frm = new TeamForm())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        team = frm.get_team();
                    }
                }

                int goal = -1;
                using (GoalForm frm = new GoalForm())
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        goal = frm.get_goal();
                    }
                }

                if (goal == 0)
                {
                    d[e.ColumnIndex, e.RowIndex].Value = d[e.ColumnIndex, e.RowIndex].Value + " " + "未进球";
                }
                else if (goal == 1)
                {
                    d[e.ColumnIndex, e.RowIndex].Value = d[e.ColumnIndex, e.RowIndex].Value + " " + "乌龙";
                    this.alter_score(team);
                }
                else if (goal == 2)
                {
                    d[e.ColumnIndex, e.RowIndex].Value = d[e.ColumnIndex, e.RowIndex].Value + " " + "进球";
                    this.alter_score(team);
                }

            }
        }

        private void alter_score(int team)
        {
            int t;
            if (team == 0) t = 3;
            else t = 7;

            string ss = this.score.Text;
            int num = (int)(this.score.Text[t]);
            num += 1;
            ss = ss.Remove(t, 1);
            ss = ss.Insert(t, Convert.ToString(num - 48));
            this.score.Text = ss;
        }

        public bool get_isStart()
        {
            return this.isStart;
        }

        /// <summary>
        /// 更改暂停按钮的信息
        /// </summary>
        /// <param name="s"></param>
        public void set_stop(string s)
        {
            this.stop.Text = s;
        }
    }
}
