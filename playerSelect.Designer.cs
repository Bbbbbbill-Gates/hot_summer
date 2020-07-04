namespace hot_summer
{
    partial class playerSelect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.player_game});
            this.dataGridView1.Location = new System.Drawing.Point(90, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_out,
            this.player_out});
            this.dataGridView2.Location = new System.Drawing.Point(423, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.HeaderText = "号码";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            // 
            // player_game
            // 
            this.player_game.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.player_game.HeaderText = "场上球员";
            this.player_game.MinimumWidth = 6;
            this.player_game.Name = "player_game";
            // 
            // number_out
            // 
            this.number_out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number_out.HeaderText = "号码";
            this.number_out.MinimumWidth = 6;
            this.number_out.Name = "number_out";
            // 
            // player_out
            // 
            this.player_out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.player_out.HeaderText = "场下球员";
            this.player_out.MinimumWidth = 6;
            this.player_out.Name = "player_out";
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(543, 195);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(120, 45);
            this.finish.TabIndex = 2;
            this.finish.Text = "完成";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(381, 195);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 45);
            this.back.TabIndex = 3;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // playerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 261);
            this.Controls.Add(this.back);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "playerSelect";
            this.Text = "playerSelect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.playerSelect_FormClosing);
            this.Load += new System.EventHandler(this.playerSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_game;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_out;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button back;
    }
}