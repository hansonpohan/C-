using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            //string[] str帳號 = { "黃小貓", "王小明", "陳大貓" };
            //string[] strPass = { "23456", "12345", "56789" };
            string[] str帳號 = GlobalVar.設定使用者名稱;
            string[] strPass = GlobalVar.設定密碼;

            //思考練習: 如何做? 鍵值對應陣列儲存比對帳號密碼

            int index = 0;
            String strSearch帳號 = txt使用者名稱.Text;
            index = Array.IndexOf(str帳號, strSearch帳號);

            if (index == -1)
            {
                MessageBox.Show("查無此帳號", "錯誤");
                lbl回應訊息.Text = "查無此帳號";
                txt密碼.Clear();
            }
            else
            {
                if ((txt使用者名稱.Text == str帳號[index]) && (txt密碼.Text == strPass[index]))
                {
                    MessageBox.Show("登入成功");
                    GlobalVar.目前使用者 = txt使用者名稱.Text;
                    lbl回應訊息.Text = GlobalVar.設定使用者名稱[index] + "，歡迎回來";
                    Form1 form人員建立 = new Form1();
                    form人員建立.Show();
                }
                else
                {
                    MessageBox.Show("密碼錯誤", "錯誤");
                    lbl回應訊息.Text = "密碼錯誤";
                    txt密碼.Clear();
                }
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt使用者名稱.Clear();
            txt密碼.Clear();
            lbl回應訊息.Text = "";
        }

        private void btn帳號申請_Click(object sender, EventArgs e)
        {
            FormAccount form帳號申請 = new FormAccount();
            form帳號申請.Show();
        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            Formlostpass form忘記密碼 = new Formlostpass();
            form忘記密碼.Show();
        }
    }
}
