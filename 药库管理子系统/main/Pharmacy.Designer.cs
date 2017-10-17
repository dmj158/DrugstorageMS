namespace main
{
    partial class Pharmacy
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
            this.Txt_MNameOut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.But_InquiryOut = new System.Windows.Forms.Button();
            this.But_OutComfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.Txt_PriceIn = new System.Windows.Forms.TextBox();
            this.Txt_PriceSale = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_GoWhere = new System.Windows.Forms.TextBox();
            this.Txt_GoAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品名称";
            // 
            // Txt_MNameOut
            // 
            this.Txt_MNameOut.Location = new System.Drawing.Point(86, 35);
            this.Txt_MNameOut.Name = "Txt_MNameOut";
            this.Txt_MNameOut.Size = new System.Drawing.Size(100, 21);
            this.Txt_MNameOut.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_PriceSale);
            this.groupBox1.Controls.Add(this.Txt_PriceIn);
            this.groupBox1.Controls.Add(this.Txt_Amount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "药品基本信息";
            // 
            // But_InquiryOut
            // 
            this.But_InquiryOut.Location = new System.Drawing.Point(244, 35);
            this.But_InquiryOut.Name = "But_InquiryOut";
            this.But_InquiryOut.Size = new System.Drawing.Size(75, 23);
            this.But_InquiryOut.TabIndex = 3;
            this.But_InquiryOut.Text = "查询";
            this.But_InquiryOut.UseVisualStyleBackColor = true;
            // 
            // But_OutComfirm
            // 
            this.But_OutComfirm.Location = new System.Drawing.Point(362, 35);
            this.But_OutComfirm.Name = "But_OutComfirm";
            this.But_OutComfirm.Size = new System.Drawing.Size(75, 23);
            this.But_OutComfirm.TabIndex = 4;
            this.But_OutComfirm.Text = "确认出库";
            this.But_OutComfirm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "药品类别";
            // 
            // Txt_Type
            // 
            this.Txt_Type.Location = new System.Drawing.Point(71, 20);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(100, 21);
            this.Txt_Type.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "药品数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "药品进价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "药品售价";
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Location = new System.Drawing.Point(71, 53);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(100, 21);
            this.Txt_Amount.TabIndex = 5;
            // 
            // Txt_PriceIn
            // 
            this.Txt_PriceIn.Location = new System.Drawing.Point(71, 83);
            this.Txt_PriceIn.Name = "Txt_PriceIn";
            this.Txt_PriceIn.Size = new System.Drawing.Size(100, 21);
            this.Txt_PriceIn.TabIndex = 6;
            // 
            // Txt_PriceSale
            // 
            this.Txt_PriceSale.Location = new System.Drawing.Point(71, 110);
            this.Txt_PriceSale.Name = "Txt_PriceSale";
            this.Txt_PriceSale.Size = new System.Drawing.Size(100, 21);
            this.Txt_PriceSale.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_GoAmount);
            this.groupBox2.Controls.Add(this.Txt_GoWhere);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(26, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "出库去向";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "数量";
            // 
            // Txt_GoWhere
            // 
            this.Txt_GoWhere.Location = new System.Drawing.Point(71, 23);
            this.Txt_GoWhere.Name = "Txt_GoWhere";
            this.Txt_GoWhere.Size = new System.Drawing.Size(100, 21);
            this.Txt_GoWhere.TabIndex = 2;
            // 
            // Txt_GoAmount
            // 
            this.Txt_GoAmount.Location = new System.Drawing.Point(71, 63);
            this.Txt_GoAmount.Name = "Txt_GoAmount";
            this.Txt_GoAmount.Size = new System.Drawing.Size(100, 21);
            this.Txt_GoAmount.TabIndex = 3;
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.But_OutComfirm);
            this.Controls.Add(this.But_InquiryOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_MNameOut);
            this.Controls.Add(this.label1);
            this.Name = "Pharmacy";
            this.Text = "出库管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_MNameOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button But_InquiryOut;
        private System.Windows.Forms.Button But_OutComfirm;
        private System.Windows.Forms.TextBox Txt_Type;
        private System.Windows.Forms.TextBox Txt_PriceSale;
        private System.Windows.Forms.TextBox Txt_PriceIn;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_GoAmount;
        private System.Windows.Forms.TextBox Txt_GoWhere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}