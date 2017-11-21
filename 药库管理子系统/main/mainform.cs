using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            ssusername.Text = "欢迎" + Userhelper.user + "使用药库系统";
            sspsw.Text = "当前日期为：" + DateTime.Now.ToLongDateString();
        }

        private void price_Click(object sender, EventArgs e)
        {
            Price_Medicine P = new Price_Medicine();
           
            P.Show();
        }




        internal void show()
        {
            throw new NotImplementedException();
        }

        private void Price_Medicine_Click(object sender, EventArgs e)
        {

        }

        private void PriceInquiry_Click(object sender, EventArgs e)
        {

        }

        private void 出库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 入库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void InStock_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            instock f = new instock();
           
=======
            BuyIn f = new BuyIn();
>>>>>>> origin/master
            f.Show();

        }

        private void In_inquiry_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            InStockQ f = new InStockQ();
            
=======
            InStock f = new InStock();
>>>>>>> origin/master
            f.Show();

        }

        private void Out_inquiry_Click(object sender, EventArgs e)
        {
            OutStockInquiry f=new OutStockInquiry();
<<<<<<< HEAD
            
=======
>>>>>>> origin/master
            f.Show();
        }

        private void S_inquiry_Click(object sender, EventArgs e)
        {
            StockInquiry f = new StockInquiry();
<<<<<<< HEAD
            
            f.Show();
        }

       
        private void outstock_Click(object sender, EventArgs e)
        {
            outstock f = new outstock();
            
            f.Show();
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 药品基本信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineInfo f = new MedicineInfo();
            
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 系统说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            description f = new description();
            
            f.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void 添加操作员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要注销登录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            login f = new login();
         
            f.Show();
            }
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterpsw f = new alterpsw();
            f.Show();
=======
            f.Show();
        }

        private void Instruction_Click(object sender, EventArgs e)
        {
>>>>>>> origin/master

        }
    }
}
