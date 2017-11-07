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
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.comb_stock = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // But_InquiryStock
            // 
            this.But_InquiryStock.Location = new System.Drawing.Point(312, 36);
            this.But_InquiryStock.Name = "But_InquiryStock";
            this.But_InquiryStock.Size = new System.Drawing.Size(75, 23);
            this.But_InquiryStock.TabIndex = 0;
            this.But_InquiryStock.Text = "查询";
            this.But_InquiryStock.UseVisualStyleBackColor = true;
            this.But_InquiryStock.Click += new System.EventHandler(this.But_InquiryStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "药品名称";
            // 
            // dgv_stock
            // 
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(27, 110);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowTemplate.Height = 23;
            this.dgv_stock.Size = new System.Drawing.Size(392, 210);
            this.dgv_stock.TabIndex = 3;
            // 
            // comb_stock
            // 
            this.comb_stock.FormattingEnabled = true;
            this.comb_stock.Location = new System.Drawing.Point(101, 38);
            this.comb_stock.Name = "comb_stock";
            this.comb_stock.Size = new System.Drawing.Size(121, 20);
            this.comb_stock.TabIndex = 4;
            this.comb_stock.SelectedIndexChanged += new System.EventHandler(this.comb_stock_SelectedIndexChanged);
            // 
            // StockInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.comb_stock);
            this.Controls.Add(this.dgv_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_InquiryStock);
            this.Name = "StockInquiry";
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.StockInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_InquiryStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.ComboBox comb_stock;
    }
}