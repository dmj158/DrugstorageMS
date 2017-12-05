namespace main
{
    partial class OutStockInquiry
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
            this.But_OutStockI = new System.Windows.Forms.Button();
            this.dgv_outwarehouse = new System.Windows.Forms.DataGridView();
            this.comb_Medicinename = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outwarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品名称";
            // 
            // But_OutStockI
            // 
            this.But_OutStockI.Location = new System.Drawing.Point(259, 26);
            this.But_OutStockI.Name = "But_OutStockI";
            this.But_OutStockI.Size = new System.Drawing.Size(75, 23);
            this.But_OutStockI.TabIndex = 2;
            this.But_OutStockI.Text = "查询";
            this.But_OutStockI.UseVisualStyleBackColor = true;
            this.But_OutStockI.Click += new System.EventHandler(this.But_OutStockI_Click);
            // 
            // dgv_outwarehouse
            // 
            this.dgv_outwarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outwarehouse.Location = new System.Drawing.Point(0, 81);
            this.dgv_outwarehouse.Name = "dgv_outwarehouse";
            this.dgv_outwarehouse.RowTemplate.Height = 23;
            this.dgv_outwarehouse.Size = new System.Drawing.Size(492, 189);
            this.dgv_outwarehouse.TabIndex = 3;
            // 
            // comb_Medicinename
            // 
            this.comb_Medicinename.FormattingEnabled = true;
            this.comb_Medicinename.Location = new System.Drawing.Point(92, 26);
            this.comb_Medicinename.Name = "comb_Medicinename";
            this.comb_Medicinename.Size = new System.Drawing.Size(121, 20);
            this.comb_Medicinename.TabIndex = 4;
            this.comb_Medicinename.SelectedIndexChanged += new System.EventHandler(this.comb_Medicinename_SelectedIndexChanged);
            // 
            // OutStockInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.comb_Medicinename);
            this.Controls.Add(this.dgv_outwarehouse);
            this.Controls.Add(this.But_OutStockI);
            this.Controls.Add(this.label1);
            this.Name = "OutStockInquiry";
            this.Text = "OutStockInquiry";
            this.Load += new System.EventHandler(this.OutStockInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outwarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_OutStockI;
        private System.Windows.Forms.DataGridView dgv_outwarehouse;
        private System.Windows.Forms.ComboBox comb_Medicinename;
    }
}