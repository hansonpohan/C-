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
        
        //作業規個: 價料價格
        //私有欄位
        int 品項杯數 = 0;
        int 單價 = 0;        
        int 單價加料 = 0;
        string 訂購品項 = "";
        string 甜度 = "";
        string 冰塊 = "";
        string 加料 = "";
        int 加料價格 = 0;
        int 品項總價 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //key
            list品項名稱.Add("四季春");
            list品項名稱.Add("茉香綠");
            list品項名稱.Add("錫蘭紅");
            list品項名稱.Add("熟香烏龍");
            list品項名稱.Add("懷舊冬瓜茶");
            list品項名稱.Add("冬瓜四季春");
            list品項名稱.Add("經典奶茶");
            list品項名稱.Add("紅茶拿鐵");
            list品項名稱.Add("百香四季春");
            list品項名稱.Add("百香多多");
            list品項名稱.Add("芒果多多");
            list品項名稱.Add("寒天愛玉");
            //value
            list品項價格.Add(25);
            list品項價格.Add(30);
            list品項價格.Add(30);
            list品項價格.Add(25);
            list品項價格.Add(30);
            list品項價格.Add(35);
            list品項價格.Add(50);
            list品項價格.Add(60);
            list品項價格.Add(60);
            list品項價格.Add(75);
            list品項價格.Add(75);
            list品項價格.Add(65);

            foreach (string itemName in list品項名稱)
            {
                lbox冷飲品項.Items.Add(itemName);
            }
            //lbox冷飲品項.SelectedIndex = 0; // 預選
            品項杯數 = 1;
            txt數量.Text = 品項杯數.ToString();

            //甜度
            list甜度.Add("無糖");
            list甜度.Add("微糖");
            list甜度.Add("少糖");
            list甜度.Add("半糖");
            list甜度.Add("正常");

            foreach (string itemName in list甜度)
            {
                cbox甜度.Items.Add(itemName);
            }
            //冰塊
            list冰塊.Add("去冰");
            list冰塊.Add("微冰");
            list冰塊.Add("少冰");
            list冰塊.Add("半冰");
            list冰塊.Add("正常冰");

            foreach (string itemName in list冰塊)
            {
                cbox冰塊.Items.Add(itemName);
            }            
        }

        private void lbox冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lbox冷飲品項.SelectedIndex;
            訂購品項 = list品項名稱[selIndex];
            單價 = list品項價格[selIndex];
            //沒加料
            lbl單價.Text = 單價.ToString() + "元";
            品項總價 = 品項杯數 * 單價;
            lbl品項總價.Text = 品項總價.ToString() + "元";
            //加料
            單價加料 = 單價 + 加料價格;
            lbl單價.Text = 單價加料.ToString() + "元";
            品項總價 = 品項杯數 * 單價加料;
            lbl品項總價.Text = 品項總價.ToString() + "元";
            //選擇其他品項重製
            cbox甜度.Text = "";
            cbox冰塊.Text = "";
            txt數量.Text = "1";
            checkBox珍珠.Checked = false;
            checkBox椰果.Checked = false;
            checkBox奶蓋.Checked = false;
            checkBox多多布丁.Checked = false;            
        }

        private void cbox甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox甜度.SelectedIndex;
            甜度 = list甜度[selIndex];
        }

        private void cbox冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox冰塊.SelectedIndex;
            冰塊 = list冰塊[selIndex];
        }       

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            //作業規格: 品項杯數避免與改正輸入錯誤
            try
            {
                品項杯數 = Convert.ToInt32(txt數量.Text);
                品項總價 = 品項杯數 * 單價加料;
                lbl品項總價.Text = 品項總價.ToString() + "元";
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

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            /*ArrayList 品項訂購資訊 = new ArrayList(); //作業請用自訂類別
            品項訂購資訊.Add(訂購品項);
            品項訂購資訊.Add(單價);
            品項訂購資訊.Add(品項杯數);            
            品項訂購資訊.Add(甜度);
            品項訂購資訊.Add(冰塊);
            品項訂購資訊.Add(加料);
            品項訂購資訊.Add(加料價格);
            品項訂購資訊.Add(品項總價);
            品項訂購資訊.Add(GlobalVar.單價加料);*/

            //一定要選擇
            if (lbox冷飲品項.SelectedIndex >= 0)
            {
                if (cbox甜度.SelectedIndex >= 0 && cbox冰塊.SelectedIndex >= 0)
                {
                    Drink 購物車 = new Drink();
                    購物車.訂購品項 = 訂購品項;
                    購物車.單價 = 單價;
                    購物車.品項杯數 = 品項杯數;
                    購物車.甜度 = 甜度;
                    購物車.冰塊 = 冰塊;
                    購物車.加料 = 加料;
                    購物車.加料價格 = 加料價格;
                    購物車.品項總價 = 品項總價;
                    購物車.單價加料 = 單價加料;
                    GlobalVar.list訂購品項列表.Add(購物車);
                    GlobalVar.訂購人資訊 = txt訂購人電話.Text;
                    GlobalVar.單價加料.Add(購物車.單價加料);
                    GlobalVar.杯數.Add(購物車.品項杯數);
                    MessageBox.Show("已加入結帳單");
                }
                else
                {
                    MessageBox.Show("請選擇甜度冰塊");
                }
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }            
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            GlobalVar.訂購人資訊 = txt訂購人電話.Text;
            if (txt訂購人電話.Text == "")
            {
                MessageBox.Show("請輸入訂購人資訊");
            }
            else
            {
                GlobalVar.form菜單 = this;

                Form2 form結帳單 = new Form2();
                GlobalVar.form結帳單 = form結帳單;
                form結帳單.Show();
                this.Hide();
            }           
        }
        
        private void btn清除_Click(object sender, EventArgs e)
        {
            txt訂購人電話.Text = "";
            lbox冷飲品項.Text = "";
            cbox甜度.Text = "";
            cbox冰塊.Text = "";            
            txt數量.Text = "1";           
            checkBox珍珠.Checked = false;
            checkBox椰果.Checked = false;
            checkBox奶蓋.Checked = false;
            checkBox多多布丁.Checked = false;
            單價 = 0;
            品項總價 = 0;
            加料價格 = 0;
            lbl單價.Text = "0元";
            lbl品項總價.Text = "0元";
        }

        private void checkBox珍珠_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBox珍珠.Checked)
            {
                加料 += "珍珠";
                加料價格 += 10;
            }
            else
            {
                加料 = "";
                加料價格 -= 10;
            }
            單價加料 = 單價 + 加料價格;
            lbl單價.Text = 單價加料.ToString() + "元";
            品項總價 = 品項杯數 * 單價加料;
            lbl品項總價.Text = 品項總價.ToString() + "元";
        }

        private void checkBox椰果_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBox椰果.Checked)
            {
                加料 += "椰果";
                加料價格 += 10;
            }
            else
            {
                加料 = "";
                加料價格 -= 10;
            }            
            單價加料 = 單價 + 加料價格;
            lbl單價.Text = 單價加料.ToString() + "元";
            品項總價 = 品項杯數 * 單價加料;
            lbl品項總價.Text = 品項總價.ToString() + "元";
        }

        private void checkBox奶蓋_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBox奶蓋.Checked)
            {
                加料 += "奶蓋"; 
                加料價格 += 15;
            }
            else
            {
                加料 = "";
                加料價格 -= 15;
            }            
            單價加料 = 單價 + 加料價格;
            lbl單價.Text = 單價加料.ToString() + "元";
            品項總價 = 品項杯數 * 單價加料;
            lbl品項總價.Text = 品項總價.ToString() + "元";
        }

        private void checkBox多多布丁_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBox多多布丁.Checked)
            {
                加料 += "布丁";
                加料價格 += 20;
            }
            else
            {
                加料 = "";
                加料價格 -= 20;
            }            
            單價加料 = 單價 + 加料價格;
            lbl單價.Text = 單價加料.ToString() + "元";
            品項總價 = 品項杯數 * 單價加料;
            lbl品項總價.Text = 品項總價.ToString() + "元";
        }
    }
}
