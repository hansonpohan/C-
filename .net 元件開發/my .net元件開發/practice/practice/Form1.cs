using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn創建員工_Click(object sender, EventArgs e)
        {
            Person 員工1 = new Person();
            員工1.姓名 = "王大衛";




            員工1.顯示基本資料();
        }

        private void btn創建主管_Click(object sender, EventArgs e)
        {

        }

        private void btn列出所有員工_Click(object sender, EventArgs e)
        {

        }

        private void btn列出所有主管_Click(object sender, EventArgs e)
        {

        }
    }
}
