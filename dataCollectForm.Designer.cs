﻿namespace hot_summer
{
    partial class dataCollectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataCollectForm));
            this.score = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Button();
            this.halfTimeChoice = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinateOfReferee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventOfGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinateOfEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refereeData = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.点球ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角球ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.界外球ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.球门球ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中圈开球ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.间接任意ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直接任意ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.White;
            this.score.Enabled = false;
            this.score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score.Location = new System.Drawing.Point(12, 32);
            this.score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(296, 28);
            this.score.TabIndex = 0;
            this.score.Text = "主队 0 : 0 客队";
            this.score.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.White;
            this.time.Enabled = false;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Location = new System.Drawing.Point(12, 78);
            this.time.Margin = new System.Windows.Forms.Padding(1);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(156, 28);
            this.time.TabIndex = 1;
            this.time.Text = "比赛时间 00 : 00";
            this.time.UseVisualStyleBackColor = false;
            // 
            // halfTimeChoice
            // 
            this.halfTimeChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.halfTimeChoice.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.halfTimeChoice.FormattingEnabled = true;
            this.halfTimeChoice.Items.AddRange(new object[] {
            "上半场",
            "下半场"});
            this.halfTimeChoice.Location = new System.Drawing.Point(187, 78);
            this.halfTimeChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.halfTimeChoice.Name = "halfTimeChoice";
            this.halfTimeChoice.Size = new System.Drawing.Size(121, 26);
            this.halfTimeChoice.TabIndex = 2;
            this.halfTimeChoice.DropDown += new System.EventHandler(this.halfTimeChoice_DropDown);
            this.halfTimeChoice.SelectedIndexChanged += new System.EventHandler(this.halfTime_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(339, 40);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(80, 60);
            this.start.TabIndex = 3;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stop.Location = new System.Drawing.Point(467, 41);
            this.stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(80, 60);
            this.stop.TabIndex = 4;
            this.stop.Text = "暂停";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-63, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1107, 623);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.timeOfEvent,
            this.coordinateOfReferee,
            this.eventOfGame,
            this.coordinateOfEvent});
            this.dataGridView1.Location = new System.Drawing.Point(12, 795);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(957, 120);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // number
            // 
            this.number.HeaderText = "序号";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // timeOfEvent
            // 
            this.timeOfEvent.HeaderText = "时间";
            this.timeOfEvent.MinimumWidth = 6;
            this.timeOfEvent.Name = "timeOfEvent";
            this.timeOfEvent.Width = 125;
            // 
            // coordinateOfReferee
            // 
            this.coordinateOfReferee.HeaderText = "裁判员坐标";
            this.coordinateOfReferee.MinimumWidth = 6;
            this.coordinateOfReferee.Name = "coordinateOfReferee";
            this.coordinateOfReferee.Width = 125;
            // 
            // eventOfGame
            // 
            this.eventOfGame.HeaderText = "事件";
            this.eventOfGame.MinimumWidth = 6;
            this.eventOfGame.Name = "eventOfGame";
            this.eventOfGame.Width = 240;
            // 
            // coordinateOfEvent
            // 
            this.coordinateOfEvent.HeaderText = "事件坐标";
            this.coordinateOfEvent.MinimumWidth = 6;
            this.coordinateOfEvent.Name = "coordinateOfEvent";
            this.coordinateOfEvent.Width = 125;
            // 
            // refereeData
            // 
            this.refereeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refereeData.AutoSize = true;
            this.refereeData.Location = new System.Drawing.Point(174, 763);
            this.refereeData.Name = "refereeData";
            this.refereeData.Size = new System.Drawing.Size(632, 15);
            this.refereeData.TabIndex = 9;
            this.refereeData.Text = "主裁判：       第一助理裁判：        第二助理裁判：         第四官员：           ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入视频ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.结束ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 导入视频ToolStripMenuItem
            // 
            this.导入视频ToolStripMenuItem.Name = "导入视频ToolStripMenuItem";
            this.导入视频ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.导入视频ToolStripMenuItem.Text = "导入视频";
            this.导入视频ToolStripMenuItem.Click += new System.EventHandler(this.导入视频ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 结束ToolStripMenuItem
            // 
            this.结束ToolStripMenuItem.Name = "结束ToolStripMenuItem";
            this.结束ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.结束ToolStripMenuItem.Text = "结束";
            this.结束ToolStripMenuItem.Click += new System.EventHandler(this.结束ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 100);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.toolStripMenuItem1.Text = "犯规";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(123, 24);
            this.toolStripMenuItem2.Text = "越位";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(123, 24);
            this.toolStripMenuItem3.Text = "射门";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点球ToolStripMenuItem,
            this.角球ToolStripMenuItem,
            this.界外球ToolStripMenuItem,
            this.球门球ToolStripMenuItem,
            this.中圈开球ToolStripMenuItem,
            this.间接任意ToolStripMenuItem,
            this.直接任意ToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(123, 24);
            this.toolStripMenuItem4.Text = "定位球";
            // 
            // 点球ToolStripMenuItem
            // 
            this.点球ToolStripMenuItem.Name = "点球ToolStripMenuItem";
            this.点球ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.点球ToolStripMenuItem.Text = "点球";
            this.点球ToolStripMenuItem.Click += new System.EventHandler(this.点球ToolStripMenuItem_Click);
            // 
            // 角球ToolStripMenuItem
            // 
            this.角球ToolStripMenuItem.Name = "角球ToolStripMenuItem";
            this.角球ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.角球ToolStripMenuItem.Text = "角球";
            this.角球ToolStripMenuItem.Click += new System.EventHandler(this.角球ToolStripMenuItem_Click);
            // 
            // 界外球ToolStripMenuItem
            // 
            this.界外球ToolStripMenuItem.Name = "界外球ToolStripMenuItem";
            this.界外球ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.界外球ToolStripMenuItem.Text = "界外球";
            this.界外球ToolStripMenuItem.Click += new System.EventHandler(this.界外球ToolStripMenuItem_Click);
            // 
            // 球门球ToolStripMenuItem
            // 
            this.球门球ToolStripMenuItem.Name = "球门球ToolStripMenuItem";
            this.球门球ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.球门球ToolStripMenuItem.Text = "球门球";
            this.球门球ToolStripMenuItem.Click += new System.EventHandler(this.球门球ToolStripMenuItem_Click);
            // 
            // 中圈开球ToolStripMenuItem
            // 
            this.中圈开球ToolStripMenuItem.Name = "中圈开球ToolStripMenuItem";
            this.中圈开球ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.中圈开球ToolStripMenuItem.Text = "中圈开球";
            this.中圈开球ToolStripMenuItem.Click += new System.EventHandler(this.中圈开球ToolStripMenuItem_Click);
            // 
            // 间接任意ToolStripMenuItem
            // 
            this.间接任意ToolStripMenuItem.Name = "间接任意ToolStripMenuItem";
            this.间接任意ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.间接任意ToolStripMenuItem.Text = "间接任意";
            this.间接任意ToolStripMenuItem.Click += new System.EventHandler(this.间接任意ToolStripMenuItem_Click);
            // 
            // 直接任意ToolStripMenuItem
            // 
            this.直接任意ToolStripMenuItem.Name = "直接任意ToolStripMenuItem";
            this.直接任意ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.直接任意ToolStripMenuItem.Text = "直接任意";
            this.直接任意ToolStripMenuItem.Click += new System.EventHandler(this.直接任意ToolStripMenuItem_Click);
            // 
            // dataCollectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refereeData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.halfTimeChoice);
            this.Controls.Add(this.time);
            this.Controls.Add(this.score);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "dataCollectForm";
            this.Text = "dataCollectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dataCollectForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dataCollectForm_FormClosed);
            this.Load += new System.EventHandler(this.dataCollectForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataCollectForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button score;
        private System.Windows.Forms.Button time;
        private System.Windows.Forms.ComboBox halfTimeChoice;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinateOfReferee;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventOfGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinateOfEvent;
        private System.Windows.Forms.Label refereeData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入视频ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 点球ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角球ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 界外球ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 球门球ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中圈开球ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 间接任意ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直接任意ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结束ToolStripMenuItem;
    }
}