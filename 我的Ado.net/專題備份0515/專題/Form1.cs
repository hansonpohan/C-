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
            openchildform(new Forms.登入系統(), sender);
        }

        private void btn註冊帳號_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.註冊帳號(), sender);
        }

        
    }
}
