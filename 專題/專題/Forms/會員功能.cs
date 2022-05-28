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
    public partial class 會員功能 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        public 會員功能()
        {
            InitializeComponent();
        }

        private void 會員功能_Load(object sender, EventArgs e)
        {
            lbl會員名稱.Text = Globalvar.會員名稱;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            lblID.Text =Convert.ToString( Globalvar.ID);
            txt帳號.Text = Globalvar.帳號;
            txt密碼.Text = Globalvar.密碼;
            txt姓名.Text = Globalvar.會員名稱;
            txt電話.Text = Globalvar.電話;
            txt地址.Text = Globalvar.地址;
            txtEmail.Text = Globalvar.Email;
            dtp生日.Value = Globalvar.生日;

            lbox我的訂單.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單測試 where 會員名稱 like @Searchname";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchname", txt姓名.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string str = string.Format("訂單編號:{0},{1},單價:{2}元,{3}支,顏色:{4},容量:{5},容量價格:{6},總價:{7}元",reader["訂單編號"],reader["訂購品項"],reader["單價"],reader["數量"],reader["顏色"],reader["容量"],reader["容量價格"],reader["總價"]);
                lbox我的訂單.Items.Add(str);
            }
            reader.Close();
            con.Close();
        }

        private void btn修改會員資料_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(lblID.Text,out intId);
            if ((intId > 0) && (txt帳號.Text != "") && (txt密碼.Text != "") && (txt姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update 會員資料 set 帳號=@NewCount,密碼=@NewPass,姓名=@NewName,電話=@NewPhone,地址=@NewAddress,Email=@NewEmail,生日=@NewBirthday where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intId);
                cmd.Parameters.AddWithValue("@NewCount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewPass", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功");
            }
        }

        private void btn刪除訂單_Click(object sender, EventArgs e)
        {
            if (txt訂單編號.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 訂單測試 where 訂單編號 = @Searchnumber";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchnumber", txt訂單編號.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //&&後面無法執行
                    if (lbl會員名稱.Text == string.Format("{0}", reader["會員名稱"]) && txt訂單編號.Text == string.Format("{0}", reader["訂單編號"]))
                    {
                        DialogResult R = MessageBox.Show("您確認要刪除訂單?", "刪除訂單", MessageBoxButtons.YesNo);
                        if (R == DialogResult.Yes)
                        {
                            SqlConnection con1 = new SqlConnection(myDBConnectionString);
                            con1.Open();
                            string strSQL1 = "delete from 訂單測試 where 訂單編號 = @SearchID;";
                            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
                            cmd1.Parameters.AddWithValue("SearchID", txt訂單編號.Text);
                            int rows = cmd1.ExecuteNonQuery();
                            con1.Close();
                            txt訂單編號.Clear();
                            MessageBox.Show($"{rows} 筆資料刪除成功");
                            lbox我的訂單.Items.Clear();
                            SqlConnection con3 = new SqlConnection(myDBConnectionString);
                            con3.Open();
                            string strSQL3 = "select * from 訂單測試 where 會員名稱 like @Searchname";
                            SqlCommand cmd3 = new SqlCommand(strSQL3, con3);
                            cmd3.Parameters.AddWithValue("@Searchname", txt姓名.Text);
                            SqlDataReader reader3 = cmd3.ExecuteReader();

                            while (reader3.Read())
                            {
                                string str = string.Format("訂單編號:{0},{1},單價:{2}元,{3}支,顏色:{4},容量:{5},容量價格:{6},總價:{7}元", reader3["訂單編號"], reader3["訂購品項"], reader3["單價"], reader3["數量"], reader3["顏色"], reader3["容量"], reader3["容量價格"], reader3["總價"]);
                                lbox我的訂單.Items.Add(str);
                            }
                            reader3.Close();
                            con3.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入正確訂單編號");
                    }
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入訂單編號");
            }
        }
    }
}
