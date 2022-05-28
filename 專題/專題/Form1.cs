using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專題
{
    public partial class Form1 : Form
    {
        private Form activeform;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void openchildform(Form childform, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            存放form.Controls.Add(childform);
            存放form.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbltitle.Text = childform.Text;
        }

        private void btn登入系統_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.顧客登入系統(), sender);
            Globalvar.form登入 = this;
        }

        private void btn註冊帳號_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.註冊帳號(), sender);
        }

        private void btn員工登入系統_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.員工登入系統(), sender);
            Globalvar.form登入 = this;
        }

        private void btn返回主頁_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            lbltitle.Text = "Home";
        }
        
    }
}
