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

namespace 專題
{
    public partial class Form3 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        private Form activeform;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl員工.Text = "員工:  " + Globalvar.員工名稱;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            產生員工資料列表();
        }

        private void openchildform(Form childform, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            存放form.Controls.Add(childform);
            存放form.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbltitle.Text = childform.Text;
        }

        private void btn註冊帳號_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.會員資料(), sender);
        }

        private void btn產品修改_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.產品修改(), sender);
        }

        private void btn會員資料_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.會員資料(), sender);
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            Globalvar.form員工.Close();
        }

        private void btn返回主頁_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            lbltitle.Text = "Home";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globalvar.form登入.Show();
        }

        

        private void btn新增員工_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != "") && (txt員工姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 員工資料 where 帳號 like @Searchcount";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcount", txt帳號.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (txt帳號.Text != string.Format("{0}", reader["帳號"]))
                    {
                        SqlConnection con1 = new SqlConnection(myDBConnectionString);
                        con1.Open();
                        string strSQL1 = "insert into 員工資料 values(@NewCount,@NewPass,@NewName);";
                        SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
                        cmd1.Parameters.AddWithValue("@NewCount", txt帳號.Text);
                        cmd1.Parameters.AddWithValue("@NewPass", txt密碼.Text);
                        cmd1.Parameters.AddWithValue("@NewName", txt員工姓名.Text);
                        int rows = cmd1.ExecuteNonQuery();
                        con1.Close();
                        MessageBox.Show($"{rows} 筆資料新增成功");
                    }
                    else
                    {
                        MessageBox.Show("此帳號已被註冊");
                    }
                }
            }
            else
            {
                MessageBox.Show(" 帳號, 密碼, 姓名必需填寫");
            }
            產生員工資料列表();
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt帳號.Text != "") && (txt密碼.Text != "") && (txt員工姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update 員工資料 set 帳號=@Newcount,密碼=@Newpass,員工姓名=@Newname where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@Newcount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@Newpass", txt密碼.Text);
                cmd.Parameters.AddWithValue("@Newname", txt員工姓名.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料修改成功");
                產生員工資料列表();
            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from 員工資料 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                lblID.Text = "";
                txt帳號.Clear();
                txt密碼.Clear();
                txt員工姓名.Clear();
                MessageBox.Show($"{rows} 筆資料刪除成功");
                產生員工資料列表();
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
            txt員工姓名.Clear();
        }

        void 產生員工資料列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select ID as 員工編號, 帳號, 密碼, 員工姓名 from 員工資料";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//HasRows是否有資料
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
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
                string strSQL = "select * from 員工資料 where 帳號 like @Searchcount";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcount", "%" + txt帳號.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("此帳號已被註冊");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelId = 0;
                bool isID = Int32.TryParse(strSelID, out intSelId);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "select * from 員工資料 where id = @searchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@searchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = string.Format("{0}", reader["id"]);
                        txt帳號.Text = string.Format("{0}", reader["帳號"]);
                        txt密碼.Text = string.Format("{0}", reader["密碼"]);
                        txt員工姓名.Text = string.Format("{0}", reader["員工姓名"]);
                    }
                    else
                    {
                        MessageBox.Show("查無此員工");
                        lblID.Text = string.Empty;
                        txt帳號.Clear();
                        txt密碼.Clear();
                        txt員工姓名.Clear();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }
    }
}
