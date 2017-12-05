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
            this.dgv_instock = new System.Windows.Forms.DataGridView();
            this.bt_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Instockdate
            // 
            this.dtp_Instockdate.Location = new System.Drawing.Point(122, 160);
            this.dtp_Instockdate.Name = "dtp_Instockdate";
            this.dtp_Instockdate.Size = new System.Drawing.Size(159, 23);
            this.dtp_Instockdate.TabIndex = 11;
            this.dtp_Instockdate.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            // 
            // comb_User
            // 
            this.comb_User.FormattingEnabled = true;
            this.comb_User.Location = new System.Drawing.Point(122, 110);
            this.comb_User.Name = "comb_User";
            this.comb_User.Size = new System.Drawing.Size(159, 22);
            this.comb_User.TabIndex = 9;
            // 
            // comb_Medicinename
            // 
            this.comb_Medicinename.FormattingEnabled = true;
            this.comb_Medicinename.Location = new System.Drawing.Point(439, 31);
            this.comb_Medicinename.Name = "comb_Medicinename";
            this.comb_Medicinename.Size = new System.Drawing.Size(145, 22);
            this.comb_Medicinename.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "入库日期";
            // 
            // txt_Inprice
            // 
            this.txt_Inprice.Location = new System.Drawing.Point(439, 75);
            this.txt_Inprice.Name = "txt_Inprice";
            this.txt_Inprice.Size = new System.Drawing.Size(145, 23);
            this.txt_Inprice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "进价";
            // 
            // txt_Inamount
            // 
            this.txt_Inamount.Location = new System.Drawing.Point(122, 70);
            this.txt_Inamount.Name = "txt_Inamount";
            this.txt_Inamount.Size = new System.Drawing.Size(159, 23);
            this.txt_Inamount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "数量";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(24, 118);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(49, 14);
            this.lable3.TabIndex = 8;
            this.lable3.Text = "操作员";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(356, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 14);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "药品名称";
            // 
            // But_ExitInstock
            // 
            this.But_ExitInstock.Location = new System.Drawing.Point(642, 177);
            this.But_ExitInstock.Name = "But_ExitInstock";
            this.But_ExitInstock.Size = new System.Drawing.Size(79, 34);
            this.But_ExitInstock.TabIndex = 14;
            this.But_ExitInstock.Text = "退出";
            this.But_ExitInstock.UseVisualStyleBackColor = true;
            this.But_ExitInstock.Click += new System.EventHandler(this.But_ExitInstock_Click);
            // 
            // txt_InNo
            // 
            this.txt_InNo.Location = new System.Drawing.Point(122, 28);
            this.txt_InNo.Name = "txt_InNo";
            this.txt_InNo.Size = new System.Drawing.Size(159, 23);
            this.txt_InNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "入库单号";
            // 
            // But_InStock
            // 
            this.But_InStock.Location = new System.Drawing.Point(416, 177);
            this.But_InStock.Name = "But_InStock";
            this.But_InStock.Size = new System.Drawing.Size(76, 34);
            this.But_InStock.TabIndex = 12;
            this.But_InStock.Text = "确认入库";
            this.But_InStock.UseVisualStyleBackColor = true;
            this.But_InStock.Click += new System.EventHandler(this.But_InStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_clear);
            this.groupBox1.Controls.Add(this.But_ExitInstock);
            this.groupBox1.Controls.Add(this.dtp_Instockdate);
            this.groupBox1.Controls.Add(this.But_InStock);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dgv_instock
            // 
            this.dgv_instock.AllowUserToAddRows = false;
            this.dgv_instock.AllowUserToDeleteRows = false;
            this.dgv_instock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_instock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_instock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_instock.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_instock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instock.Location = new System.Drawing.Point(12, 262);
            this.dgv_instock.Name = "dgv_instock";
            this.dgv_instock.ReadOnly = true;
            this.dgv_instock.RowTemplate.Height = 23;
            this.dgv_instock.Size = new System.Drawing.Size(760, 290);
            this.dgv_instock.TabIndex = 7;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(529, 177);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(76, 34);
            this.bt_clear.TabIndex = 13;
            this.bt_clear.Text = "清空";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // instock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgv_instock);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "instock";
            this.Text = "入库录入";
            this.Load += new System.EventHandler(this.instock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instock)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_instock;
        private System.Windows.Forms.Button bt_clear;
    }
}