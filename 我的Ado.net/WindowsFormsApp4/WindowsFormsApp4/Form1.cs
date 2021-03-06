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
        //sql連線字串產生器
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果
        int int搜尋婚姻狀態 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //資料庫連線字串
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//.本機
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cbox欄位名稱.Items.Add("姓名");
            cbox欄位名稱.Items.Add("電話");
            cbox欄位名稱.Items.Add("地址");
            cbox欄位名稱.Items.Add("email");
            cbox欄位名稱.SelectedIndex = 0;

            radio婚姻全部.Checked = true;
            int搜尋婚姻狀態 = 0;//全部:0, 已婚:1, 未婚:2;

            產生會員資料列表();
        }

        private void btn資料筆數1_Click(object sender, EventArgs e)
        {
            //SqlConnection 連線SQL
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();//釋放SQL連線資源
            string strSQL = "select top 100 * from persons;";//SQL語言選前100筆資料
            SqlCommand cmd = new SqlCommand(strSQL, con);//對 SQL Server 資料庫執行的 Transact-SQL 陳述式或預存程序
            SqlDataReader reader = cmd.ExecuteReader();//資料集資料

            string strMsg = "";
            int i = 0;

            while(reader.Read())//資料回傳直到false 
            {
                /*strMsg += (int)reader["Id"] + (string)reader["姓名"] + (string)reader["電話"] + (string)reader["地址"]+(string)reader["email"] + "\n";//(int)(string)轉型提示*/
                strMsg += string.Format("ID:{0} 姓名:{1} 電話:{2} 地址:{3} Email:{4} 生日:{5} 婚姻狀態:{6} 點數:{7} \n",reader["Id"],reader["姓名"], reader["電話"], reader["地址"], reader["email"], reader["生日"], reader["婚姻狀態"], reader["點數"]);
                i += 1;
            }

            strMsg += "資料比數" + i.ToString();
            //要關閉不然會一直傳送占用資源
            reader.Close();//後進先出
            con.Close();//先進後出

            MessageBox.Show(strMsg);

        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from persons where 姓名 Like @SearchName;";//'%小%'改成參數 @SearchName代入 大小寫要一致
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //Parameters 屬性代入避免惡意攻擊 //AddWithValue 方法檢查惡意程式
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = string.Format("{0}",reader["Id"]);
                    txt姓名.Text = string.Format("{0}",reader["姓名"]);
                    txt電話.Text = string.Format("{0}", reader["電話"]);
                    txt地址.Text = string.Format("{0}", reader["地址"]);
                    txtemail.Text = string.Format("{0}", reader["email"]);
                    txt點數.Text = string.Format("{0}", reader["點數"]);
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    //清空欄位
                    lblID.Text = "";
                    txt姓名.Clear();
                    txt電話.Clear();
                    txt地址.Clear();
                    txtemail.Clear();
                    txt點數.Clear();
                    dtp生日.Value = DateTime.Now;
                    chk婚姻狀態.Checked = false;
                }
                reader.Close();
                con.Close();
            }
            else
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
                string strSQL = "update persons set 姓名=@NewName, 電話=@NewPhone,地址= @NewAddres,email=@NewEmail,生日=@NewBirthday,婚姻狀態=@NewMarriage,點數=@NewPoints where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddres", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int int點數 = 0;
                Int32.TryParse(txt點數.Text, out int點數);
                //cmd.Parameters.AddWithValue("@NewPoint",Convert.ToInt32(txt點數.Text));有可能會當掉
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();//ExecuteNonQuery只執行insert不做查詢
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
                string strSQL = "insert into persons values(@NewName,@NewPhone,@NewAddres,@NewEmail,@NewBirthday,@NewMarriage,@NewPoints)";
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@NewName",txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone",txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddres",txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail",txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday",dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage",chk婚姻狀態.Checked);
                int int點數 = 0;
                Int32.TryParse(txt點數.Text, out int點數);
                //cmd.Parameters.AddWithValue("@NewPoint",Convert.ToInt32(txt點數.Text));有可能會當掉
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();//ExecuteNonQuery只執行insert不做查詢
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");
            }
            else
            {
                MessageBox.Show("姓名, 電話必須填寫");
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
                string strSQL = "delete from persons where id = @searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("searchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                lblID.Text = "";
                txt姓名.Clear();
                txt電話.Clear();
                txt地址.Clear();
                txtemail.Clear();
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
            txtemail.Clear();
            txt點數.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            //練習: 完成點數查詢欄位
            lbox搜尋結果.Items.Clear();
            searchIDs.Clear();
            string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
            string strSQL婚姻狀態查詢語法 = "";

            switch(int搜尋婚姻狀態)
            {
                case 0:
                    break;
                case 1:
                    strSQL婚姻狀態查詢語法 = " and (婚姻狀態 = 1)";
                    break;
                case 2:
                    strSQL婚姻狀態查詢語法 = " and (婚姻狀態 = 0)";
                    break;
                default:
                    break;
            }

            if (txt欄位關鍵字.Text != "")
            {
                //select*from  persons where (姓名 like '%小%') and (生日 >= '1980-01-01'and 生日 <= '2000-01-01') and (婚姻狀態 = 1)姓名改用選得避免駭客入侵
                string strSQL = "select*from  persons where (" +str欄位名稱 + " like @searchname) and (生日 >= @startdate and 生日 <= @enddate)" + strSQL婚姻狀態查詢語法;

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@searchname","%" + txt欄位關鍵字.Text + "%");
                cmd.Parameters.AddWithValue("@startdate",dtp開始生日.Value);
                cmd.Parameters.AddWithValue("@enddate", dtp結束生日.Value);               



                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while(reader.Read())
                {
                    lbox搜尋結果.Items.Add(reader["姓名"]);
                    searchIDs.Add((int)reader["id"]);
                    i += 1;
                }

                if (i <= 0)
                {
                    MessageBox.Show("查無此人");
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }

        private void lbox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox搜尋結果.SelectedIndex >= 0)
            {
                int intID = searchIDs[lbox搜尋結果.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from persons where id = @searchID";
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@searchID", intID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblID.Text = string.Format("{0}", reader["Id"]);
                    txt姓名.Text = string.Format("{0}", reader["姓名"]);
                    txt電話.Text = string.Format("{0}", reader["電話"]);
                    txt地址.Text = string.Format("{0}", reader["地址"]);
                    txtemail.Text = string.Format("{0}", reader["email"]);
                    txt點數.Text = string.Format("{0}", reader["點數"]);
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    //清空欄位
                    lblID.Text = "";
                    txt姓名.Clear();
                    txt電話.Clear();
                    txt地址.Clear();
                    txtemail.Clear();
                    txt點數.Clear();
                    dtp生日.Value = DateTime.Now;
                    chk婚姻狀態.Checked = false;
                }
                reader.Close();
                con.Close();
            }

        }

        private void radio婚姻全部_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 0;
        }

        private void radio婚姻已婚_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 1;
        }

        private void radio婚姻未婚_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 2;
        }

        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select ID as 會員編號, 姓名, 電話, email, 點數, 婚姻狀態 from persons";
            SqlCommand cmd = new SqlCommand(strSQL,con);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // e代表點擊 Rows[e.RowIndex]取得那筆資料的索引值  Cells[0].Value取得第一筆欄位的值
                string strSelID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelId = 0;
                bool isID = Int32.TryParse(strSelID, out intSelId);//轉成數字

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "select * from persons where id = @searchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@searchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = string.Format("{0}", reader["Id"]);
                        txt姓名.Text = string.Format("{0}", reader["姓名"]);
                        txt電話.Text = string.Format("{0}", reader["電話"]);
                        txt地址.Text = string.Format("{0}", reader["地址"]);
                        txtemail.Text = string.Format("{0}", reader["email"]);
                        txt點數.Text = string.Format("{0}", reader["點數"]);
                        dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                        chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        //清空欄位
                        lblID.Text = "";
                        txt姓名.Clear();
                        txt電話.Clear();
                        txt地址.Clear();
                        txtemail.Clear();
                        txt點數.Clear();
                        dtp生日.Value = DateTime.Now;
                        chk婚姻狀態.Checked = false;
                    }
                    reader.Close();
                    con.Close();
                }
            }    
        }
    }
}
