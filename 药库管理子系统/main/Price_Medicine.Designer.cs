namespace main
{
    partial class Price_Medicine
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
            this.Txt_MName = new System.Windows.Forms.TextBox();
            this.Lab_Record = new System.Windows.Forms.Label();
            this.But_PInquiry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.But_Refresh = new System.Windows.Forms.Button();
            this.GB_Message = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_People = new System.Windows.Forms.TextBox();
            this.Txt_Mrefresh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GB_Message.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品名称";
            // 
            // Txt_MName
            // 
            this.Txt_MName.Location = new System.Drawing.Point(73, 19);
            this.Txt_MName.Name = "Txt_MName";
            this.Txt_MName.Size = new System.Drawing.Size(100, 21);
            this.Txt_MName.TabIndex = 1;
            // 
            // Lab_Record
            // 
            this.Lab_Record.AutoSize = true;
            this.Lab_Record.Location = new System.Drawing.Point(16, 51);
            this.Lab_Record.Name = "Lab_Record";
            this.Lab_Record.Size = new System.Drawing.Size(0, 12);
            this.Lab_Record.TabIndex = 2;
            // 
            // But_PInquiry
            // 
            this.But_PInquiry.Location = new System.Drawing.Point(255, 17);
            this.But_PInquiry.Name = "But_PInquiry";
            this.But_PInquiry.Size = new System.Drawing.Size(80, 23);
            this.But_PInquiry.TabIndex = 3;
            this.But_PInquiry.Text = "查询";
            this.But_PInquiry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "药品类型";
            // 
            // Txt_MType
            // 
            this.Txt_MType.Location = new System.Drawing.Point(82, 20);
            this.Txt_MType.Name = "Txt_MType";
            this.Txt_MType.Size = new System.Drawing.Size(100, 21);
            this.Txt_MType.TabIndex = 5;
            this.Txt_MType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数量";
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Location = new System.Drawing.Point(82, 56);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(100, 21);
            this.Txt_Amount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "价格";
            // 
            // Txt_Price
            // 
            this.Txt_Price.Location = new System.Drawing.Point(82, 93);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(100, 21);
            this.Txt_Price.TabIndex = 9;
            // 
            // But_Refresh
            // 
            this.But_Refresh.Location = new System.Drawing.Point(355, 17);
            this.But_Refresh.Name = "But_Refresh";
            this.But_Refresh.Size = new System.Drawing.Size(80, 23);
            this.But_Refresh.TabIndex = 3;
            this.But_Refresh.Text = "调价更新";
            this.But_Refresh.UseVisualStyleBackColor = true;
            // 
            // GB_Message
            // 
            this.GB_Message.Controls.Add(this.label2);
            this.GB_Message.Controls.Add(this.label3);
            this.GB_Message.Controls.Add(this.Txt_Price);
            this.GB_Message.Controls.Add(this.Txt_Amount);
            this.GB_Message.Controls.Add(this.label4);
            this.GB_Message.Controls.Add(this.Txt_MType);
            this.GB_Message.Location = new System.Drawing.Point(18, 65);
            this.GB_Message.Name = "GB_Message";
            this.GB_Message.Size = new System.Drawing.Size(338, 133);
            this.GB_Message.TabIndex = 10;
            this.GB_Message.TabStop = false;
            this.GB_Message.Text = "药品基本信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_People);
            this.groupBox1.Controls.Add(this.Txt_Mrefresh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 137);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "药价更新";
            // 
            // Txt_People
            // 
            this.Txt_People.Location = new System.Drawing.Point(82, 69);
            this.Txt_People.Name = "Txt_People";
            this.Txt_People.Size = new System.Drawing.Size(100, 21);
            this.Txt_People.TabIndex = 3;
            // 
            // Txt_Mrefresh
            // 
            this.Txt_Mrefresh.Location = new System.Drawing.Point(83, 30);
            this.Txt_Mrefresh.Name = "Txt_Mrefresh";
            this.Txt_Mrefresh.Size = new System.Drawing.Size(100, 21);
            this.Txt_Mrefresh.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "操作人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "药品新价";
            // 
            // Price_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_Message);
            this.Controls.Add(this.But_Refresh);
            this.Controls.Add(this.But_PInquiry);
            this.Controls.Add(this.Lab_Record);
            this.Controls.Add(this.Txt_MName);
            this.Controls.Add(this.label1);
            this.Name = "Price_Medicine";
            this.Text = "药品调价管理";
            this.Load += new System.EventHandler(this.Price_Load);
            this.GB_Message.ResumeLayout(false);
            this.GB_Message.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_MName;
        private System.Windows.Forms.Label Lab_Record;
        private System.Windows.Forms.Button But_PInquiry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_MType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Button But_Refresh;
        private System.Windows.Forms.GroupBox GB_Message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_People;
        private System.Windows.Forms.TextBox Txt_Mrefresh;

    }
}