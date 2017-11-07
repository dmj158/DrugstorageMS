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
         
        }

        private void price_Click(object sender, EventArgs e)
        {
            Price_Medicine P = new Price_Medicine();
            P.MdiParent = this;
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
            BuyIn f = new BuyIn();
            f.Show();

        }

        private void In_inquiry_Click(object sender, EventArgs e)
        {
            InStock f = new InStock();
            f.Show();

        }

        private void Out_inquiry_Click(object sender, EventArgs e)
        {
            OutStockInquiry f=new OutStockInquiry();
            f.Show();
        }

        private void S_inquiry_Click(object sender, EventArgs e)
        {
            StockInquiry f = new StockInquiry();
            f.Show();
        }

        private void Instruction_Click(object sender, EventArgs e)
        {

        }
    }
}
