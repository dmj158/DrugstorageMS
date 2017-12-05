namespace main
{
    partial class outstock
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
            this.But_ExitInstock = new System.Windows.Forms.Button();
            this.But_InStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_pharmacy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_outdate = new System.Windows.Forms.DateTimePicker();
            this.comb_username = new System.Windows.Forms.ComboBox();
            this.comb_Medicinename = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_outamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_outId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_outstock = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outstock)).BeginInit();
            this.SuspendLayout();
            // 
            // But_ExitInstock
            // 
            this.But_ExitInstock.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_ExitInstock.Location = new System.Drawing.Point(631, 177);
            this.But_ExitInstock.Name = "But_ExitInstock";
            this.But_ExitInstock.Size = new System.Drawing.Size(84, 38);
            this.But_ExitInstock.TabIndex = 13;
            this.But_ExitInstock.Text = "退出";
            this.But_ExitInstock.UseVisualStyleBackColor = true;
            this.But_ExitInstock.Click += new System.EventHandler(this.But_ExitInstock_Click);
            // 
            // But_InStock
            // 
            this.But_InStock.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_InStock.Location = new System.Drawing.Point(383, 177);
            this.But_InStock.Name = "But_InStock";
            this.But_InStock.Size = new System.Drawing.Size(84, 38);
            this.But_InStock.TabIndex = 12;
            this.But_InStock.Text = "确认出库";
            this.But_InStock.UseVisualStyleBackColor = true;
            this.But_InStock.Click += new System.EventHandler(this.But_InStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.But_ExitInstock);
            this.groupBox1.Controls.Add(this.comb_pharmacy);
            this.groupBox1.Controls.Add(this.But_InStock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_outdate);
            this.groupBox1.Controls.Add(this.comb_username);
            this.groupBox1.Controls.Add(this.comb_Medicinename);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_outamount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txt_outId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // comb_pharmacy
            // 
            this.comb_pharmacy.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_pharmacy.FormattingEnabled = true;
            this.comb_pharmacy.Location = new System.Drawing.Point(436, 72);
            this.comb_pharmacy.Name = "comb_pharmacy";
            this.comb_pharmacy.Size = new System.Drawing.Size(130, 22);
            this.comb_pharmacy.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(318, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "二级药房";
            // 
            // dtp_outdate
            // 
            this.dtp_outdate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_outdate.Location = new System.Drawing.Point(102, 150);
            this.dtp_outdate.Name = "dtp_outdate";
            this.dtp_outdate.Size = new System.Drawing.Size(130, 23);
            this.dtp_outdate.TabIndex = 11;
            // 
            // comb_username
            // 
            this.comb_username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_username.FormattingEnabled = true;
            this.comb_username.Location = new System.Drawing.Point(102, 107);
            this.comb_username.Name = "comb_username";
            this.comb_username.Size = new System.Drawing.Size(130, 22);
            this.comb_username.TabIndex = 9;
            // 
            // comb_Medicinename
            // 
            this.comb_Medicinename.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_Medicinename.FormattingEnabled = true;
            this.comb_Medicinename.Location = new System.Drawing.Point(436, 28);
            this.comb_Medicinename.Name = "comb_Medicinename";
            this.comb_Medicinename.Size = new System.Drawing.Size(130, 22);
            this.comb_Medicinename.TabIndex = 3;
            this.comb_Medicinename.SelectedIndexChanged += new System.EventHandler(this.comb_Medicinename_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(31, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "出库日期";
            // 
            // txt_outamount
            // 
            this.txt_outamount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_outamount.Location = new System.Drawing.Point(102, 66);
            this.txt_outamount.Name = "txt_outamount";
            this.txt_outamount.Size = new System.Drawing.Size(130, 23);
            this.txt_outamount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "数量";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable3.Location = new System.Drawing.Point(33, 110);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(63, 14);
            this.lable3.TabIndex = 8;
            this.lable3.Text = "操作人员";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(318, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 14);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "药品名称";
            // 
            // txt_outId
            // 
            this.txt_outId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_outId.Location = new System.Drawing.Point(102, 22);
            this.txt_outId.Name = "txt_outId";
            this.txt_outId.Size = new System.Drawing.Size(130, 23);
            this.txt_outId.TabIndex = 1;
            this.txt_outId.TextChanged += new System.EventHandler(this.txt_outId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "出库单号";
            // 
            // dgv_outstock
            // 
            this.dgv_outstock.AllowUserToAddRows = false;
            this.dgv_outstock.AllowUserToDeleteRows = false;
            this.dgv_outstock.AllowUserToResizeColumns = false;
            this.dgv_outstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_outstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_outstock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_outstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outstock.Location = new System.Drawing.Point(12, 267);
            this.dgv_outstock.Name = "dgv_outstock";
            this.dgv_outstock.RowTemplate.Height = 23;
            this.dgv_outstock.Size = new System.Drawing.Size(760, 283);
            this.dgv_outstock.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(508, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgv_outstock);
            this.Controls.Add(this.groupBox1);
            this.Name = "outstock";
            this.Text = "出库录入";
            this.Load += new System.EventHandler(this.outstock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outstock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_ExitInstock;
        private System.Windows.Forms.Button But_InStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_outdate;
        private System.Windows.Forms.ComboBox comb_username;
        private System.Windows.Forms.ComboBox comb_Medicinename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_outamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txt_outId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_pharmacy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_outstock;
        private System.Windows.Forms.Button button1;
    }
}