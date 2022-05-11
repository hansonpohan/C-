using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class FormAccount : Form
    {

        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

        }

        

        private void btn確認_Click(object sender, EventArgs e)
        {
            string 目前輸入名稱 = txt設定使用者名稱.Text;
            string 目前輸入Email = txtEmail.Text;
            int index = 0;
            int index2 = 0;
            index = Array.IndexOf(GlobalVar.設定使用者名稱, 目前輸入名稱);
            index2 = Array.IndexOf(GlobalVar.設定Email, 目前輸入Email);

            if (GlobalVar.count > 4)
            {
                MessageBox.Show("用戶已達上限");
            }
            else
            {
                if (txt設定密碼.Text != txt確認密碼.Text)
                {
                    MessageBox.Show("確認密碼錯誤", "錯誤");
                }
                else
                {
                    if ((index != -1) || (index2 != -1))
                    {
                        MessageBox.Show("此帳號或Email已被使用");
                    }
                    else
                    {
                        GlobalVar.設定使用者名稱[GlobalVar.count] = txt設定使用者名稱.Text;
                        GlobalVar.設定密碼[GlobalVar.count] = txt設定密碼.Text;
                        GlobalVar.設定Email[GlobalVar.count] = txtEmail.Text;
                        MessageBox.Show("申請成功");
                        GlobalVar.count += 1;
                    }
                }
            }
            


            foreach (string mystr in GlobalVar.設定使用者名稱)
            {
                Console.WriteLine(mystr);
            }
            foreach (string mystr2 in GlobalVar.設定密碼)
            {
                Console.WriteLine(mystr2);
            }
            foreach (string mystr3 in GlobalVar.設定Email)
            {
                Console.WriteLine(mystr3);
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt設定使用者名稱.Clear();
            txt設定密碼.Clear();
            txt確認密碼.Clear();
        }
    }
}
