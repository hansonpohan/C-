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
        List<string> list品項名稱 = new List<string>(); //key
        List<int> list品項價格 = new List<int>(); //value
        List<string> list甜度 = new List<string>();
        List<string> list冰塊 = new List<string>();
        List<string> list加料 = new List<string>();
        List<int> list加料價格 = new List<int>();
        //作業規格: 加料價格

        int 品項杯數 = 0;
        int 單價 = 0;
        int 品項總價 = 0;
        string 訂購品項 = "";
        string 甜度 = "";
        string 冰塊 = "";
        string 加料 = "";
        int 加料價格 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //key
            list品項名稱.Add("紅茶");
            list品項名稱.Add("綠茶");
            list品項名稱.Add("奶茶");
            //value
            list品項價格.Add(20);
            list品項價格.Add(25);
            list品項價格.Add(40);

            foreach (string itemName in list品項名稱)
            {
                lbox冷飲品項.Items.Add(itemName);
            }
            //lbox冷飲品項.SelectedIndex = 1; //預選
            品項杯數 = 1;
            txt杯數.Text = 品項杯數.ToString();

            //甜度
            list甜度.Add("正常");
            list甜度.Add("半糖");
            list甜度.Add("少糖");
            list甜度.Add("微糖");

            foreach(string itemName in list甜度)
            {
                cbox甜度.Items.Add(itemName);
            }
            //冰塊

            //加料, 有價格


        }

        private void lbox冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lbox冷飲品項.SelectedIndex;
            訂購品項 = list品項名稱[selIndex];
            單價 = list品項價格[selIndex];
            lbl單價.Text = 單價.ToString() + "元";
            品項總價 = 品項杯數 * 單價;
            lbl品項總價.Text = 品項總價.ToString() + "元";
        }

        private void cbox甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox甜度.SelectedIndex;
            甜度 = list甜度[selIndex];
        }

        private void cbox冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbox配料_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt杯數_TextChanged(object sender, EventArgs e)
        {
            品項杯數 = Convert.ToInt32(txt杯數.Text);
            品項總價 = 品項杯數 * 單價;
            lbl品項總價.Text = 品項總價.ToString() + "元";
            //作業規格: 品項杯數避免與改正輸入錯誤
        }

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            ArrayList 品項訂購資訊 = new ArrayList(); //作業請用自訂類別
            品項訂購資訊.Add(訂購品項);
            品項訂購資訊.Add(單價);
            品項訂購資訊.Add(品項杯數);
            品項訂購資訊.Add(品項總價);
            品項訂購資訊.Add(甜度);
            品項訂購資訊.Add(冰塊);
            品項訂購資訊.Add(加料);
            品項訂購資訊.Add(加料價格);
            GlobalVar.list訂購品項列表.Add(品項訂購資訊);
            GlobalVar.訂購人資訊 = txt訂購人電話.Text;

            MessageBox.Show("已加入結帳單");
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單 = this;

            Form2 form結帳單 = new Form2();
            GlobalVar.form結帳單 = form結帳單;
            form結帳單.Show();
            this.Hide();
        }
    }
}
