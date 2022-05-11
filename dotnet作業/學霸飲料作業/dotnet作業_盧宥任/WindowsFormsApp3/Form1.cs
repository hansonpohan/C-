using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int 品項杯數 = 0;
        int 單價 = 0;
        int 加料單價 = 0;
        int 品項總價 = 0;
        string 品名 = "";
        string 甜度 = "";
        string 冰塊 = "";
        string 加料 = "";
        int 加料價格 = 0;

        //作業規格:加料價格

        public Form1()
        {
            InitializeComponent();
        }

        品項資訊 飲料資訊 = new 品項資訊();

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] 品名列表 = { "茉莉綠茶", "阿薩姆紅茶", "黃金烏龍", "八冰綠", "多多綠", "紅茶拿鐵", "抹茶拿鐵", "阿華田拿鐵", "熟成紅茶", "熟成冷露", "春芽冷露", "胭脂多多" };
            int[] 單價列表 = { 30, 30, 30, 50, 50, 60, 60, 70, 35, 35, 35, 55 };

            飲料資訊.品名.AddRange(品名列表);
            飲料資訊.單價.AddRange(單價列表);

            for (int i = 0; i < 飲料資訊.品名.Count; i += 1)
            {
                lbox冷飲品項.Items.Add(飲料資訊.品名[i]);
            }

            string[] 加料列表 = { "珍珠", "布丁", "波霸","粉條","芋圓","仙草凍","愛玉","寒天" };
            int[] 加料價格列表 = { 10, 15, 10, 10, 15, 10, 15, 10 };
            飲料資訊.加料.AddRange(加料列表);
            飲料資訊.加料價格.AddRange(加料價格列表);

            for (int i = 0; i < 飲料資訊.加料.Count; i += 1)
            {
                lbox配料.Items.Add(飲料資訊.加料[i] + 飲料資訊.加料價格[i] + "元");
            }

            string[] 甜度列表 = { "正常", "半糖", "少糖","微糖","無糖" };
            飲料資訊.甜度.AddRange(甜度列表);

            for (int i = 0; i < 飲料資訊.甜度.Count; i += 1)
            {
                cbox甜度.Items.Add(飲料資訊.甜度[i]);
            }

            string[] 冰塊列表 = { "正常", "少冰", "微冰","去冰" };
            飲料資訊.冰塊.AddRange(冰塊列表);

            for (int i = 0; i < 飲料資訊.冰塊.Count; i += 1)
            {
                cbox冰塊.Items.Add(飲料資訊.冰塊[i]);
            }

            cbox甜度.SelectedIndex = 0;
            cbox冰塊.SelectedIndex = 0;

            //初始杯數1
            品項杯數 = 1;
            txt杯數.Text = 品項杯數.ToString();
            txt訂購人電話.Enabled = true;
        }

        private void lbox冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lbox冷飲品項.SelectedIndex;

            品名 = 飲料資訊.品名[selIndex];
            單價 = 飲料資訊.單價[selIndex];

            lbl單價.Text = string.Format("{0}元", 飲料資訊.單價[selIndex]);
            品項總價 = 品項杯數 * 單價;
            lbl品項總價.Text = 品項總價.ToString() + "元";

            lbox配料.SelectedItems.Clear();
            
        }

        private void cbox甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox甜度.SelectedIndex;
            甜度 = 飲料資訊.甜度[selIndex];

        }

        private void cbox冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox冰塊.SelectedIndex;
            冰塊 = 飲料資訊.冰塊[selIndex];

        }

        private void lbox配料_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> indexlist = new List<int>();
            加料 = "";
            加料價格 = 0;
            foreach(var item in lbox配料.SelectedItems)
            {
                indexlist.Add(lbox配料.Items.IndexOf(item));
            }
            foreach(int index in indexlist)
            {
                加料 += 飲料資訊.加料[index] + " ";
                加料價格 += 飲料資訊.加料價格[index];
            }
            加料單價 = 單價 + 加料價格;

            計算單價及總價();
        }

        private void txt杯數_TextChanged(object sender, EventArgs e)
        {
            bool sucess =int.TryParse(txt杯數.Text,out int result);
            if(txt杯數.Text != "")
            {
                if (sucess == true)
                {
                    品項杯數 = result;
                    計算單價及總價();
                }
                else
                {
                    MessageBox.Show("請輸入整數", "錯誤");
                    txt杯數.Text = "1";
                    品項杯數 = 1;
                }
            }
        }

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            if(txt訂購人電話.Text != "")
            {
                訂單資訊 訂購1 = new 訂單資訊();
                GlobalVar.訂購人資訊 = txt訂購人電話.Text;
                訂購1.品名 = 品名;
                訂購1.單價 = 單價;
                訂購1.加料單價 = 加料單價;
                訂購1.品項杯數 = 品項杯數;
                訂購1.品項總價 = 品項總價;
                訂購1.冰塊 = 冰塊;
                訂購1.甜度 = 甜度;
                訂購1.加料 = 加料;
                訂購1.加料價格 = 加料價格;
                GlobalVar.訂單資訊集合.Add(訂購1);
                MessageBox.Show("已加入結帳單");
                txt訂購人電話.Enabled = false;
            }
            else
            {
                MessageBox.Show("請輸入訂購資料", "錯誤");
            }

        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單 = this;
            Form2 form結帳單 = new Form2();
            GlobalVar.form結帳單 = form結帳單;
            form結帳單.Show();
            this.Hide(); //隱藏本表單
        }

        void 計算單價及總價()
        {
            品項總價 = 單價 * 品項杯數;
            lbl單價.Text = 單價.ToString() + "元";
            lbl品項總價.Text = 品項總價.ToString() + "元";

            if ((加料單價 != 0) && (加料單價 != 單價))
            {
                品項總價 = 加料單價 * 品項杯數;
                lbl單價.Text = 加料單價.ToString() + "元";
                lbl品項總價.Text = 品項總價.ToString() + "元";
            }
        }
    }
}
