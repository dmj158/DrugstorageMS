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
    public partial class MedicineInfo : Form
    {
        public MedicineInfo()
        {
            InitializeComponent();
        }

        private void but_Medicinename_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            conn.Open();
            SqlCommand comd = new SqlCommand();
            comd.Connection = conn;
            comd.CommandText = "SELECT M.No,M.Name,MT.Type,M.MFunction,M.PackingUnit,M.BasicDose,M.DoseUnit,M.Guarantee FROM tb_Medicine AS M JOIN tb_MedicineType AS MT ON M.TypeNo = MT.No WHERE M.No='" + comb_Medicinename.SelectedValue + "';";
           SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.SelectCommand = comd;
            DataTable table1 = new DataTable();
            adpter.Fill(table1);
            this.dgv_Medicine.Columns.Clear();
            this.dgv_Medicine.DataSource = table1;
            this.dgv_Medicine.Columns["No"].HeaderText = "药品编号";
            this.dgv_Medicine.Columns["Name"].HeaderText = "药品名称";
            this.dgv_Medicine.Columns["Type"].HeaderText = "药品类型";
            this.dgv_Medicine.Columns["MFunction"].HeaderText = "药品功能";
            this.dgv_Medicine.Columns["PackingUnit"].HeaderText = "包装单位";
            this.dgv_Medicine.Columns["BasicDose"].HeaderText = "基本剂量";
            this.dgv_Medicine.Columns["DoseUnit"].HeaderText = "剂量单位";
            this.dgv_Medicine.Columns["Guarantee"].HeaderText = "保质期";
           

            
        }

        private void MedicineInfo_Load(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            conn.Open();
            SqlCommand comd = new SqlCommand();
            comd.Connection = conn;
            comd.CommandText = "select * from tb_Medicine";
            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.SelectCommand = comd;
            DataTable table1 = new DataTable();
           
            adpter.Fill(table1);
            
            this.comb_Medicinename.DataSource = table1;
            this.comb_Medicinename.DisplayMember = "Name";
            this.comb_Medicinename.ValueMember = "No";
            
        }
    }
}
