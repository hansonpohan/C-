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
        }

        private void btn修改會員資料_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(lblID.Text,out intId);
            if ((intId > 0) && (txt帳號.Text != "") && (txt密碼.Text != "") && (txt姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update 會員 set 帳號=@NewCount,密碼=@NewPass,姓名=@NewName,電話=@NewPhone,地址=@NewAddress,Email=@NewEmail,生日=@NewBirthday where id=@SearchID;";
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

        private void btn登出_Click(object sender, EventArgs e)
        {
            Globalvar.form訂單.Close();
        }
    }
}
