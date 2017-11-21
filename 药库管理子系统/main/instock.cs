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
    public partial class instock : Form
    {
        public instock()
        {
            InitializeComponent();
        }

        private void instock_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlcommand1 = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            sqlcommand1.Connection = sqlconnection;
            sqlcommand2.Connection = sqlconnection;
            sqlcommand1.CommandText = "select M.No,M.Name from tb_Medicine as M";
            sqlcommand2.CommandText = "select C.No,C.Name from tb_User as C";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlcommand1;
            sqlDataAdapter2.SelectCommand = sqlcommand2;
            sqlconnection.Open();
            DataTable datatable1 = new DataTable();
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter1.Fill(datatable1);
            sqlDataAdapter2.Fill(dataTable2);
            sqlconnection.Close();
            this.comb_Medicinename.DataSource = datatable1;
            this.comb_Medicinename.DisplayMember = "Name";
            this.comb_Medicinename.ValueMember = "No";
            this.comb_User.DataSource = dataTable2;
            this.comb_User.DisplayMember = "Name";
            this.comb_User.ValueMember = "No";
            
        }

        private void But_ExitInstock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_InStock_Click(object sender, EventArgs e)
        {

           
            SqlConnection sqlconnection=new SqlConnection();
            sqlconnection.ConnectionString=ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlcommand.CommandText = "insert into tb_InWarehouse values(@inno,@indate,@userno,@medicineno,@inamount,@inprice);";
            sqlcommand.Parameters.AddWithValue("@inno", this.txt_InNo.Text.Trim());                        
            sqlcommand.Parameters.AddWithValue("@indate", this.dtp_Instockdate.Value.Date);
            sqlcommand.Parameters.AddWithValue("@userno", (int)this.comb_User.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@medicineno", (int)this.comb_Medicinename.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@inamount", this.txt_Inamount.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@inprice", this.txt_Inprice.Text.Trim()); 
      
            int n = Convert.ToInt32(sqlcommand.ExecuteNonQuery());
            if (n == 1)
            {
                MessageBox.Show("添加入库单成功！");
            }
            else 
            {
                MessageBox.Show("添加入库单失败！");
            }
            sqlconnection.Close();
        }
    }
}
