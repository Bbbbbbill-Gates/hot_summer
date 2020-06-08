namespace hot_summer
{
    partial class signIn
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
            this.sign = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_userName = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sign.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sign.Location = new System.Drawing.Point(14, 156);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(105, 40);
            this.sign.TabIndex = 0;
            this.sign.Text = "登陆";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(317, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_userName
            // 
            this.text_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_userName.Location = new System.Drawing.Point(106, 6);
            this.text_userName.Name = "text_userName";
            this.text_userName.Size = new System.Drawing.Size(316, 25);
            this.text_userName.TabIndex = 2;
            // 
            // text_password
            // 
            this.text_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_password.Location = new System.Drawing.Point(106, 72);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '●';
            this.text_password.Size = new System.Drawing.Size(316, 25);
            this.text_password.TabIndex = 3;
            this.text_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_password_KeyDown);
            // 
            // userName
            // 
            this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(8, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(92, 31);
            this.userName.TabIndex = 4;
            this.userName.Text = "用户名:";
            // 
            // userPassword
            // 
            this.userPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPassword.AutoSize = true;
            this.userPassword.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPassword.Location = new System.Drawing.Point(8, 66);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(89, 31);
            this.userPassword.TabIndex = 5;
            this.userPassword.Text = "密   码:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.userPassword);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.sign);
            this.panel1.Controls.Add(this.text_password);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.text_userName);
            this.panel1.Location = new System.Drawing.Point(182, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 202);
            this.panel1.TabIndex = 6;
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "signIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_userName;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.Panel panel1;
    }
}