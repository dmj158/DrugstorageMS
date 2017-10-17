namespace main
{
    partial class Date
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
            this.Lab_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_Date
            // 
            this.Lab_Date.AutoSize = true;
            this.Lab_Date.Location = new System.Drawing.Point(30, 13);
            this.Lab_Date.Name = "Lab_Date";
            this.Lab_Date.Size = new System.Drawing.Size(41, 12);
            this.Lab_Date.TabIndex = 0;
            this.Lab_Date.Text = "label1";
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.Lab_Date);
            this.Name = "Date";
            this.Text = "日期预警";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Date;
    }
}