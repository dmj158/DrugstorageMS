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
    public partial class alterpsw : Form
    {
        public alterpsw()
        {
          
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void alterpsw_Load(object sender, EventArgs e)
        {
            lab_username.Text = Userhelper.user;
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool check()
        {
            bool check=true;
            if(txt_cpsw.Text.Trim()==txt_psw.Text.Trim())
            {
                check=true;
            }
            else
            {
                check=false;
                MessageBox.Show("请重新输入确认密码！");
                txt_cpsw.SelectAll();
                txt_cpsw.Focus();
            }
            return check;
        }

        private void but_alterpsw_Click(object sender, EventArgs e)
        {
            if(check()==false)
            {
                return ;
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand comd = new SqlCommand();
            comd.Connection = conn;
            conn.Open();
            comd.CommandText = "update tb_User set PassCode=@psw where Name=@name;";
            comd.Parameters.AddWithValue("@psw",txt_cpsw.Text.Trim());
            comd.Parameters.AddWithValue("@name", lab_username.Text.Trim());
            int i = Convert.ToInt32(comd.ExecuteNonQuery());
            if (i == 1)
            {
                MessageBox.Show("修改成功!");

            }
            else 
            {
                MessageBox.Show("修改失败！");
            }
            conn.Close();

        }
    }
}
