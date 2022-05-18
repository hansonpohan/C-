using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專題.Forms
{
    public partial class 結帳單 : Form
    {
        int int總價 = 0;
        public 結帳單()
        {
            InitializeComponent();
        }

        private void 結帳單_Load(object sender, EventArgs e)
        {
            lbl會員名稱.Text = "會員名稱:  " + Globalvar.會員名稱;
            foreach (phone 購物車 in Globalvar.list訂購品項列表)
            {
                string 訂購品項 = 購物車.訂購品項;
                int 單價 = 購物車.單價;
                int 數量 = 購物車.數量;
                string 顏色 = 購物車.顏色;
                string 容量 = 購物車.容量;
                int 容量價格 = 購物車.容量價格;
                int 總價 = 購物車.總價;
                string str訂單 = string.Format("{0},單價:{1}元,{2}支,顏色:{3},容量:{4},容量價格:{5},總價:{6}元", 訂購品項, 單價, 數量, 顏色, 容量, 容量價格, 總價);
                lbox訂購品項列表.Items.Add(str訂單);
                計算總價();
            }
        }

        private void lbox訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lbox訂購品項列表.SelectedIndex >= 0)
            {
                int selIndex = lbox訂購品項列表.SelectedIndex;
                lbox訂購品項列表.Items.RemoveAt(selIndex);
                Globalvar.list訂購品項列表.RemoveAt(selIndex);
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
            計算總價();
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lbox訂購品項列表.Items.Clear();
            Globalvar.list訂購品項列表.Clear();
            計算總價();
        }

        void 計算總價()
        {
            int總價 = 0;
            foreach (phone 購物車 in Globalvar.list訂購品項列表)
            {
                int總價 += 購物車.總價;
            }
            lbl訂單總價.Text = "總價:" + int總價.ToString() + "元";
        }

        private void btn儲存訂單_Click(object sender, EventArgs e)
        {

        }

        private void btn修改訂單_Click(object sender, EventArgs e)
        {

        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請選擇付款方式");
        }
    }
}
