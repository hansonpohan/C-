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
    public partial class 登入系統 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        public 登入系統()
        {
            InitializeComponent();
        }

        private void 登入系統_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if (txt帳號.Text != "" && txt密碼.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 會員 where 帳號 like @SearchID and 密碼 like @Searchpass";//密碼 like @Searchpass
                SqlCommand cmd = new SqlCommand(strSQL, con);                
                cmd.Parameters.AddWithValue("@SearchID", "%" + txt帳號.Text + "%");
                cmd.Parameters.AddWithValue("@Searchpass", "%" + txt密碼.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    txt帳號.Text = string.Format("{0}", reader["帳號"]);
                    txt密碼.Text = string.Format("{0}", reader["密碼"]);
                    MessageBox.Show("登入成功");
                    txt帳號.Clear();
                    txt密碼.Clear();
                    Form2 form訂單 = new Form2();
                    Globalvar.form訂單 = form訂單;
                    form訂單.Show();

                    Form1 form登入 = new Form1();
                    Globalvar.form登入 = form登入;
                    Globalvar.form登入.Hide();
                }
                else
                {
                    MessageBox.Show("帳號密碼錯誤");
                }                
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }                        
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
        }
    }
}
