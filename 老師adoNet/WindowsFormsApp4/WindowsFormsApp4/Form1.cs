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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from persons;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;

            while(reader.Read())
            {
                strMsg += (int)reader["Id"] + (string)reader["姓名"] + (string)reader["電話"] + "\n";
                i += 1;
            }

            strMsg += "資料筆數" + i.ToString();

            reader.Close();
            con.Close();

            MessageBox.Show(strMsg);

        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from persons where 姓名 like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = string.Format("{0}", reader["Id"]);
                    txt姓名.Text = string.Format("{0}", reader["姓名"]);
                    txt電話.Text = string.Format("{0}", reader["電話"]);
                    txt地址.Text = string.Format("{0}", reader["地址"]);
                    txtEmail.Text = string.Format("{0}", reader["email"]);
                    txt點數.Text = string.Format("{0}", reader["點數"]);
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                } else
                {
                    MessageBox.Show("查無此人");
                    lblID.Text = "";
                    txt姓名.Clear();
                    txt電話.Clear();
                    txt地址.Clear();
                    txtEmail.Clear();
                    txt點數.Clear();
                    dtp生日.Value = DateTime.Now;
                    chk婚姻狀態.Checked = false;
                }
                reader.Close();
                con.Close();
            } else
            {
                MessageBox.Show("請輸入姓名關鍵字搜尋");
            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update persons set 姓名=@NewName,電話=@NewPhone,地址=@NewAddress,email=@NewEmail,生日=@NewBirthday,婚姻狀態=@NewMarriage,點數=@NewPoints where Id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int int點數 = 0;
                Int32.TryParse(txt點數.Text, out int點數);
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料修改成功");
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into persons values(@NewName, @NewPhone,@NewAddress,@NewEmail,@NewBirthday,@NewMarriage,@NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int int點數 = 0;
                Int32.TryParse(txt點數.Text, out int點數);
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");
            }
            else
            {
                MessageBox.Show("姓名, 電話必需填寫");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from persons where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                lblID.Text = "";
                txt姓名.Clear();
                txt電話.Clear();
                txt地址.Clear();
                txtEmail.Clear();
                txt點數.Clear();
                dtp生日.Value = DateTime.Now;
                chk婚姻狀態.Checked = false;

                MessageBox.Show($"{rows} 筆資料刪除成功");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            txt點數.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }
    }
}
