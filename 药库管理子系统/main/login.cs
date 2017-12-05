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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void but_login_Click(object sender, EventArgs e)
        {
           
            if (textuser.Text.Trim() == "" || textpasscode.Text.Trim() == "") {
                MessageBox.Show("用户名或密码不能为空！");
                textuser.Focus();
                return;
            } 
            SqlConnection sqlConnection = new SqlConnection();                                                                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString=ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;                                                 //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            
            SqlCommand sqlCommand = new SqlCommand();                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                          //将SQL命令的属性Connection指向SQL连接；
            sqlCommand.CommandText =                                                        //指定SQL命令的命令文本；命令文本由字符串拼接而成；
                "SELECT COUNT(1) FROM tb_User"
                + " WHERE Name='" + this.textuser.Text.Trim() + "'"                         //将文本框的文本清除首尾的空格后，拼接至命令文本中；
                + " AND PassCode='" + this.textpasscode.Text.Trim() + "'";
            sqlConnection.Open();                                                           //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();                                 //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
            //执行标量的返回结果类型为object，可通过强制类型转换，转为整型；
            sqlConnection.Close();                                                          //关闭SQL连接；
            if (rowCount == 1)                                                              //若查得所输用户号相应的1行记录；
            {
                MessageBox.Show("登录成功!");
                Userhelper.user = textuser.Text;
                Userhelper.psw = textpasscode.Text;
                this.Hide();
                mainform f = new mainform();
                f.Show();
            }
            else                                                                            //否则；
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");                           //给出错误提示；
                this.textpasscode.Focus();                                                  //密码文本框获得焦点；
                this.textpasscode.SelectAll();                                              //密码文本框内所有文本被选中；
            }




        }

        private void but_quit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}
