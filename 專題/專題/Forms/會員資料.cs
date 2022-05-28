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
    public partial class 會員資料 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        public 會員資料()
        {
            InitializeComponent();
        }

        private void 會員資料_Load(object sender, EventArgs e)
        {
            lbl員工.Text = "員工:  " + Globalvar.員工名稱;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            產生會員資料列表();
            產生訂單資料列表();
        }

        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select ID as 會員編號, 帳號, 密碼, 姓名, 電話, 地址, email , 生日 from 會員資料";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    string strSQL = "select * from 會員資料 where id = @searchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@searchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        void 產生訂單資料列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select ID as 訂單, 訂單編號, 會員名稱, 訂購品項, 單價, 數量, 顏色, 容量, 容量價格, 總價 from 訂單測試";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//HasRows是否有資料
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    string strSQL = "select * from 訂單測試 where id = @searchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@searchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                    }
                    else
                    {
                        MessageBox.Show("查無此訂單");
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }
    }
}
