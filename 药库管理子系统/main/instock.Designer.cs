namespace main
{
    partial class instock
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
            this.dtp_Instockdate = new System.Windows.Forms.DateTimePicker();
            this.comb_User = new System.Windows.Forms.ComboBox();
            this.comb_Medicinename = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Inprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Inamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.But_ExitInstock = new System.Windows.Forms.Button();
            this.txt_InNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.But_InStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Instockdate
            // 
            this.dtp_Instockdate.Location = new System.Drawing.Point(90, 164);
            this.dtp_Instockdate.Name = "dtp_Instockdate";
            this.dtp_Instockdate.Size = new System.Drawing.Size(148, 21);
            this.dtp_Instockdate.TabIndex = 15;
            this.dtp_Instockdate.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            // 
            // comb_User
            // 
            this.comb_User.FormattingEnabled = true;
            this.comb_User.Location = new System.Drawing.Point(90, 114);
            this.comb_User.Name = "comb_User";
            this.comb_User.Size = new System.Drawing.Size(88, 20);
            this.comb_User.TabIndex = 14;
            // 
            // comb_Medicinename
            // 
            this.comb_Medicinename.FormattingEnabled = true;
            this.comb_Medicinename.Location = new System.Drawing.Point(267, 23);
            this.comb_Medicinename.Name = "comb_Medicinename";
            this.comb_Medicinename.Size = new System.Drawing.Size(100, 20);
            this.comb_Medicinename.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "入库日期";
            // 
            // txt_Inprice
            // 
            this.txt_Inprice.Location = new System.Drawing.Point(267, 61);
            this.txt_Inprice.Name = "txt_Inprice";
            this.txt_Inprice.Size = new System.Drawing.Size(100, 21);
            this.txt_Inprice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "进价";
            // 
            // txt_Inamount
            // 
            this.txt_Inamount.Location = new System.Drawing.Point(78, 62);
            this.txt_Inamount.Name = "txt_Inamount";
            this.txt_Inamount.Size = new System.Drawing.Size(100, 21);
            this.txt_Inamount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数量";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(21, 117);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(41, 12);
            this.lable3.TabIndex = 4;
            this.lable3.Text = "操作员";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(207, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "药品名称";
            // 
            // But_ExitInstock
            // 
            this.But_ExitInstock.Location = new System.Drawing.Point(419, 324);
            this.But_ExitInstock.Name = "But_ExitInstock";
            this.But_ExitInstock.Size = new System.Drawing.Size(91, 47);
            this.But_ExitInstock.TabIndex = 8;
            this.But_ExitInstock.Text = "退出";
            this.But_ExitInstock.UseVisualStyleBackColor = true;
            this.But_ExitInstock.Click += new System.EventHandler(this.But_ExitInstock_Click);
            // 
            // txt_InNo
            // 
            this.txt_InNo.Location = new System.Drawing.Point(78, 18);
            this.txt_InNo.Name = "txt_InNo";
            this.txt_InNo.Size = new System.Drawing.Size(100, 21);
            this.txt_InNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "入库单号";
            // 
            // But_InStock
            // 
            this.But_InStock.Location = new System.Drawing.Point(293, 324);
            this.But_InStock.Name = "But_InStock";
            this.But_InStock.Size = new System.Drawing.Size(91, 47);
            this.But_InStock.TabIndex = 7;
            this.But_InStock.Text = "确认入库";
            this.But_InStock.UseVisualStyleBackColor = true;
            this.But_InStock.Click += new System.EventHandler(this.But_InStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Instockdate);
            this.groupBox1.Controls.Add(this.comb_User);
            this.groupBox1.Controls.Add(this.comb_Medicinename);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Inprice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Inamount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txt_InNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 346);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // instock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 434);
            this.Controls.Add(this.But_ExitInstock);
            this.Controls.Add(this.But_InStock);
            this.Controls.Add(this.groupBox1);
            this.Name = "instock";
            this.Text = "入库录入";
            this.Load += new System.EventHandler(this.instock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Instockdate;
        private System.Windows.Forms.ComboBox comb_User;
        private System.Windows.Forms.ComboBox comb_Medicinename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Inprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Inamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button But_ExitInstock;
        private System.Windows.Forms.TextBox txt_InNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_InStock;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}