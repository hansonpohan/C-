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
using System.IO;

namespace WindowsFormsApp5
{
    public partial class FormDetail : Form
    {
        public int pid = 0;
        string myDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;
        
        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("pid:" + pid);
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            if (pid <= 0)
            {
                //新增商品模式
                groupBox新增商品.Visible = true;
                groupBox修改商品.Visible = false;
            } else
            {
                //修改商品模式
                groupBox新增商品.Visible = false;
                groupBox修改商品.Visible = true;
                顯示商品細項資訊();
            }
        }

        void 顯示商品細項資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from products where Id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue(@"SearchID", pid);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while(reader.Read())
            {
                lbl序號.Text = reader["Id"].ToString();
                txt商品名稱.Text = reader["pname"].ToString();
                txt商品價格.Text = reader["price"].ToString();
                txt商品描述.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMdHHmmss") + myRand.Next(1000,10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }

        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品價格.Text != "") && (txt商品名稱.Text != "") && (txt商品描述.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update products set pname=@NewPname, price=@NewPrice, pimage=@NewPimage, pdesc=@NewPdesc where Id=@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID",pid);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@NewPdesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功, 影響 " + rows + " 筆資料");

            }
            else
            {
                MessageBox.Show("所有欄位必填");
            } 
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            lbl序號.Text = "";
            txt商品名稱.Text = "";
            txt商品價格.Text = "";
            txt商品描述.Text = "";
            pictureBox1.Image = null;
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品價格.Text != "") && (txt商品名稱.Text != "") && (txt商品描述.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into products values(@NewPname, @NewPrice, @NewPdesc, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@NewPdesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功, 影響 " + rows + " 筆資料");

            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }
    }
}
