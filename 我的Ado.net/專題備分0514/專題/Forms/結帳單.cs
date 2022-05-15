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
        int intprice = 0;
        public 結帳單()
        {
            InitializeComponent();
        }

        private void 結帳單_Load(object sender, EventArgs e)
        {
            lbl訂單名稱.Text = Globalvar.訂購人資訊;

            foreach (phone a in Globalvar.list訂購品項列表)
            {
                string orders = a.oders;
                int price = a.price;
                int number = a.number;
                string color = a.color;
                string capacity = a.capacity;
                int total = a.total;

                string str商品資訊 = string.Format("{0},{1}元,{2}支,{3},{4},{5}元",orders,price,number,color,capacity,total);
                lbox訂購品項列表.Items.Add(str商品資訊);
                計算訂單總價();
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
            計算訂單總價();
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lbox訂購品項列表.Items.Clear();
            Globalvar.list訂購品項列表.Clear();
            lbl訂單名稱.Text = "";
            計算訂單總價();
        }

        void 計算訂單總價()
        {                       
            if (lbl訂單總價.Text != "")
            {
                //每觸發事件要清空一次int總價
                intprice = 0;
                foreach (phone a in Globalvar.list訂購品項列表)
                {
                    intprice += a.total;
                }
            }
            lbl訂單總價.Text = intprice.ToString() + "元";
        }

            private void btn儲存訂單_Click(object sender, EventArgs e)
        {

        }

        private void btn刪除訂單_Click(object sender, EventArgs e)
        {

        }

        private void btn修改訂單_Click(object sender, EventArgs e)
        {

        }

        private void btn結帳_Click(object sender, EventArgs e)
        {

        }
    }
}
