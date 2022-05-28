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
    public partial class 目錄 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<string> list品項名稱 = new List<string>();
        List<int> list品項價格 = new List<int>();        
        List<string> list顏色 = new List<string>();
        List<string> list容量 = new List<string>();
        List<int> list容量價格 = new List<int>();
        int 數量 = 0;
        int 單價 = 0;
        int 單價容量 = 0;
        string 訂購品項 = "";
        string 顏色 = "";
        string 容量 = "";
        int 容量價格 = 0;
        int 總價 = 0;

        public 目錄()
        {
            InitializeComponent();
        }

        private void 目錄_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "會員db";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            //lbox手機型號
            lbox手機型號.Items.Clear();
            string strSQL = "select * from 手機產品;";            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbox手機型號.Items.Add(string.Format("型號:{0}",reader["手機產品"]));
                list品項名稱.Add(string.Format("型號:{0}", reader["手機產品"]));
                list品項價格.Add(Convert.ToInt32(reader["最小容量價格"]));
            }           
            reader.Close();
            con.Close();
            //cbox顏色
            cbox顏色.Items.Clear();
            string strSQL1 = "select * from 手機顏色";
            SqlConnection con1 = new SqlConnection(myDBConnectionString);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                cbox顏色.Items.Add(string.Format("{0}", reader1["顏色"]));
                list顏色.Add(string.Format("{0}", reader1["顏色"]));
            }
            reader1.Close();
            con1.Close();
            //cbox容量
            cbox容量.Items.Clear();
            string strSQL2 = "select * from 手機容量";
            SqlConnection con2 = new SqlConnection(myDBConnectionString);
            con2.Open();            
            SqlCommand cmd2= new SqlCommand(strSQL2, con2);
            SqlDataReader reader2 = cmd2.ExecuteReader();            
            while (reader2.Read())
            {
                cbox容量.Items.Add(string.Format("{0}", reader2["容量"]));
                list容量.Add(string.Format("{0}", reader2["容量"]));
                list容量價格.Add(Convert.ToInt32(reader2["價格"]));
            }
            reader2.Close();
            con2.Close();

            數量 = 1;
            txt數量.Text = 數量.ToString();
            cbox顏色.SelectedIndex = 0;
            cbox容量.SelectedIndex = 0;            
        }

        void 顯示商品細項資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from 手機產品 where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue(@"SearchID", lbox手機型號.SelectedIndex+1);
            SqlDataReader reader = cmd.ExecuteReader();
            string image_dir = @"images\";
            string image_name = "";
            int i = 0;
            while (reader.Read())
            {
                image_name = reader["pimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void lbox手機型號_Click(object sender, EventArgs e)
        {
            顯示商品細項資訊();
        }

        private void lbox手機型號_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lbox手機型號.SelectedIndex;
            if (lbox手機型號.SelectedIndex >= 0)
            {
                訂購品項 = list品項名稱[selIndex];
                單價 = list品項價格[selIndex];                
            }
            //單價
            lbl單價.Text = 單價.ToString() + "元";
            總價 = 數量 * 單價;
            lbl總價.Text = 總價.ToString() + "元";
            //單價+容量
            單價容量 = 單價 + 容量價格;
            lbl單價.Text = 單價容量.ToString() + "元";
            總價 = 數量 * 單價容量;
            lbl總價.Text = 總價.ToString() + "元";
            //選擇其他品項重製
            txt數量.Text = "1";
        }

        private void cbox顏色_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox顏色.SelectedIndex;
            顏色 = list顏色[selIndex];
        }

        private void cbox容量_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox容量.SelectedIndex;
            容量 = list容量[selIndex];
            容量價格 = list容量價格[selIndex];
            單價容量 = 單價 + 容量價格;
            lbl單價.Text = 單價容量.ToString() + "元";
            總價 = 數量 * 單價容量;
            lbl總價.Text = 總價.ToString() + "元";
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            try
            {
                數量 = Convert.ToInt32(txt數量.Text);
                總價 = 數量 * 單價容量;
                lbl總價.Text = 總價.ToString() + "元";
            }
            catch
            {
                if (txt數量.Text != "")
                {
                    MessageBox.Show("請輸入數字");
                    txt數量.Clear();
                }
                else
                {
                    txt數量.Text = "";
                }
            }
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            if (lbox手機型號.SelectedIndex >= 0)
            {
                if (cbox顏色.SelectedIndex >= 0 && cbox容量.SelectedIndex >= 0)
                {
                    phone 購物車 = new phone();
                    購物車.訂購品項 = 訂購品項;
                    購物車.單價 = 單價;
                    購物車.數量 = 數量;
                    購物車.顏色 = 顏色;
                    購物車.容量 = 容量;
                    購物車.容量價格 = 容量價格;
                    購物車.總價 = 總價;
                    Globalvar.list訂購品項列表.Add(購物車);
                    MessageBox.Show("已加入結帳單");
                }
                else
                {
                    MessageBox.Show("請選擇顏色容量");
                }
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            lbox手機型號.ClearSelected();
            cbox顏色.Text = "";
            cbox容量.Text = "";
            txt數量.Text = "1";
            單價 = 0;
            總價 = 0;
            單價容量 = 0;
            容量價格 = 0;
            lbl單價.Text = "0元";
            lbl總價.Text = "0元";
            pictureBox1.Image = null;
        }

    }
}
