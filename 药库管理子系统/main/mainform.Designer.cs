namespace main
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.price = new System.Windows.Forms.ToolStripMenuItem();
            this.Price_Medicine = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceInquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.MinMax = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InStock = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PharmacyOut = new System.Windows.Forms.ToolStripMenuItem();
            this.查询管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.S_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.Out_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.In_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.Date_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.Buy_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.Instruction = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.查询管理ToolStripMenuItem,
            this.Buy_inquiry,
            this.Instruction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.price,
            this.MinMax});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "库存管理";
            // 
            // price
            // 
            this.price.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Price_Medicine,
            this.PriceInquiry});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(160, 22);
            this.price.Text = "调价管理";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // Price_Medicine
            // 
            this.Price_Medicine.Name = "Price_Medicine";
            this.Price_Medicine.Size = new System.Drawing.Size(152, 22);
            this.Price_Medicine.Text = "药品调价";
            this.Price_Medicine.Click += new System.EventHandler(this.Price_Medicine_Click);
            // 
            // PriceInquiry
            // 
            this.PriceInquiry.Name = "PriceInquiry";
            this.PriceInquiry.Size = new System.Drawing.Size(152, 22);
            this.PriceInquiry.Text = "调价查询";
            this.PriceInquiry.Click += new System.EventHandler(this.PriceInquiry_Click);
            // 
            // MinMax
            // 
            this.MinMax.Name = "MinMax";
            this.MinMax.Size = new System.Drawing.Size(160, 22);
            this.MinMax.Text = "药品上下限管理";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InStock});
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            this.入库管理ToolStripMenuItem.Click += new System.EventHandler(this.入库管理ToolStripMenuItem_Click);
            // 
            // InStock
            // 
            this.InStock.Name = "InStock";
            this.InStock.Size = new System.Drawing.Size(152, 22);
            this.InStock.Text = "入库录入";
            this.InStock.Click += new System.EventHandler(this.InStock_Click);
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PharmacyOut});
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.出库管理ToolStripMenuItem.Text = "出库管理 ";
            this.出库管理ToolStripMenuItem.Click += new System.EventHandler(this.出库管理ToolStripMenuItem_Click);
            // 
            // PharmacyOut
            // 
            this.PharmacyOut.Name = "PharmacyOut";
            this.PharmacyOut.Size = new System.Drawing.Size(124, 22);
            this.PharmacyOut.Text = "二级药房";
            // 
            // 查询管理ToolStripMenuItem
            // 
            this.查询管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S_inquiry,
            this.Out_inquiry,
            this.In_inquiry,
            this.Date_inquiry});
            this.查询管理ToolStripMenuItem.Name = "查询管理ToolStripMenuItem";
            this.查询管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询管理ToolStripMenuItem.Text = "查询管理";
            // 
            // S_inquiry
            // 
            this.S_inquiry.Name = "S_inquiry";
            this.S_inquiry.Size = new System.Drawing.Size(152, 22);
            this.S_inquiry.Text = "库存查询";
            this.S_inquiry.Click += new System.EventHandler(this.S_inquiry_Click);
            // 
            // Out_inquiry
            // 
            this.Out_inquiry.Name = "Out_inquiry";
            this.Out_inquiry.Size = new System.Drawing.Size(152, 22);
            this.Out_inquiry.Text = "出库查询";
            this.Out_inquiry.Click += new System.EventHandler(this.Out_inquiry_Click);
            // 
            // In_inquiry
            // 
            this.In_inquiry.Name = "In_inquiry";
            this.In_inquiry.Size = new System.Drawing.Size(152, 22);
            this.In_inquiry.Text = "入库查询";
            this.In_inquiry.Click += new System.EventHandler(this.In_inquiry_Click);
            // 
            // Date_inquiry
            // 
            this.Date_inquiry.Name = "Date_inquiry";
            this.Date_inquiry.Size = new System.Drawing.Size(152, 22);
            this.Date_inquiry.Text = "日期预警";
            // 
            // Buy_inquiry
            // 
            this.Buy_inquiry.Name = "Buy_inquiry";
            this.Buy_inquiry.Size = new System.Drawing.Size(72, 21);
            this.Buy_inquiry.Text = "采购管理 ";
            // 
            // Instruction
            // 
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(44, 21);
            this.Instruction.Text = "说明";
            this.Instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "药库管理系统 1.0Copyright（C）2017 king_4小组";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MinMax;
        private System.Windows.Forms.ToolStripMenuItem price;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InStock;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PharmacyOut;
        private System.Windows.Forms.ToolStripMenuItem 查询管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem S_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Out_inquiry;
        private System.Windows.Forms.ToolStripMenuItem In_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Date_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Buy_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Instruction;
        private System.Windows.Forms.ToolStripMenuItem Price_Medicine;
        private System.Windows.Forms.ToolStripMenuItem PriceInquiry;
        private System.Windows.Forms.Label label1;


    }
}

