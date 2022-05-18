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
    public partial class Form3員工登入修改 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>();
        public Form3員工登入修改()
        {
            InitializeComponent();
        }

        private void Form3員工登入修改_Load(object sender, EventArgs e)
        {
            lbl員工.Text = "員工:  " + Globalvar.會員名稱;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();           
        }

        private void btn型號搜尋_Click(object sender, EventArgs e)
        {
            lbox手機型號.Items.Clear();
            searchIDs.Clear();
            if (txt手機產品.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 手機產品 where 手機產品 like @Searchphone";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchphone", "%" + txt手機產品.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    lbox手機型號.Items.Add((string)reader["手機產品"]);
                    searchIDs.Add((int)reader["id"]);
                    i += 1;
                }
                if (i <= 0)
                {
                    MessageBox.Show("查無此型號");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入手機型號關鍵字搜尋");
            }
        }

        private void lbox手機型號_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox手機型號.SelectedIndex >= 0)
            {
                int intID = searchIDs[lbox手機型號.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 手機產品 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl型號ID.Text = string.Format("{0}", reader["id"]);
                    txt手機產品.Text = string.Format("{0}", reader["手機產品"]);
                    txt型號價格.Text = string.Format("{0}", reader["最小容量價格"]);
                }
                else
                {
                    MessageBox.Show("查無此型號");
                    lbl型號ID.Text = "";
                    txt手機產品.Clear();
                    txt型號價格.Clear();
                    lbox手機型號.Items.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn型號新增_Click(object sender, EventArgs e)
        {
            if ((txt手機產品.Text != "") && (txt型號價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into 手機產品 values(@Newphone, @Newprice);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newphone", txt手機產品.Text);
                cmd.Parameters.AddWithValue("@Newprice", txt型號價格.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");
            }
            else
            {
                MessageBox.Show("手機產品, 型號價格必需填寫");
            }
        }

        private void btn型號修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl型號ID.Text, out intID);

            if ((intID > 0) && (txt手機產品.Text != "") && (txt型號價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update 手機產品 set 手機產品=@Newphone,最小容量價格=@Newprice where Id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@Newphone", txt手機產品.Text);
                cmd.Parameters.AddWithValue("@Newprice", txt型號價格.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料修改成功");
            }
        }

        private void btn型號刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl型號ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from 手機產品 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                lbl型號ID.Text = "";
                txt手機產品.Clear();
                txt型號價格.Clear();
                lbox手機型號.Items.Clear();
                MessageBox.Show($"{rows} 筆資料刪除成功");
            }
        }
        private void btn型號清空_Click(object sender, EventArgs e)
        {
            lbl型號ID.Text = "";
            txt手機產品.Clear();
            txt型號價格.Clear();
            lbox手機型號.Items.Clear();
        }

        private void btn顏色搜尋_Click(object sender, EventArgs e)
        {
            searchIDs.Clear();
            if (txt顏色.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 手機顏色 where 顏色 like @Searchcolor";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcolor", "%" + txt顏色.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    lbox手機顏色.Items.Add((string)reader["顏色"]);
                    searchIDs.Add((int)reader["id"]);
                    i += 1;
                }
                if (i <= 0)
                {
                    MessageBox.Show("查無此顏色");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入顏色關鍵字搜尋");
            }
        }

        private void lbox手機顏色_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox手機顏色.SelectedIndex >= 0)
            {
                int intID = searchIDs[lbox手機顏色.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 手機顏色 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl顏色ID.Text = string.Format("{0}", reader["id"]);
                    txt顏色.Text = string.Format("{0}", reader["顏色"]);                    
                }
                else
                {
                    MessageBox.Show("查無此顏色");
                    lbl顏色ID.Text = "";
                    txt顏色.Clear();
                    lbox手機顏色.Items.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn顏色新增_Click(object sender, EventArgs e)
        {
            if (txt顏色.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into 手機顏色 values (@Newcolor);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newcolor", txt顏色.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");
            }
            else
            {
                MessageBox.Show("手機顏色必需填寫");
            }
        }

        private void btn顏色修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl顏色ID.Text, out intID);

            if ((intID > 0) && (txt顏色.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update 手機顏色 set 顏色=@Newcolor where Id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@Newcolor", txt顏色.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料修改成功");
            }
        }

        private void btn顏色刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl顏色ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from 手機顏色 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                lbl顏色ID.Text = "";
                txt顏色.Clear();
                lbox手機顏色.Items.Clear();
                MessageBox.Show($"{rows} 筆資料刪除成功");
            }
        }

        private void btn顏色清空_Click(object sender, EventArgs e)
        {
            lbl顏色ID.Text = "";
            txt顏色.Clear();
            lbox手機顏色.Items.Clear();
        }

        private void btn容量搜尋_Click(object sender, EventArgs e)
        {
            lbox手機容量.Items.Clear();
            searchIDs.Clear();
            if (txt容量.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 手機容量 where 容量 like @Searchcapacity";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcapacity", "%" + txt容量.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    lbox手機容量.Items.Add((string)reader["容量"]);
                    searchIDs.Add((int)reader["id"]);
                    i += 1;
                }
                if (i <= 0)
                {
                    MessageBox.Show("查無此容量");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入手機容量關鍵字搜尋");
            }
        }

        private void lbox手機容量_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox手機容量.SelectedIndex >= 0)
            {
                int intID = searchIDs[lbox手機容量.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 手機容量 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl容量ID.Text = string.Format("{0}", reader["id"]);
                    txt容量.Text = string.Format("{0}", reader["容量"]);
                    txt容量價格.Text = string.Format("{0}", reader["價格"]);
                }
                else
                {
                    MessageBox.Show("查無此容量");
                    lbl容量ID.Text = "";
                    txt容量.Clear();
                    txt容量價格.Clear();
                    lbox手機容量.Items.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn容量新增_Click(object sender, EventArgs e)
        {
            if ((txt容量.Text != "") && (txt容量價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into 手機容量 values(@Newcapacity, @Newprice);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newcapacity", txt容量.Text);
                cmd.Parameters.AddWithValue("@Newprice", txt容量價格.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");
            }
            else
            {
                MessageBox.Show("容量, 容量價格必需填寫");
            }
        }

        private void btn容量修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl容量ID.Text, out intID);

            if ((intID > 0) && (txt容量.Text != "") && (txt容量價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update 手機容量 set 容量=@Newcapacity,價格=@Newprice where Id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@Newcapacity", txt容量.Text);
                cmd.Parameters.AddWithValue("@Newprice", txt容量價格.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料修改成功");
            }
        }

        private void btn容量刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl容量ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from 手機容量 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                lbl容量ID.Text = "";
                txt容量.Clear();
                txt容量價格.Clear();
                lbox手機容量.Items.Clear();
                MessageBox.Show($"{rows} 筆資料刪除成功");
            }
        }

        private void btn容量清空_Click(object sender, EventArgs e)
        {
            lbl容量ID.Text = "";
            txt容量.Clear();
            txt容量價格.Clear();
            lbox手機容量.Items.Clear();
        }
    }
}
