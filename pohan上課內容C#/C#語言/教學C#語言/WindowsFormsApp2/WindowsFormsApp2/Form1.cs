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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {
            if (txt公分.Text != "") // "" 空字串
            {
                try
                {
                    float myCm = 0.0f;
                    float myInch = 0.0f;
                    string strInput = txt公分.Text;
                    myCm = System.Convert.ToSingle(strInput);
                    myInch = myCm * 0.3937f;
                    //txt英吋.Text = Convert.ToString(myInch);
                    txt英吋.Text = string.Format("{0:F2}", myInch);
                }

                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(), "發生錯誤");
                    //MessageBox.Show("輸入公分格式錯誤, 請重新輸入", "發生錯誤");
                    txt英吋.Clear();
                }

                finally
                {
                    txt坪數.Clear();
                    txt平方公尺.Clear();
                    txt公斤.Clear();
                    txt磅.Clear();
                }
            } else
            {
                MessageBox.Show("請輸入公分數值");
            }
        }

        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {
            //回家練習
        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            // double, 比例 3.3058
            if (txt坪數.Text.Length > 0)
            {
                try
                {
                    double my坪數, my平方公尺 = 0.0;
                    my坪數 = Convert.ToDouble(txt坪數.Text);
                    my平方公尺 = my坪數 * 3.3058;
                    txt平方公尺.Text = my平方公尺.ToString();
                }
                
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(), "發生錯誤");
                    //MessageBox.Show("輸入坪數格式錯誤, 請重新輸入", "發生錯誤");
                    txt平方公尺.Clear();
                }

                finally
                {
                    txt公分.Clear();
                    txt英吋.Clear();
                    txt公斤.Clear();
                    txt磅.Clear();
                }
            } else
            {
                MessageBox.Show("請輸入坪數數值");
            }
        }

        private void btn平方公尺轉坪數_Click(object sender, EventArgs e)
        {
            //回家練習
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            // double, 比例 2.2
            if (txt公斤.Text.Length > 0)
            {
                double myKg, myPound = 0.0;
                bool isRight = false;

                isRight = System.Double.TryParse(txt公斤.Text, out myKg);

                if (isRight == true)
                {
                    myPound = myKg * 2.2;
                    txt磅.Text = string.Format("{0:F2}", myPound);
                } else
                {
                    MessageBox.Show("轉換失敗, 請輸入正確的公斤格式數值");
                    txt磅.Clear();
                }

                txt公分.Clear();
                txt英吋.Clear();
                txt坪數.Clear();
                txt平方公尺.Clear();
            } else
            {
                MessageBox.Show("請輸入公司數值");
            }
        }

        private void btn磅轉公斤_Click(object sender, EventArgs e)
        {
            //回家練習
        }
    }
}
