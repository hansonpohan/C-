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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string myDBConnectionString = "";
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            讀取資料庫();
        }

        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;

            while(reader.Read())
            {
                listId.Add((int)reader["id"]);
                listName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                image_name = (string)reader["pimage"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }

        void listView的圖片模式()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile
            imageList1.ImageSize = new Size(120, 120);
            listView1.LargeImageList = imageList1; //LargeIcon, Tile
            listView1.SmallImageList = imageList1; //SmallIcon, List

            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listName[i];
                item.Tag = listId[i];
                listView1.Items.Add(item);
            }
        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            listView的圖片模式();
        }

        void listView的列表模式()
        {
            listView1.Clear();
            listView1.LargeImageList = null;
            listView1.SmallImageList = null;
            listView1.View = View.Details;
            listView1.Columns.Add("序號", 100);
            listView1.Columns.Add("商品名稱", 200);
            listView1.Columns.Add("商品價格", 80);
            listView1.FullRowSelect = true;

            for (int i = 0; i < listId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add(listName[i]);
                item.SubItems.Add(listPrice[i].ToString());
                item.Tag = listId[i];

                listView1.Items.Add(item);
            }
        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {
            listView的列表模式();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            FormDetail myFormDetail = new FormDetail();
            myFormDetail.ShowDialog();
        }

        private void btn重新載入_Click(object sender, EventArgs e)
        {
            listId.Clear();
            listName.Clear();
            listPrice.Clear();
            imageList1.Images.Clear();
            讀取資料庫();

            if (listView1.View == View.Details)
            {
                listView的列表模式();
            } else
            {
                listView的圖片模式();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            FormDetail myFormDetail = new FormDetail();
            myFormDetail.pid = (int)listView1.SelectedItems[0].Tag;
            myFormDetail.ShowDialog();
        }
    }
}
