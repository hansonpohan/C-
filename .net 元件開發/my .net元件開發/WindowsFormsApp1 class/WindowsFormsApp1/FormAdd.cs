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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }        
         
        private void btn新增帳號_Click(object sender, EventArgs e)
        {
            string str = txt帳號.Text;
            int index = 0;
            index = Array.IndexOf(GlobalVar.acount, str);

            if (index == -1)
            {
                if (GlobalVar.count < 5)
                {
                    GlobalVar.acount[GlobalVar.count] = txt帳號.Text;
                    GlobalVar.pass[GlobalVar.count] = txt密碼.Text;
                    GlobalVar.count += 1;
                }
                else
                {
                    MessageBox.Show("用戶已滿");
                }
            }            
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
        }
    }
}
