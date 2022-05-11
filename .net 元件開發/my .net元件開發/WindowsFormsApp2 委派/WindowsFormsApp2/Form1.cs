using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string msg);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void MethodOne(string mymsg)
        {
            string strOut = "MethodOne 執行, 傳遞參數:" + mymsg;
            MessageBox.Show(strOut);
        }
        //myDelegateObj = MethodOne    call by reference
        void passDelegateMethod(MyDelegate myDelegateObj)
        {
            myDelegateObj("成功執行 !!");
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {//測試Delegate ,delegateTest 代表 MethodOne 整體物件化形式
            MyDelegate delegateTest = MethodOne;
            passDelegateMethod(delegateTest);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {//沒有回傳值
            Action<int, int> actionPlus = plus;//Action<,>要物件化方法的參數
            actionPlus(7,8);

        }

        void plus(int a, int b)
        {
            int sum = a + b;
            MessageBox.Show("action demo: " + sum);
        }
        private void btnFunc_Click(object sender, EventArgs e)
        {//有回傳值
            Func<int, int, int, int> funcSum = sum;//第四個參數是回傳值
            MessageBox.Show("Func demo: " + funcSum(1, 2, 3));
        }

        int sum(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }
}
