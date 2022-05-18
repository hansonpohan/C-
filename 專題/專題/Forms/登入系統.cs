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
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if (txt帳號.Text != "" && txt密碼.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 會員 where 帳號 like @SearchID and 密碼 like @Searchpass and 員工 like @employee";//密碼 like @Searchpass
                SqlCommand cmd = new SqlCommand(strSQL, con);                
                cmd.Parameters.AddWithValue("@SearchID", "%" + txt帳號.Text + "%");
                cmd.Parameters.AddWithValue("@Searchpass", "%" + txt密碼.Text + "%");
                cmd.Parameters.AddWithValue("@employee",chk員工登入.Checked);
                SqlDataReader reader = cmd.ExecuteReader();

                
                if (reader.Read())
                {
                    if (chk員工登入.Checked && txt帳號.Text == string.Format("{0}", reader["帳號"]) && txt密碼.Text == string.Format("{0}", reader["密碼"]))
                    {
                        Globalvar.會員名稱 = string.Format("{0}", reader["姓名"]);
                        MessageBox.Show("員工:" + string.Format("{0}", reader["姓名"]));
                        txt帳號.Clear();
                        txt密碼.Clear();
                        Form3員工登入修改 form員工 = new Form3員工登入修改();
                        Globalvar.form員工 = form員工;
                        form員工.Show();
                    }
                    else if(txt帳號.Text == string.Format("{0}", reader["帳號"]) && txt密碼.Text == string.Format("{0}", reader["密碼"]))
                    {
                        Globalvar.ID = Convert.ToInt32(reader["id"]);
                        Globalvar.帳號 = string.Format("{0}", reader["帳號"]);
                        Globalvar.密碼 = string.Format("{0}", reader["密碼"]);
                        Globalvar.會員名稱 = string.Format("{0}", reader["姓名"]);
                        Globalvar.電話 = string.Format("{0}", reader["電話"]);
                        Globalvar.地址 = string.Format("{0}", reader["地址"]);
                        Globalvar.Email = string.Format("{0}", reader["Email"]);
                        Globalvar.生日 = Convert.ToDateTime(reader["生日"]);
                        MessageBox.Show("歡迎回來," + string.Format("{0}", reader["姓名"]));
                        txt帳號.Clear();
                        txt密碼.Clear();
                        Form2 form訂單 = new Form2();
                        Globalvar.form訂單 = form訂單;
                        form訂單.Show();
                        //form1關不起來
                        Globalvar.form登入 = new Form1();
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

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
        }
    }
}
