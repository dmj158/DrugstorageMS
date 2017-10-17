namespace main
{
    partial class StockInquiry
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
            this.But_InquiryStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_MNameStock = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // But_InquiryStock
            // 
            this.But_InquiryStock.Location = new System.Drawing.Point(344, 13);
            this.But_InquiryStock.Name = "But_InquiryStock";
            this.But_InquiryStock.Size = new System.Drawing.Size(75, 23);
            this.But_InquiryStock.TabIndex = 0;
            this.But_InquiryStock.Text = "查询";
            this.But_InquiryStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "药品名称";
            // 
            // Txt_MNameStock
            // 
            this.Txt_MNameStock.Location = new System.Drawing.Point(84, 20);
            this.Txt_MNameStock.Name = "Txt_MNameStock";
            this.Txt_MNameStock.Size = new System.Drawing.Size(100, 21);
            this.Txt_MNameStock.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(392, 210);
            this.dataGridView1.TabIndex = 3;
            // 
            // StockInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_MNameStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_InquiryStock);
            this.Name = "StockInquiry";
            this.Text = "库存查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_InquiryStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_MNameStock;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}