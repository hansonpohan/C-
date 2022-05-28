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
    public partial class 員工登入系統 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        public 員工登入系統()
        {
            InitializeComponent();
        }

        private void 員工登入系統_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn員工登入_Click(object sender, EventArgs e)
        {
            if (txt帳號.Text != "" && txt密碼.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 員工資料 where 帳號 like @SearchID and 密碼 like @Searchpass";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", "%" + txt帳號.Text + "%");
                cmd.Parameters.AddWithValue("@Searchpass", "%" + txt密碼.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (txt帳號.Text == string.Format("{0}", reader["帳號"]) && txt密碼.Text == string.Format("{0}", reader["密碼"]))
                    {
                        Globalvar.員工名稱 = string.Format("{0}", reader["員工姓名"]);
                        MessageBox.Show("員工:" + string.Format("{0}", reader["員工姓名"]));
                        txt帳號.Clear();
                        txt密碼.Clear();
                        Form3 form員工登入修改 = new Form3();
                        Globalvar.form員工 = form員工登入修改;
                        form員工登入修改.Show();
                        //form1關不起來
                        Form1 form = new Form1();
                        Globalvar.form登入.Hide();
                    }
                    else
                    {
                        MessageBox.Show("帳號密碼錯誤");
                    }
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

        private void btn員工清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
        }
    }
}
