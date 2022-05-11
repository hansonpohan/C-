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
        string[] 帳號;
        string[] pass;
        int[] password;
        string[] tempacount;
        int[] temppass;
        public FormLogin()
        {
            InitializeComponent();            
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            //思考練習: 如何做? 鍵值對應陣列儲存比對帳號密碼
            //string stracount = "黃小貓";
            //string strpass = "123456";
            string[] str帳號 = GlobalVar.acount;
            string[] str密碼 = GlobalVar.pass;

            string str = txt使用者名稱.Text;
            int index = 0;
            index = Array.IndexOf(str帳號,str);

            if (index == -1)
            {
                MessageBox.Show("帳號密碼錯誤");
            }
            else
            {
                if ((txt使用者名稱.Text == str帳號[index]) && (txt密碼.Text == str密碼[index]))
                {
                    MessageBox.Show("登入成功");

                    GlobalVar.目前使用者 = txt使用者名稱.Text;


                    // 要在form1_load 前存全域變數
                    Form1 form人員建立 = new Form1();
                    form人員建立.Show();

                }
                else
                {
                    lbl回應訊息.Text = "輸入帳號密碼錯誤";
                }
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt使用者名稱.Clear();
            txt密碼.Clear();
            lbl回應訊息.Text = "";
        }

        private void btn建立帳號_Click(object sender, EventArgs e)
        {
            FormAdd form新增 = new FormAdd();
            form新增.Show();
        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            
        }
    }
}
