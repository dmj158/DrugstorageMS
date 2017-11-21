namespace main
{
    partial class alterpsw
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
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.txt_cpsw = new System.Windows.Forms.TextBox();
            this.but_alterpsw = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "确认密码";
            // 
            // txt_psw
            // 
            this.txt_psw.Location = new System.Drawing.Point(113, 67);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.PasswordChar = '*';
            this.txt_psw.Size = new System.Drawing.Size(100, 21);
            this.txt_psw.TabIndex = 2;
            // 
            // txt_cpsw
            // 
            this.txt_cpsw.Location = new System.Drawing.Point(113, 116);
            this.txt_cpsw.Name = "txt_cpsw";
            this.txt_cpsw.PasswordChar = '*';
            this.txt_cpsw.Size = new System.Drawing.Size(100, 21);
            this.txt_cpsw.TabIndex = 3;
            // 
            // but_alterpsw
            // 
            this.but_alterpsw.Location = new System.Drawing.Point(39, 187);
            this.but_alterpsw.Name = "but_alterpsw";
            this.but_alterpsw.Size = new System.Drawing.Size(75, 23);
            this.but_alterpsw.TabIndex = 4;
            this.but_alterpsw.Text = "确认";
            this.but_alterpsw.UseVisualStyleBackColor = true;
            this.but_alterpsw.Click += new System.EventHandler(this.but_alterpsw_Click);
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(166, 187);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(75, 23);
            this.but_close.TabIndex = 5;
            this.but_close.Text = "取消";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "操作员";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(113, 29);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(41, 12);
            this.lab_username.TabIndex = 7;
            this.lab_username.Text = "label4";
            // 
            // alterpsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 274);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_alterpsw);
            this.Controls.Add(this.txt_cpsw);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alterpsw";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.alterpsw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.TextBox txt_cpsw;
        private System.Windows.Forms.Button but_alterpsw;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_username;
    }
}