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
    public partial class StockInquiry : Form
    {
        public StockInquiry()
        {
            InitializeComponent();
        }

        private void comb_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void But_InquiryStock_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                                                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;                                                 //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand1 = new SqlCommand();

            sqlCommand1.Connection = sqlConnection;

            sqlCommand1.CommandText = "SELECT StockNo,Name,StockAmount,InPrice,OutPrice,InDate,Firm,ChNo,DtProduct,DtFinal FROM dbo.tb_Stock  JOIN dbo.tb_Medicine  ON dbo.tb_Stock.MedicineNo=dbo.tb_Medicine.NO WHERE tb_Medicine.No='" + comb_stock.SelectedValue.ToString() + "';";

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();                                           //声明并实例化SQL数据适配器，同时借助构造函数，将其SelectCommand属性设为先前创建的SQL命令；
            sqlDataAdapter1.SelectCommand = sqlCommand1;                                                      //将SQL数据适配器的查询命令属性指向SQL命令；
            DataTable stock = new DataTable();                                                         
            sqlConnection.Open();                                                                           //打开SQL连接；
            sqlDataAdapter1.Fill(stock);
            sqlConnection.Close();
            this.dgv_stock.Columns.Clear();                                                                 //数据网格视图的列集合清空；
            this.dgv_stock.DataSource = stock;                                                       
            this.dgv_stock.Columns["StockNo"].HeaderText = "库存批次";                                               //将数据网格视图的指定列的表头文本设为中文；
            this.dgv_stock.Columns["Name"].HeaderText = "药品名称";
            this.dgv_stock.Columns["StockAmount"].HeaderText = "库存量";
            this.dgv_stock.Columns["InDate"].HeaderText = "入库日期";
            this.dgv_stock.Columns["Firm"].HeaderText = "厂商";
            this.dgv_stock.Columns["InPrice"].HeaderText = "进价";
            this.dgv_stock.Columns["OutPrice"].HeaderText = "售价";
            this.dgv_stock.Columns["ChNo"].HeaderText = "验收员编号";
            this.dgv_stock.Columns["DtProduct"].HeaderText = "生产日期";
            this.dgv_stock.Columns["DtFinal"].HeaderText = "到期日期";
        }

        private void StockInquiry_Load(object sender, EventArgs e)
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
            this.comb_stock.DataSource = Medicinename;                                                         //将班级下拉框的数据源设为班级数据表；
            this.comb_stock.DisplayMember = "Name";                                                          //将班级下拉框的显示成员设为班级数据表的名称列；
            this.comb_stock.ValueMember = "No";

        }
    }
}
