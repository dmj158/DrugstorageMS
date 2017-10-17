namespace main
{
    partial class UpDown
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
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.rBut_high = new System.Windows.Forms.RadioButton();
            this.rBut_Low = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MName = new System.Windows.Forms.TextBox();
            this.But_refresh = new System.Windows.Forms.Button();
            this.But_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "报警记录数";
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Location = new System.Drawing.Point(93, 17);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(100, 21);
            this.Txt_Amount.TabIndex = 1;
            // 
            // rBut_high
            // 
            this.rBut_high.AutoSize = true;
            this.rBut_high.Location = new System.Drawing.Point(227, 21);
            this.rBut_high.Name = "rBut_high";
            this.rBut_high.Size = new System.Drawing.Size(71, 16);
            this.rBut_high.TabIndex = 2;
            this.rBut_high.TabStop = true;
            this.rBut_high.Text = "高储报警";
            this.rBut_high.UseVisualStyleBackColor = true;
            // 
            // rBut_Low
            // 
            this.rBut_Low.AutoSize = true;
            this.rBut_Low.Location = new System.Drawing.Point(341, 21);
            this.rBut_Low.Name = "rBut_Low";
            this.rBut_Low.Size = new System.Drawing.Size(71, 16);
            this.rBut_Low.TabIndex = 3;
            this.rBut_Low.TabStop = true;
            this.rBut_Low.Text = "低储报警";
            this.rBut_Low.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(442, 182);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "药品名称";
            // 
            // Txt_MName
            // 
            this.Txt_MName.Location = new System.Drawing.Point(82, 283);
            this.Txt_MName.Name = "Txt_MName";
            this.Txt_MName.Size = new System.Drawing.Size(100, 21);
            this.Txt_MName.TabIndex = 6;
            // 
            // But_refresh
            // 
            this.But_refresh.Location = new System.Drawing.Point(227, 280);
            this.But_refresh.Name = "But_refresh";
            this.But_refresh.Size = new System.Drawing.Size(75, 23);
            this.But_refresh.TabIndex = 7;
            this.But_refresh.Text = "刷新";
            this.But_refresh.UseVisualStyleBackColor = true;
            // 
            // But_Exit
            // 
            this.But_Exit.Location = new System.Drawing.Point(363, 280);
            this.But_Exit.Name = "But_Exit";
            this.But_Exit.Size = new System.Drawing.Size(75, 23);
            this.But_Exit.TabIndex = 8;
            this.But_Exit.Text = "退出";
            this.But_Exit.UseVisualStyleBackColor = true;
            // 
            // UpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.But_Exit);
            this.Controls.Add(this.But_refresh);
            this.Controls.Add(this.Txt_MName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rBut_Low);
            this.Controls.Add(this.rBut_high);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.label1);
            this.Name = "UpDown";
            this.Text = "UpDown";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.RadioButton rBut_high;
        private System.Windows.Forms.RadioButton rBut_Low;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_MName;
        private System.Windows.Forms.Button But_refresh;
        private System.Windows.Forms.Button But_Exit;
    }
}