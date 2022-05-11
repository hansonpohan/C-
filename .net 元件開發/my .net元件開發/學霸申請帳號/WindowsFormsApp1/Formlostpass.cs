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
    public partial class Formlostpass : Form
    {
        public Formlostpass()
        {
            InitializeComponent();
        }

        private void Formlostpass_Load(object sender, EventArgs e)
        {

        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            string 目前輸入名稱 = txt設定使用者名稱.Text;
            int index = 0;
            index = Array.IndexOf(GlobalVar.設定使用者名稱, 目前輸入名稱);

            if (index != -1) 
            {
                if((txt設定使用者名稱.Text == GlobalVar.設定使用者名稱[index]) && (txtEmail.Text == GlobalVar.設定Email[index]))
                {
                    lbl密碼顯示.Text = GlobalVar.設定密碼[index];
                }
                else
                {
                    MessageBox.Show("帳號或Email錯誤", "錯誤");
                    lbl密碼顯示.Text = "輸入錯誤";
                }
            }
            else
            {
                MessageBox.Show("找不到此帳號", "錯誤");
                lbl密碼顯示.Text = "輸入帳號";
            }

            Console.WriteLine(index);

        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt設定使用者名稱.Clear();
            txtEmail.Clear();
            lbl密碼顯示.Text = "";
        }
    }
}
