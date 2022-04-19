using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            顯示歡迎訊息();
        }

        static void 顯示歡迎訊息()
        {
            MessageBox.Show("歡迎使用本程式");
        }

        private void btn無參數的方法_Click(object sender, EventArgs e)
        {
            int mySum = 計算1到5的總和();
            MessageBox.Show("1到5的總和:" + mySum);
        }

        int 計算1到5的總和()
        {
            int sum = 0;
            sum = 1 + 2 + 3 + 4 + 5;
            return sum; //停止, 並回傳sum
        }

        private void btn有參數的方法_Click(object sender, EventArgs e)
        {
            有參數的方法("David", "Apple Watch", 12800.0, 5);
            //參數 parameters, 引數 arguments
        }

        void 有參數的方法(string name, string product, double price, int amount)
        {
            string output = string.Format($"{name} 購買 {product} 一共 {amount} 件 總價 { price  * amount} 元");
            MessageBox.Show(output);
        }


        private void btn回傳值的方法_Click(object sender, EventArgs e)
        {
            int mySum = 總和(5, 4, 3, 2, 1);
            MessageBox.Show("總和:" + mySum);
        }

        int 總和(int a, int b, int c, int d, int e)
        {
            int sum = a + b + c + d + e;
            return sum;
        }



    }
}
