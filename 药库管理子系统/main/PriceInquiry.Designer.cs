namespace main
{
    partial class PriceInquiry
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
            this.Txt_Mname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.But_Pinquiry = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Mname
            // 
            this.Txt_Mname.Location = new System.Drawing.Point(80, 13);
            this.Txt_Mname.Name = "Txt_Mname";
            this.Txt_Mname.Size = new System.Drawing.Size(100, 21);
            this.Txt_Mname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "药品名称";
            // 
            // But_Pinquiry
            // 
            this.But_Pinquiry.Location = new System.Drawing.Point(298, 9);
            this.But_Pinquiry.Name = "But_Pinquiry";
            this.But_Pinquiry.Size = new System.Drawing.Size(75, 23);
            this.But_Pinquiry.TabIndex = 2;
            this.But_Pinquiry.Text = "查询";
            this.But_Pinquiry.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(465, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // PriceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.But_Pinquiry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Mname);
            this.Name = "PriceInquiry";
            this.Text = "调价查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Mname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_Pinquiry;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}