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
    public partial class 目錄 : Form
    {
        List<string> listapplephone = new List<string>();
        List<string> listsamsungphone = new List<string>();
        List<int> listappleprice = new List<int>();
        List<int> listsamsungprice = new List<int>();
        List<string> list顏色 = new List<string>();
        List<string> list容量 = new List<string>();

        int number = 0;
        int price = 0;
        string oders = "";
        string color = "";
        string capacity = "";
        int total = 0;

        public 目錄()
        {
            InitializeComponent();
        }

        private void 目錄_Load(object sender, EventArgs e)
        {
            listapplephone.Add("iPhone 13 Pro Max");
            listapplephone.Add("iPhone 13 Pro");
            listapplephone.Add("iPhone 13");
            listapplephone.Add("iPhone 13 mini");
            listapplephone.Add("iPhone SE");
            listapplephone.Add("iPhone 12");
            listapplephone.Add("iPhone 12 mini");
            listapplephone.Add("iPhone 11");

            listappleprice.Add(36900);
            listappleprice.Add(32900);
            listappleprice.Add(25900);
            listappleprice.Add(22900);
            listappleprice.Add(13900);
            listappleprice.Add(22900);
            listappleprice.Add(19900);
            listappleprice.Add(16500);
            
            foreach (string item in listapplephone)
            {
                lbox蘋果手機.Items.Add(item);
            }

            listsamsungphone.Add("Galaxy S22 Ultra");
            listsamsungphone.Add("Galaxy S22+");
            listsamsungphone.Add("Galaxy S22");
            listsamsungphone.Add("Galaxy Note 20 Ultra");
            listsamsungphone.Add("Galaxy Note 20");
            listsamsungphone.Add("Galaxy S21 Ultra");
            listsamsungphone.Add("Galaxy S21+");
            listsamsungphone.Add("Galaxy S21");

            listsamsungprice.Add(38900);
            listsamsungprice.Add(29900);
            listsamsungprice.Add(24900);
            listsamsungprice.Add(43900);
            listsamsungprice.Add(35900);
            listsamsungprice.Add(35900);
            listsamsungprice.Add(32900);
            listsamsungprice.Add(27900);

            foreach (string item in listsamsungphone)
            {
                lbox三星手機.Items.Add(item);
            }

            number = 1;
            txt數量.Text = number.ToString();

            list顏色.Add("金色");
            list顏色.Add("黑色");
            list顏色.Add("白色");
            list顏色.Add("紅色");
            list顏色.Add("藍色");
            list顏色.Add("綠色");

            list容量.Add("128G");
            list容量.Add("256G");
            list容量.Add("512G");
            list容量.Add("1TB");

            foreach (string item in list顏色)
            {
                cbox顏色.Items.Add(item);
            }
            foreach (string item in list容量)
            {
                cbox容量.Items.Add(item);
            }
            cbox顏色.SelectedIndex = 0;
            cbox容量.SelectedIndex = 0;           
        }

        private void lbox蘋果手機_Click(object sender, EventArgs e)
        {
            lbox三星手機.SelectedIndex = -1;
        }

        private void lbox三星手機_Click(object sender, EventArgs e)
        {
            lbox蘋果手機.SelectedIndex = -1;
        }

        private void lbox蘋果手機_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lbox蘋果手機.SelectedIndex;
            if (selIndex >= 0)
            {
                oders = listapplephone[selIndex];
                price = listappleprice[selIndex];
            }
            else
            {
                lbox蘋果手機.SelectedIndex = -1;
            }
            lbl單價.Text = price.ToString() + "元";
            total = price * number;
            lbl總價.Text = total.ToString() + "元";
            txt數量.Text = "1";            
        }

        private void lbox三星手機_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lbox三星手機.SelectedIndex;
            if (selIndex >= 0)
            {
                oders = listsamsungphone[selIndex];
                price = listsamsungprice[selIndex];
            }
            else
            {
                lbox三星手機.SelectedIndex = -1;
            }
            lbl單價.Text = price.ToString() + "元";
            total = price * number;
            lbl總價.Text = total.ToString() + "元";
            txt數量.Text = "1";            
        }

        private void cbox顏色_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox顏色.SelectedIndex;
            color = list顏色[selIndex];
        }

        private void cbox容量_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox容量.SelectedIndex;
            capacity = list容量[selIndex];
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(txt數量.Text);
                total = number * price;
                lbl總價.Text = total.ToString() + "元";
            }
            catch
            {
                if (txt數量.Text != "")
                {
                    MessageBox.Show("請輸入數字");
                    txt數量.Clear();
                }
                else
                {
                    txt數量.Text = "";
                }
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            cbox顏色.Text = "";
            cbox容量.Text = "";
            txt數量.Text = "1";
            lbl單價.Text = "0元";
            lbl總價.Text = "0元";
            price = 0;
            total = 0;
            lbox蘋果手機.SelectedIndex = -1;
            lbox三星手機.SelectedIndex = -1;
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            if (lbox蘋果手機.SelectedIndex >= 0 || lbox三星手機.SelectedIndex >= 0)
            {
                if (cbox顏色.SelectedIndex >= 0 && cbox容量.SelectedIndex >= 0)
                {
                    phone a = new phone();
                    a.oders = oders;
                    a.price = price;
                    a.number = number;
                    a.color = color;
                    a.capacity = capacity;
                    a.total = total;                    
                    Globalvar.list訂購品項列表.Add(a);
                    MessageBox.Show("已加入結帳單");
                }
                else
                {
                    MessageBox.Show("請選擇顏色容量");
                }
            }
            else
            {
                MessageBox.Show("請選擇手機品項");
            }
        }

        
    }
}
