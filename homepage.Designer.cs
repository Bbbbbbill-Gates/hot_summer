namespace hot_summer
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.headPic = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.recordBtn = new System.Windows.Forms.Button();
            this.leftBg = new System.Windows.Forms.Button();
            this.userBg = new System.Windows.Forms.Button();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.headPic_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.data_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // headPic
            // 
            this.headPic.BackColor = System.Drawing.Color.White;
            this.headPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headPic.BackgroundImage")));
            this.headPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.headPic.Location = new System.Drawing.Point(36, 10);
            this.headPic.Margin = new System.Windows.Forms.Padding(2);
            this.headPic.Name = "headPic";
            this.headPic.Size = new System.Drawing.Size(44, 46);
            this.headPic.TabIndex = 3;
            this.headPic.UseVisualStyleBackColor = false;
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.SystemColors.Control;
            this.userBtn.Location = new System.Drawing.Point(2, 66);
            this.userBtn.Margin = new System.Windows.Forms.Padding(2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(194, 67);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "用户信息";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.BackColor = System.Drawing.SystemColors.Control;
            this.recordBtn.Location = new System.Drawing.Point(2, 130);
            this.recordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(194, 67);
            this.recordBtn.TabIndex = 5;
            this.recordBtn.Text = "工作记录";
            this.recordBtn.UseVisualStyleBackColor = false;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // leftBg
            // 
            this.leftBg.BackColor = System.Drawing.SystemColors.Control;
            this.leftBg.Enabled = false;
            this.leftBg.Location = new System.Drawing.Point(2, 2);
            this.leftBg.Margin = new System.Windows.Forms.Padding(2);
            this.leftBg.Name = "leftBg";
            this.leftBg.Size = new System.Drawing.Size(194, 621);
            this.leftBg.TabIndex = 6;
            this.leftBg.UseVisualStyleBackColor = false;
            // 
            // userBg
            // 
            this.userBg.BackColor = System.Drawing.Color.White;
            this.userBg.Location = new System.Drawing.Point(2, -2);
            this.userBg.Margin = new System.Windows.Forms.Padding(2);
            this.userBg.Name = "userBg";
            this.userBg.Size = new System.Drawing.Size(194, 67);
            this.userBg.TabIndex = 9;
            this.userBg.UseVisualStyleBackColor = false;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Location = new System.Drawing.Point(265, 119);
            this.userName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(53, 12);
            this.userName_lbl.TabIndex = 10;
            this.userName_lbl.Text = "用户名：";
            // 
            // headPic_lbl
            // 
            this.headPic_lbl.AutoSize = true;
            this.headPic_lbl.Location = new System.Drawing.Point(265, 66);
            this.headPic_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headPic_lbl.Name = "headPic_lbl";
            this.headPic_lbl.Size = new System.Drawing.Size(41, 12);
            this.headPic_lbl.TabIndex = 11;
            this.headPic_lbl.Text = "头像：";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(265, 172);
            this.phone_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(53, 12);
            this.phone_lbl.TabIndex = 12;
            this.phone_lbl.Text = "手机号：";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(265, 225);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(41, 12);
            this.email_lbl.TabIndex = 13;
            this.email_lbl.Text = "邮箱：";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(265, 278);
            this.address_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(41, 12);
            this.address_lbl.TabIndex = 14;
            this.address_lbl.Text = "地址：";
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(267, 331);
            this.change_btn.Margin = new System.Windows.Forms.Padding(2);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 40);
            this.change_btn.TabIndex = 15;
            this.change_btn.Text = "修改资料";
            this.change_btn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 63);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 20);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(346, 63);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(50, 20);
            this.comboBox2.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(424, 63);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(50, 20);
            this.comboBox3.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 21);
            this.textBox1.TabIndex = 20;
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(582, 63);
            this.select_btn.Margin = new System.Windows.Forms.Padding(2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(56, 18);
            this.select_btn.TabIndex = 21;
            this.select_btn.Text = "查询";
            this.select_btn.UseVisualStyleBackColor = true;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(668, 63);
            this.export_btn.Margin = new System.Windows.Forms.Padding(2);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(56, 18);
            this.export_btn.TabIndex = 22;
            this.export_btn.Text = "导出";
            this.export_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allSelect,
            this.data_grid,
            this.time_grid,
            this.state,
            this.game_name,
            this.team1,
            this.team2,
            this.referee});
            this.dataGridView1.Location = new System.Drawing.Point(267, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(458, 250);
            this.dataGridView1.TabIndex = 23;
            // 
            // allSelect
            // 
            this.allSelect.HeaderText = "全选";
            this.allSelect.MinimumWidth = 6;
            this.allSelect.Name = "allSelect";
            this.allSelect.Width = 30;
            // 
            // data_grid
            // 
            this.data_grid.HeaderText = "日期";
            this.data_grid.MinimumWidth = 6;
            this.data_grid.Name = "data_grid";
            this.data_grid.Width = 80;
            // 
            // time_grid
            // 
            this.time_grid.HeaderText = "时间";
            this.time_grid.MinimumWidth = 6;
            this.time_grid.Name = "time_grid";
            this.time_grid.Width = 80;
            // 
            // state
            // 
            this.state.HeaderText = "状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.Width = 80;
            // 
            // game_name
            // 
            this.game_name.HeaderText = "比赛名称";
            this.game_name.MinimumWidth = 6;
            this.game_name.Name = "game_name";
            this.game_name.Width = 80;
            // 
            // team1
            // 
            this.team1.HeaderText = "主队";
            this.team1.MinimumWidth = 6;
            this.team1.Name = "team1";
            this.team1.Width = 80;
            // 
            // team2
            // 
            this.team2.HeaderText = "客队";
            this.team2.MinimumWidth = 6;
            this.team2.Name = "team2";
            this.team2.Width = 80;
            // 
            // referee
            // 
            this.referee.HeaderText = "裁判员";
            this.referee.MinimumWidth = 6;
            this.referee.Name = "referee";
            this.referee.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "userName";
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 620);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.headPic_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.headPic);
            this.Controls.Add(this.userBg);
            this.Controls.Add(this.leftBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "homepage";
            this.ShowIcon = false;
            this.Text = "数据采集系统V1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.homepage_FormClosed);
            this.Load += new System.EventHandler(this.homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button headPic;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button leftBg;
        private System.Windows.Forms.Button userBg;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label headPic_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2;
        private System.Windows.Forms.DataGridViewTextBoxColumn referee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}