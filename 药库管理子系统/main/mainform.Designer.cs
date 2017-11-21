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
            this.MinMax = new System.Windows.Forms.ToolStripMenuItem();
            this.药品保质期预警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InStock = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstock = new System.Windows.Forms.ToolStripMenuItem();
            this.查询管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.S_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.Out_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.In_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.调价查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药品基本信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Buy_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加操作员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.sstlusername = new System.Windows.Forms.StatusStrip();
            this.sstlpsw = new System.Windows.Forms.StatusStrip();
            this.ssusername = new System.Windows.Forms.ToolStripStatusLabel();
            this.sspsw = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.sstlusername.SuspendLayout();
            this.sstlpsw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.用户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.price,
            this.MinMax,
            this.药品保质期预警ToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem1.Text = "库存管理";
            // 
            // price
            // 
            this.price.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Price_Medicine});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(176, 24);
            this.price.Text = "调价管理";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // Price_Medicine
            // 
            this.Price_Medicine.Name = "Price_Medicine";
            this.Price_Medicine.Size = new System.Drawing.Size(134, 24);
            this.Price_Medicine.Text = "药品调价";
            this.Price_Medicine.Click += new System.EventHandler(this.Price_Medicine_Click);
            // 
            // MinMax
            // 
            this.MinMax.Name = "MinMax";
            this.MinMax.Size = new System.Drawing.Size(176, 24);
            this.MinMax.Text = "药品上下限管理";
            // 
            // 药品保质期预警ToolStripMenuItem
            // 
            this.药品保质期预警ToolStripMenuItem.Name = "药品保质期预警ToolStripMenuItem";
            this.药品保质期预警ToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.药品保质期预警ToolStripMenuItem.Text = "药品保质期预警";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InStock});
            this.入库管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            this.入库管理ToolStripMenuItem.Click += new System.EventHandler(this.入库管理ToolStripMenuItem_Click);
            // 
            // InStock
            // 
            this.InStock.Name = "InStock";
            this.InStock.Size = new System.Drawing.Size(152, 24);
            this.InStock.Text = "入库录入";
            this.InStock.Click += new System.EventHandler(this.InStock_Click);
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outstock});
            this.出库管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.出库管理ToolStripMenuItem.Text = "出库管理 ";
            this.出库管理ToolStripMenuItem.Click += new System.EventHandler(this.出库管理ToolStripMenuItem_Click);
            // 
            // outstock
            // 
            this.outstock.Name = "outstock";
            this.outstock.Size = new System.Drawing.Size(152, 24);
            this.outstock.Text = "出库录入";
            this.outstock.Click += new System.EventHandler(this.outstock_Click);
            // 
            // 查询管理ToolStripMenuItem
            // 
            this.查询管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S_inquiry,
            this.Out_inquiry,
            this.In_inquiry,
            this.调价查询ToolStripMenuItem,
            this.药品基本信息查询ToolStripMenuItem});
            this.查询管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询管理ToolStripMenuItem.Name = "查询管理ToolStripMenuItem";
            this.查询管理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.查询管理ToolStripMenuItem.Text = "查询管理";
            // 
            // S_inquiry
            // 
            this.S_inquiry.Name = "S_inquiry";
            this.S_inquiry.Size = new System.Drawing.Size(190, 24);
            this.S_inquiry.Text = "库存查询";
            this.S_inquiry.Click += new System.EventHandler(this.S_inquiry_Click);
            // 
            // Out_inquiry
            // 
            this.Out_inquiry.Name = "Out_inquiry";
            this.Out_inquiry.Size = new System.Drawing.Size(190, 24);
            this.Out_inquiry.Text = "出库查询";
            this.Out_inquiry.Click += new System.EventHandler(this.Out_inquiry_Click);
            // 
            // In_inquiry
            // 
            this.In_inquiry.Name = "In_inquiry";
            this.In_inquiry.Size = new System.Drawing.Size(190, 24);
            this.In_inquiry.Text = "入库查询";
            this.In_inquiry.Click += new System.EventHandler(this.In_inquiry_Click);
            // 
            // 调价查询ToolStripMenuItem
            // 
            this.调价查询ToolStripMenuItem.Name = "调价查询ToolStripMenuItem";
            this.调价查询ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.调价查询ToolStripMenuItem.Text = "调价查询";
            // 
            // 药品基本信息查询ToolStripMenuItem
            // 
            this.药品基本信息查询ToolStripMenuItem.Name = "药品基本信息查询ToolStripMenuItem";
            this.药品基本信息查询ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.药品基本信息查询ToolStripMenuItem.Text = "药品基本信息查询";
            this.药品基本信息查询ToolStripMenuItem.Click += new System.EventHandler(this.药品基本信息查询ToolStripMenuItem_Click);
            // 
            // Buy_inquiry
            // 
            this.Buy_inquiry.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Buy_inquiry.Name = "Buy_inquiry";
            this.Buy_inquiry.Size = new System.Drawing.Size(81, 24);
            this.Buy_inquiry.Text = "采购管理 ";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加操作员ToolStripMenuItem,
            this.更改密码ToolStripMenuItem,
            this.系统说明ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.用户管理ToolStripMenuItem.Text = "系统";
            // 
            // 添加操作员ToolStripMenuItem
            // 
            this.添加操作员ToolStripMenuItem.Name = "添加操作员ToolStripMenuItem";
            this.添加操作员ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.添加操作员ToolStripMenuItem.Text = "注销";
            this.添加操作员ToolStripMenuItem.Click += new System.EventHandler(this.添加操作员ToolStripMenuItem_Click);
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // 系统说明ToolStripMenuItem
            // 
            this.系统说明ToolStripMenuItem.Name = "系统说明ToolStripMenuItem";
            this.系统说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.系统说明ToolStripMenuItem.Text = "系统说明";
            this.系统说明ToolStripMenuItem.Click += new System.EventHandler(this.系统说明ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 4;
            // 
            // sstlusername
            // 
            this.sstlusername.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sstlusername.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sspsw});
            this.sstlusername.Location = new System.Drawing.Point(0, 528);
            this.sstlusername.Name = "sstlusername";
            this.sstlusername.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.sstlusername.Size = new System.Drawing.Size(924, 24);
            this.sstlusername.TabIndex = 7;
            this.sstlusername.Text = "statusStrip1";
            // 
            // sstlpsw
            // 
            this.sstlpsw.AutoSize = false;
            this.sstlpsw.BackColor = System.Drawing.Color.White;
            this.sstlpsw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssusername});
            this.sstlpsw.Location = new System.Drawing.Point(0, 502);
            this.sstlpsw.Name = "sstlpsw";
            this.sstlpsw.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.sstlpsw.Size = new System.Drawing.Size(924, 26);
            this.sstlpsw.Stretch = false;
            this.sstlpsw.TabIndex = 8;
            this.sstlpsw.Text = "statusStrip2";
            // 
            // ssusername
            // 
            this.ssusername.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ssusername.Name = "ssusername";
            this.ssusername.Size = new System.Drawing.Size(160, 17);
            this.ssusername.Text = "toolStripStatusLabel1";
            // 
            // sspsw
            // 
            this.sspsw.BackColor = System.Drawing.Color.White;
            this.sspsw.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sspsw.Name = "sspsw";
            this.sspsw.Size = new System.Drawing.Size(160, 19);
            this.sspsw.Text = "toolStripStatusLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::main.Properties.Resources.mainform;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.sstlpsw);
            this.Controls.Add(this.sstlusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药库管理系统 1.0Copyright（C）2017 king_4小组";
            this.Load += new System.EventHandler(this.main_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainform_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sstlusername.ResumeLayout(false);
            this.sstlusername.PerformLayout();
            this.sstlpsw.ResumeLayout(false);
            this.sstlpsw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem outstock;
        private System.Windows.Forms.ToolStripMenuItem 查询管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem S_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Out_inquiry;
        private System.Windows.Forms.ToolStripMenuItem In_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Buy_inquiry;
        private System.Windows.Forms.ToolStripMenuItem Price_Medicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 药品保质期预警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调价查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药品基本信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加操作员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sstlusername;
        private System.Windows.Forms.StatusStrip sstlpsw;
        private System.Windows.Forms.ToolStripStatusLabel sspsw;
        private System.Windows.Forms.ToolStripStatusLabel ssusername;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}

