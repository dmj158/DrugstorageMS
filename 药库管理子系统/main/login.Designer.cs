namespace main
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpasscode = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.but_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(389, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(389, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(465, 199);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(149, 21);
            this.textuser.TabIndex = 2;
            // 
            // textpasscode
            // 
            this.textpasscode.Location = new System.Drawing.Point(465, 250);
            this.textpasscode.Name = "textpasscode";
            this.textpasscode.PasswordChar = '*';
<<<<<<< HEAD
            this.textpasscode.Size = new System.Drawing.Size(149, 21);
=======
            this.textpasscode.Size = new System.Drawing.Size(110, 21);
>>>>>>> origin/master
            this.textpasscode.TabIndex = 3;
            // 
            // but_login
            // 
            this.but_login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_login.Location = new System.Drawing.Point(422, 302);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 25);
            this.but_login.TabIndex = 5;
            this.but_login.Text = "登陆";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_quit
            // 
            this.but_quit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_quit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_quit.Location = new System.Drawing.Point(554, 302);
            this.but_quit.Name = "but_quit";
            this.but_quit.Size = new System.Drawing.Size(75, 25);
            this.but_quit.TabIndex = 6;
            this.but_quit.Text = "退出 ";
            this.but_quit.UseVisualStyleBackColor = true;
            this.but_quit.Click += new System.EventHandler(this.but_quit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 422);
            this.Controls.Add(this.but_quit);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.textpasscode);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药库管理系统 1.0Copyright（C）2017 king_4小组";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpasscode;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_quit;
    }
}