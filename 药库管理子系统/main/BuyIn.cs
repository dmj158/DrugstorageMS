using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace main
{
    public partial class BuyIn : Form
    {
        public BuyIn()
        {
            InitializeComponent();
        }

        private void BuyIn_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlcommand1 = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();

            sqlcommand1.Connection = sqlconnection;
            sqlcommand2.Connection = sqlconnection;
            sqlcommand1.CommandText = "select * from tb_Medicine";
            sqlcommand2.CommandText = "select * from tb_Checker";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlcommand1;
            sqlDataAdapter2.SelectCommand = sqlcommand2;
            DataTable Medicinename = new DataTable();
            DataTable CheckerName = new DataTable();
            sqlconnection.Open();
            sqlDataAdapter1.Fill(Medicinename);
            sqlDataAdapter2.Fill(CheckerName);
            sqlconnection.Close();
            this.comb_Medicinename.DataSource = Medicinename;                                                         //将班级下拉框的数据源设为班级数据表；
            this.comb_Medicinename.DisplayMember = "Name";                                                          //将班级下拉框的显示成员设为班级数据表的名称列；
            this.comb_Medicinename.ValueMember = "No";
            this.comb_Checker.DataSource = CheckerName;
            this.comb_Checker.DisplayMember = "ChName";
            this.comb_Checker.ValueMember = "No";
        }

        private void lable3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



    }
}
