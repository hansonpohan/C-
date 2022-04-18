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

        void 顯示歡迎訊息()//void無回傳值
        {
            MessageBox.Show("歡迎使用本程式");
        }

        private void btn無參數的方法_Click(object sender, EventArgs e)
        {
           int mysum = 計算1到5的總和();//有回傳值的方法必須有一個變數來接回傳值
            MessageBox.Show("計算1到5的總和:" + mysum);
        }

        int 計算1到5的總和()  //有回傳值
        {
            int sum = 0;
            sum = 1 + 2 + 3 + 4 + 5;
            return sum;//方法看到return就會停止執行並回傳sum,像迴圈中的break
            
        }


        private void btn有參數的方法_Click(object sender, EventArgs e)
        {
            有參數的方法("David", "Apple Watch", 12800.0, 5);
            //參數 parameters, 引數 arguments
        }

        void 有參數的方法(string name, string proudct, double price, int amount)
        {
            string output = string.Format($"{name} 購買 {proudct} 一共 {amount} 件 總價 {price * amount} 元");
            MessageBox.Show(output);
        }

        private void btn回傳值得方法_Click(object sender, EventArgs e)
        {
            int mysum = 總和(5, 4, 3, 2, 1);
            MessageBox.Show("總和:" + mysum);
        }

        int 總和(int a,int b,int c,int d,int e)
        {
            int sum = a + b + c + d + e;
            return sum;
        }

        //自訂方法





    }
}
