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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Price_Medicine P = new Price_Medicine();
            P.MdiParent = this;
            P.Show();
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


       
    }
}
