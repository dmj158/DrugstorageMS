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
        bool CheckinId(string inid)
        {
            
            bool check = true;
            if (inid == "")
            {
                MessageBox.Show("入库编号不能为空！");
                check = false;
            }
            else
            {
                SqlConnection sqlconnectioin = new SqlConnection();
                sqlconnectioin.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
                sqlconnectioin.Open();
                SqlCommand sqlcommand3 = new SqlCommand();
                sqlcommand3.Connection = sqlconnectioin;
                sqlcommand3.CommandText = "select count(*) from tb_InWarehouse where InNo=@Inno;";
                sqlcommand3.Parameters.AddWithValue("@Inno", inid);
                int rowcount = (int)sqlcommand3.ExecuteScalar();
                if (rowcount == 1)
                {
                    MessageBox.Show("入库单编号已存在，请重新输入！");
                    txt_InNo.Focus();
                    txt_InNo.Text = "";
                    check = false;
                }


            }
            return check;
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

            string inid = txt_InNo.Text.Trim();
            int a = Convert.ToInt32(txt_Inamount.Text.Trim());
            if (CheckinId(inid) == false)
            {
                return;
            }
           
            SqlConnection sqlconnection =new SqlConnection();
            sqlconnection.ConnectionString=ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlcommand.CommandText = "insert into tb_InWarehouse values(@inno,@indate,@userno,@medicineno,@inamount,@inprice);";
            sqlcommand.Parameters.AddWithValue("@inno", inid);                        
            sqlcommand.Parameters.AddWithValue("@indate", this.dtp_Instockdate.Value.Date);
            sqlcommand.Parameters.AddWithValue("@userno", (int)this.comb_User.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@medicineno", (int)this.comb_Medicinename.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@inamount", a);
            sqlcommand.Parameters.AddWithValue("@inprice", this.txt_Inprice.Text.Trim());
            int n = Convert.ToInt32(sqlcommand.ExecuteNonQuery());
            
            
            SqlCommand sqlCommand1 = new SqlCommand();

            sqlCommand1.Connection = sqlconnection;
            sqlCommand1.CommandText = "SELECT InNo,Name,InAmount,InPrice,InDate,UserNo FROM dbo.tb_InWarehouse  JOIN dbo.tb_Medicine  ON dbo.tb_InWarehouse.MedicineNo=dbo.tb_Medicine.NO WHERE InNo=@No;";
            sqlCommand1.Parameters.AddWithValue("@No",txt_InNo.Text.Trim());
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            DataTable InWarehouse = new DataTable();
            
            sqlDataAdapter1.Fill(InWarehouse);
            this.dgv_instock.Columns.Clear();
            this.dgv_instock.DataSource = InWarehouse;
            this.dgv_instock.ReadOnly = true;
            this.dgv_instock.AllowUserToAddRows = false;
            this.dgv_instock.Columns["InNo"].HeaderText = "入库批次";
            this.dgv_instock.Columns["InDate"].HeaderText = "入库日期";
            this.dgv_instock.Columns["UserNo"].HeaderText = "操作员编号";
            this.dgv_instock.Columns["Name"].HeaderText = "药品名称";
            this.dgv_instock.Columns["InAmount"].HeaderText = "入库数量";
            this.dgv_instock.Columns["InPrice"].HeaderText = "进价";

      
            
            sqlconnection.Close();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_InNo.Text = "";
            txt_Inamount.Text = "";
            txt_Inprice.Text = "";
        }
    }
}
