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
    public partial class InStockQ : Form
    {
        public InStockQ()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void But_InStockInquiry_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                                                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;                                                 //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand1 = new SqlCommand();
            
            sqlCommand1.Connection = sqlConnection;

            sqlCommand1.CommandText = "SELECT InNo,Name,InAmount,InPrice,InDate,UserNo FROM dbo.tb_InWarehouse  JOIN dbo.tb_Medicine  ON dbo.tb_InWarehouse.MedicineNo=dbo.tb_Medicine.NO WHERE tb_Medicine.No='" + Comb_medicineName.SelectedValue.ToString() + "';";
            
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();                                          
            sqlDataAdapter1.SelectCommand = sqlCommand1;                                                      
            DataTable InWarehouse = new DataTable();                                                         
            sqlConnection.Open();                                                                          
            sqlDataAdapter1.Fill(InWarehouse);
            this.dgv_Inwarehouse.Columns.Clear();                                                                 
            this.dgv_Inwarehouse.DataSource = InWarehouse;                                                       
            this.dgv_Inwarehouse.Columns["InNo"].HeaderText = "入库批次";                                               
            this.dgv_Inwarehouse.Columns["InDate"].HeaderText = "入库日期";
            this.dgv_Inwarehouse.Columns["UserNo"].HeaderText = "操作员编号";
            this.dgv_Inwarehouse.Columns["Name"].HeaderText = "药品名称";
            this.dgv_Inwarehouse.Columns["InAmount"].HeaderText = "入库数量";
            this.dgv_Inwarehouse.Columns["InPrice"].HeaderText = "进价";

            
            
            
        }

        private void InStock_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlcommand1 = new SqlCommand();
            sqlcommand1.Connection = sqlconnection;
            sqlcommand1.CommandText = "select * from tb_Medicine";
            SqlDataAdapter sqlDataAdapter1=new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand=sqlcommand1;
            DataTable Medicinename=new DataTable();
            sqlconnection.Open();
            sqlDataAdapter1.Fill(Medicinename);
            this.Comb_medicineName.DataSource = Medicinename;                                                         //将班级下拉框的数据源设为班级数据表；
            this.Comb_medicineName.DisplayMember = "Name";                                                          //将班级下拉框的显示成员设为班级数据表的名称列；
            this.Comb_medicineName.ValueMember = "No";




        }
    }
}
