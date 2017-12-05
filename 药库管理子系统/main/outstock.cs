using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace main
{
    public partial class outstock : Form
    {
        public outstock()
        {
            InitializeComponent();
        }
        bool CheckoutId(string outid) 
        {
           
            bool check = true;
            if (outid == "")
            {
                MessageBox.Show("出库编号不能为空！");
                check = false;
            }
            else 
            {
                SqlConnection sqlconnectioin = new SqlConnection();
                sqlconnectioin.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
                sqlconnectioin.Open();
                SqlCommand sqlcommand3 = new SqlCommand();
                sqlcommand3.Connection = sqlconnectioin;
                sqlcommand3.CommandText = "select count(*) from tb_OutWarehouse where OutNo=@outno;";
                sqlcommand3.Parameters.AddWithValue("@outno", outid);
                int rowcount = (int)sqlcommand3.ExecuteScalar();
                if (rowcount == 1)
                {
                    MessageBox.Show("出库单编号已存在，请重新输入！");
                    txt_outId.Focus();
                    txt_outId.Text = "";
                    check = false;
                }

            
            }
            return check;
        }
        bool CheckMedicine() 
        {
            bool check;
            SqlConnection sqlconnectioin = new SqlConnection();
            sqlconnectioin.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            sqlconnectioin.Open();
            SqlCommand sqlcommand=new SqlCommand();
            sqlcommand.Connection=sqlconnectioin;
            sqlcommand.CommandText="select count(*) from tb_Stock where MedicineNo=@MNo;";
            sqlcommand.Parameters.AddWithValue("@MNo",comb_Medicinename.SelectedValue);
            int a=Convert.ToInt32(sqlcommand.ExecuteScalar());
            if (a!=0)
            {
                check = true;

            }
            else { 
                check = false;
                MessageBox.Show("库存没有该药，请添加库存！");
            }
            return check;
        }
        

        private void But_InStock_Click(object sender, EventArgs e)
        {
            string outid = txt_outId.Text.Trim();
            int a = Convert.ToInt32(txt_outamount.Text.Trim());
            if (CheckoutId(outid) == false) 
            {
                return;
            }
            if (CheckMedicine() == false) 
            {
                return;
            }
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            SqlCommand sqlcommand3 = new SqlCommand();
            
           
            sqlcommand.Connection = sqlconnection;
            sqlcommand2.Connection = sqlconnection;
            sqlcommand3.Connection= sqlconnection;
          
            sqlcommand.CommandText = "insert into tb_OutWarehouse values(@OutNo,@phNo,@MedicineNo,@outamount,@outdate,@userno);";
            sqlcommand.Parameters.AddWithValue("@OutNo",txt_outId.Text.Trim());
            sqlcommand.Parameters.AddWithValue("@phNo",comb_pharmacy.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@MedicineNo",comb_Medicinename.SelectedValue);
            sqlcommand.Parameters.AddWithValue("@outamount",a);
            sqlcommand.Parameters.AddWithValue("@outdate",dtp_outdate.Value);
            sqlcommand.Parameters.AddWithValue("@userno",comb_username.SelectedValue);
            sqlcommand2.CommandText = "update tb_Stock set StockAmount-=@amount where MedicineNo=@medicine;" ;
            sqlcommand2.Parameters.AddWithValue("@amount", a);
            sqlcommand2.Parameters.AddWithValue("@medicine", comb_Medicinename.SelectedValue);
            int n = Convert.ToInt32(sqlcommand.ExecuteNonQuery());
            int f = Convert.ToInt32(sqlcommand2.ExecuteNonQuery());
            sqlcommand3.CommandText = "SELECT OutNo,Name,OutAmount,OutDate,PhNo,UserNo FROM dbo.tb_OutWarehouse  JOIN dbo.tb_Medicine  ON dbo.tb_OutWarehouse.MedicineNo=dbo.tb_Medicine.NO WHERE tb_Medicine.No='" + comb_Medicinename.SelectedValue.ToString() + "';";

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlcommand3;
            DataTable OutWarehouse = new DataTable();
            
            sqlDataAdapter1.Fill(OutWarehouse);
           
            this.dgv_outstock.Columns.Clear();
            this.dgv_outstock.DataSource = OutWarehouse;
            this.dgv_outstock.ReadOnly = true;
            this.dgv_outstock.AllowUserToAddRows = false;
            
            this.dgv_outstock.Columns["OutNo"].HeaderText = "出库批次";
            this.dgv_outstock.Columns["PhNo"].HeaderText = "二级药房编号";
            this.dgv_outstock.Columns["Name"].HeaderText = "药品名称";
            this.dgv_outstock.Columns["OutAmount"].HeaderText = "出库量";
            this.dgv_outstock.Columns["OutDate"].HeaderText = "出库日期";
            this.dgv_outstock.Columns["UserNo"].HeaderText = "操作员编号";
            

            
            sqlconnection.Close();
        }

        private void outstock_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlcommand1 = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            SqlCommand sqlcommand3 = new SqlCommand();
            sqlcommand1.Connection = sqlconnection;
            sqlcommand2.Connection = sqlconnection;
            sqlcommand3.Connection = sqlconnection;
            sqlcommand1.CommandText = "select M.No,M.Name from tb_Medicine as M";
            sqlcommand2.CommandText = "select C.No,C.Name from tb_User as C";
            sqlcommand3.CommandText = "select * from tb_Pharmacy;";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlcommand1;
            sqlDataAdapter2.SelectCommand = sqlcommand2;
            sqlDataAdapter3.SelectCommand = sqlcommand3;
            sqlconnection.Open();
            DataTable datatable1 = new DataTable();
            DataTable dataTable2 = new DataTable();
            DataTable datatable3 = new DataTable();
            sqlDataAdapter1.Fill(datatable1);
            sqlDataAdapter2.Fill(dataTable2);
            sqlDataAdapter3.Fill(datatable3);
            sqlconnection.Close();
            this.comb_Medicinename.DataSource = datatable1;
            this.comb_Medicinename.DisplayMember = "Name";
            this.comb_Medicinename.ValueMember = "No";
            this.comb_username.DataSource = dataTable2;
            this.comb_username.DisplayMember = "Name";
            this.comb_username.ValueMember = "No";
            this.comb_pharmacy.DataSource = datatable3;
            this.comb_pharmacy.ValueMember = "No";
            this.comb_pharmacy.DisplayMember = "Type";
           
           

           
           
        }

        private void comb_Medicinename_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            if (CheckMedicine() == false) 
            {
                return;
            }
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            
            sqlcommand.CommandText = "select * from tb_Stock where MedicineNo=@MNo;";
            sqlcommand.Parameters.AddWithValue("@MNo",comb_Medicinename.SelectedValue);
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader(); 
            if (sqlDataReader.Read()) 
            {
                this.lab_stockamount.Text = sqlDataReader["StockAmount"].ToString();
            }*/



        }

        private void But_ExitInstock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_outId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_outId.Text = "";
            txt_outamount.Text = "";
        }
    }
}
