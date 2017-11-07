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
            this.But_InStockInquiry = new System.Windows.Forms.Button();
            this.dgv_Inwarehouse = new System.Windows.Forms.DataGridView();
            this.Comb_medicineName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inwarehouse)).BeginInit();
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
            // But_InStockInquiry
            // 
            this.But_InStockInquiry.Location = new System.Drawing.Point(287, 16);
            this.But_InStockInquiry.Name = "But_InStockInquiry";
            this.But_InStockInquiry.Size = new System.Drawing.Size(75, 23);
            this.But_InStockInquiry.TabIndex = 2;
            this.But_InStockInquiry.Text = "查询";
            this.But_InStockInquiry.UseVisualStyleBackColor = true;
            this.But_InStockInquiry.Click += new System.EventHandler(this.But_InStockInquiry_Click);
            // 
            // dgv_Inwarehouse
            // 
            this.dgv_Inwarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inwarehouse.Location = new System.Drawing.Point(25, 79);
            this.dgv_Inwarehouse.Name = "dgv_Inwarehouse";
            this.dgv_Inwarehouse.RowTemplate.Height = 23;
            this.dgv_Inwarehouse.Size = new System.Drawing.Size(443, 196);
            this.dgv_Inwarehouse.TabIndex = 3;
            // 
            // Comb_medicineName
            // 
            this.Comb_medicineName.FormattingEnabled = true;
            this.Comb_medicineName.Location = new System.Drawing.Point(82, 18);
            this.Comb_medicineName.Name = "Comb_medicineName";
            this.Comb_medicineName.Size = new System.Drawing.Size(121, 20);
            this.Comb_medicineName.TabIndex = 4;
            this.Comb_medicineName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.Comb_medicineName);
            this.Controls.Add(this.dgv_Inwarehouse);
            this.Controls.Add(this.But_InStockInquiry);
            this.Controls.Add(this.label1);
            this.Name = "InStock";
            this.Text = "入库查询";
            this.Load += new System.EventHandler(this.InStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inwarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_InStockInquiry;
        private System.Windows.Forms.DataGridView dgv_Inwarehouse;
        private System.Windows.Forms.ComboBox Comb_medicineName;
    }
}