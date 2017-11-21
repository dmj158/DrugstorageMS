namespace main
{
    partial class MedicineInfo
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
            this.lab_MedicineName = new System.Windows.Forms.Label();
            this.comb_Medicinename = new System.Windows.Forms.ComboBox();
            this.but_Medicinename = new System.Windows.Forms.Button();
            this.dgv_Medicine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_MedicineName
            // 
            this.lab_MedicineName.AutoSize = true;
            this.lab_MedicineName.Location = new System.Drawing.Point(24, 46);
            this.lab_MedicineName.Name = "lab_MedicineName";
            this.lab_MedicineName.Size = new System.Drawing.Size(53, 12);
            this.lab_MedicineName.TabIndex = 0;
            this.lab_MedicineName.Text = "药品名称";
            // 
            // comb_Medicinename
            // 
            this.comb_Medicinename.FormattingEnabled = true;
            this.comb_Medicinename.Location = new System.Drawing.Point(101, 46);
            this.comb_Medicinename.Name = "comb_Medicinename";
            this.comb_Medicinename.Size = new System.Drawing.Size(121, 20);
            this.comb_Medicinename.TabIndex = 1;
            // 
            // but_Medicinename
            // 
            this.but_Medicinename.Location = new System.Drawing.Point(344, 42);
            this.but_Medicinename.Name = "but_Medicinename";
            this.but_Medicinename.Size = new System.Drawing.Size(75, 23);
            this.but_Medicinename.TabIndex = 2;
            this.but_Medicinename.Text = "查询";
            this.but_Medicinename.UseVisualStyleBackColor = true;
            this.but_Medicinename.Click += new System.EventHandler(this.but_Medicinename_Click);
            // 
            // dgv_Medicine
            // 
            this.dgv_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicine.Location = new System.Drawing.Point(26, 135);
            this.dgv_Medicine.Name = "dgv_Medicine";
            this.dgv_Medicine.RowTemplate.Height = 23;
            this.dgv_Medicine.Size = new System.Drawing.Size(491, 215);
            this.dgv_Medicine.TabIndex = 3;
            // 
            // MedicineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 426);
            this.Controls.Add(this.dgv_Medicine);
            this.Controls.Add(this.but_Medicinename);
            this.Controls.Add(this.comb_Medicinename);
            this.Controls.Add(this.lab_MedicineName);
            this.Name = "MedicineInfo";
            this.Text = "MedicineInfo";
            this.Load += new System.EventHandler(this.MedicineInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_MedicineName;
        private System.Windows.Forms.ComboBox comb_Medicinename;
        private System.Windows.Forms.Button but_Medicinename;
        private System.Windows.Forms.DataGridView dgv_Medicine;
    }
}