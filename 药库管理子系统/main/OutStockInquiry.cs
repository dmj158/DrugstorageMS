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
    public partial class OutStockInquiry : Form
    {
        public OutStockInquiry()
        {
            InitializeComponent();
        }

        private void Txt_MNameOutSI_TextChanged(object sender, EventArgs e)
        {

        }

        private void comb_Medicinename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OutStockInquiry_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlcommand1 = new SqlCommand();
            sqlcommand1.Connection = sqlconnection;
            sqlcommand1.CommandText = "select * from tb_Medicine";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlcommand1;
            DataTable Medicinename = new DataTable();
            sqlconnection.Open();
            sqlDataAdapter1.Fill(Medicinename);
            sqlconnection.Close();
            this.comb_Medicinename.DataSource = Medicinename;                                                         
            this.comb_Medicinename.DisplayMember = "Name";                                                         
            this.comb_Medicinename.ValueMember = "No";

        }

        private void But_OutStockI_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                                                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;                                                 //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand1 = new SqlCommand();

            sqlCommand1.Connection = sqlConnection;

            sqlCommand1.CommandText = "SELECT OutNo,Name,OutAmount,OutDate,PhNo,UserNo FROM dbo.tb_OutWarehouse  JOIN dbo.tb_Medicine  ON dbo.tb_OutWarehouse.MedicineNo=dbo.tb_Medicine.NO WHERE tb_Medicine.No='" + comb_Medicinename.SelectedValue.ToString() + "';";

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();                                           
            sqlDataAdapter1.SelectCommand = sqlCommand1;                                                     
            DataTable OutWarehouse = new DataTable();                                                         
            sqlConnection.Open();                                                                          
            sqlDataAdapter1.Fill(OutWarehouse);
            sqlConnection.Close();
            this.dgv_outwarehouse.Columns.Clear();                                                                 
            this.dgv_outwarehouse.DataSource = OutWarehouse;                                                      
            this.dgv_outwarehouse.Columns["OutNo"].HeaderText = "出库批次";                                              
            this.dgv_outwarehouse.Columns["PhNo"].HeaderText = "二级药房编号";
            this.dgv_outwarehouse.Columns["Name"].HeaderText = "药品名称";
            this.dgv_outwarehouse.Columns["OutAmount"].HeaderText = "出库量";
            this.dgv_outwarehouse.Columns["OutDate"].HeaderText = "出库日期";
            this.dgv_outwarehouse.Columns["UserNo"].HeaderText = "操作员编号";
            
           
        }
    }
}
