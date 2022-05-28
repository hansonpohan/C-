using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 專題.Forms
{
    public partial class 註冊帳號 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        public 註冊帳號()
        {
            InitializeComponent();
        }

        private void 註冊帳號_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn儲存_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != "") && (txt姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into 會員資料 values(@NewCount,@NewPass,@NewName, @NewPhone,@NewAddress,@NewEmail,@NewBirthday);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewCount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewPass", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");
                txt帳號.Clear();
                txt密碼.Clear();
                txt姓名.Clear();
                txt電話.Clear();
                txt地址.Clear();
                txtEmail.Clear();
                dtp生日.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show(" 帳號, 密碼, 姓名必需填寫");
            }            
        }

        private void txt帳號_Leave(object sender, EventArgs e)
        {
            if (txt帳號.Text == "")
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 會員資料 where 帳號 like @Searchcount";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcount", "%" + txt帳號.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("此帳號已被註冊");
                }
            }
        }
    }
}
