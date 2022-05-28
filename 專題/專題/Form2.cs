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
    public partial class Form2 : Form
    {
        private Form activeform;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void btn目錄_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.目錄(), sender);
        }

        private void btn結帳單_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.結帳單(), sender);
        }

        private void btn會員功能_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.會員功能(), sender);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globalvar.form登入.Show();            
        }

        private void btn返回主頁_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            lbltitle.Text = "Home";
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            Globalvar.form訂單.Close();
        }
    }
}
