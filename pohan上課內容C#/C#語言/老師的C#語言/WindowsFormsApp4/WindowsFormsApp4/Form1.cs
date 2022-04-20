using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void btnCBV測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBV1.Text = "變數在傳遞前的值:" + x.ToString();
            callByValue(x);
            lblCBV3.Text = "變數在傳遞後的值:" + x.ToString();
        }

        void callByValue(int y)
        {
            y += 1;
            lblCBV2.Text = "參數在方法裡面的值:" + y.ToString();
        }

        private void btnCBR測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBR1.Text = "變數在傳遞前的值:" + x.ToString();
            callByReference(ref x);
            lblCBR3.Text = "變數在傳遞後的值:" + x.ToString();
        }

        void callByReference(ref int y)
        {
            y += 1;
            lblCBR2.Text = "參數在方法裡面的值:" + y.ToString();
        }
    }
}
