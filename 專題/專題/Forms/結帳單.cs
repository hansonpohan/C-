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
    public partial class 結帳單 : Form
    {
        int int總價 = 0;
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        int count = 0;


        public 結帳單()
        {
            InitializeComponent();
        }

        private void 結帳單_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單編號測試";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                count++;
            }
            lbl訂單編號.Text = "A" + (count+1);

            lbl會員名稱.Text = Globalvar.會員名稱;
            foreach (phone 購物車 in Globalvar.list訂購品項列表)
            {
                string 訂購品項 = 購物車.訂購品項;
                int 單價 = 購物車.單價;
                int 數量 = 購物車.數量;
                string 顏色 = 購物車.顏色;
                string 容量 = 購物車.容量;
                int 容量價格 = 購物車.容量價格;
                int 總價 = 購物車.總價;
                string str訂單 = string.Format("{0},單價:{1}元,{2}支,顏色:{3},容量:{4},容量價格:{5},總價:{6}元", 訂購品項, 單價, 數量, 顏色, 容量, 容量價格, 總價);
                lbox訂購品項列表.Items.Add(str訂單);
                計算總價();
            }
            reader.Close();
            con.Close();
        }

        private void lbox訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lbox訂購品項列表.SelectedIndex >= 0)
            {
                int selIndex = lbox訂購品項列表.SelectedIndex;
                lbox訂購品項列表.Items.RemoveAt(selIndex);
                Globalvar.list訂購品項列表.RemoveAt(selIndex);
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
            計算總價();
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lbox訂購品項列表.Items.Clear();
            Globalvar.list訂購品項列表.Clear();
            計算總價();
        }

        void 計算總價()
        {
            int總價 = 0;
            foreach (phone 購物車 in Globalvar.list訂購品項列表)
            {
                int總價 += 購物車.總價;
            }
            lbl訂單總價.Text = "訂單總價:" + int總價.ToString() + "元";
        }

        private void btn下單_Click(object sender, EventArgs e)
        {
            if (lbox訂購品項列表.Items.Count != 0)
            {
                DialogResult R = MessageBox.Show("您確認要下單?", "確認下單", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    if (count == 0)
                    {
                        SqlConnection con = new SqlConnection(myDBConnectionString);
                        con.Open();
                        string strSQL = "insert into 訂單編號測試 values(@Newnumber);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@Newnumber", "A" + Convert.ToString(count + 1));
                        cmd.ExecuteNonQuery();
                        lbl訂單編號.Text = "A" + Convert.ToString(count + 1);
                        con.Close();
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(myDBConnectionString);
                        con.Open();
                        string strSQL = "insert into 訂單編號測試 values(@Newnumber);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@Newnumber", "A" + Convert.ToString(count + 1));
                        cmd.ExecuteNonQuery();
                        lbl訂單編號.Text = "A" + Convert.ToString(count + 1);
                        con.Close();
                        MessageBox.Show("您已成功下單");
                    }
                    for (int i = 0; i < lbox訂購品項列表.Items.Count; i += 1)
                    {
                        SqlConnection con = new SqlConnection(myDBConnectionString);
                        con.Open();
                        string strSQL = "insert into 訂單測試 values (@neworder,@newname,@newitem,@newprice,@newcount,@newcolor,@newcapacity,@newcapacityprice,@newtotal);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@neworder", lbl訂單編號.Text);
                        cmd.Parameters.AddWithValue("@newname", Globalvar.會員名稱);
                        cmd.Parameters.AddWithValue("@newitem", Globalvar.list訂購品項列表[i].訂購品項);
                        cmd.Parameters.AddWithValue("@newprice", Globalvar.list訂購品項列表[i].單價);
                        cmd.Parameters.AddWithValue("@newcount", Globalvar.list訂購品項列表[i].數量);
                        cmd.Parameters.AddWithValue("@newcolor", Globalvar.list訂購品項列表[i].顏色);
                        cmd.Parameters.AddWithValue("@newcapacity", Globalvar.list訂購品項列表[i].容量);
                        cmd.Parameters.AddWithValue("@newcapacityprice", Globalvar.list訂購品項列表[i].容量價格);
                        cmd.Parameters.AddWithValue("@newtotal", Globalvar.list訂購品項列表[i].總價);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    lbl訂單總價.Text = "訂單總價:";
                    lbox訂購品項列表.Items.Clear();
                    Globalvar.list訂購品項列表.Clear();

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("請選擇商品");
            }
        }
    }
}
