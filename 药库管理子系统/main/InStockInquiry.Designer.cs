namespace main
{
    partial class InStock
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
            this.Txt_MNameInStock = new System.Windows.Forms.TextBox();
            this.But_InStockInquiry = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品名称";
            // 
            // Txt_MNameInStock
            // 
            this.Txt_MNameInStock.Location = new System.Drawing.Point(90, 19);
            this.Txt_MNameInStock.Name = "Txt_MNameInStock";
            this.Txt_MNameInStock.Size = new System.Drawing.Size(100, 21);
            this.Txt_MNameInStock.TabIndex = 1;
            // 
            // But_InStockInquiry
            // 
            this.But_InStockInquiry.Location = new System.Drawing.Point(287, 16);
            this.But_InStockInquiry.Name = "But_InStockInquiry";
            this.But_InStockInquiry.Size = new System.Drawing.Size(75, 23);
            this.But_InStockInquiry.TabIndex = 2;
            this.But_InStockInquiry.Text = "查询";
            this.But_InStockInquiry.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(443, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // InStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.But_InStockInquiry);
            this.Controls.Add(this.Txt_MNameInStock);
            this.Controls.Add(this.label1);
            this.Name = "InStock";
            this.Text = "入库查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_MNameInStock;
        private System.Windows.Forms.Button But_InStockInquiry;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}