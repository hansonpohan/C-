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
    public partial class Form2 : Form
    {
        bool is計算稅金 = false;
        double 稅金 = 0;
        double 折扣 = 0;
        int int折扣活動代碼 = 0;
        double total = 0;
        double totaltax = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chkTax.Checked = true;
            is計算稅金 = true;
            lbl訂購人資料.Text = GlobalVar.訂購人資訊;
            for (int i = 0; i < GlobalVar.訂單資訊集合.Count; i += 1) 
            {
                訂單資訊 訂單1 = GlobalVar.訂單資訊集合[i];
                string str單品資訊 = string.Format("{0} 加料:{1} 飲料單價:{2}元 加料價格:{3}元 {4}杯 共{5}元 甜度:{6} 冰塊:{7} ", 訂單1.品名, 訂單1.加料, 訂單1.單價, 訂單1.加料價格, 訂單1.品項杯數, 訂單1.品項總價, 訂單1.甜度, 訂單1.冰塊);
                lbox訂購品項列表.Items.Add(str單品資訊);
            }
            計算訂單總價();
        }

        private void lbox訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            
            if (lbox訂購品項列表.SelectedIndex >= 0)
            {
                int selIndex = lbox訂購品項列表.SelectedIndex;
                lbox訂購品項列表.Items.RemoveAt(lbox訂購品項列表.SelectedIndex);
                GlobalVar.訂單資訊集合.RemoveAt(selIndex);
            }
            else
            {
                MessageBox.Show("請選擇移除品項", "錯誤");
            }
            計算訂單總價();
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            
            lbox訂購品項列表.Items.Clear();
            GlobalVar.訂單資訊集合.Clear();
            計算訂單總價();
        }
        
        void 計算訂單總價()
        {
            //作業規格:計算訂單總價
            total = 0;
            int 總杯數 = 0;
            折扣 = 0;
            List<int> 單價列表 = new List<int>();


            foreach (訂單資訊 訂單 in GlobalVar.訂單資訊集合)
            {
                total += 訂單.品項總價;
            }

            for (int i = 0; i < GlobalVar.訂單資訊集合.Count; i += 1)
            {
                訂單資訊 訂單1 = GlobalVar.訂單資訊集合[i];
                總杯數 += 訂單1.品項杯數;
                單價列表.AddRange(訂單1.所有單價());
            }
            單價列表.Sort();

            lbl訂單總價.Text = "訂購單總價" + Convert.ToString(total) + "元";
            
            if(is計算稅金 == true)
            {
                totaltax = Math.Ceiling(total * 1.05);
                稅金 = totaltax - total;
                lbl訂單總價.Text = "訂購單總價" + Convert.ToString(totaltax) + "元";
                if (int折扣活動代碼 == 101)
                {
                    int 折扣杯數 = 總杯數 / 3;
                    for (int i = 0; i < 折扣杯數; i += 1)
                    {
                        totaltax -= 單價列表[i];
                        折扣 += 單價列表[i];
                        lbl訂單總價.Text = "訂購單總價" + Convert.ToString(totaltax) + "元";
                    }
                }
                if (int折扣活動代碼 == 102)
                {
                    int 折扣杯數 = 總杯數 / 4;
                    for (int i = 0; i < 折扣杯數; i += 1)
                    {
                        totaltax -= 單價列表[i];
                        折扣 += 單價列表[i];
                        lbl訂單總價.Text = "訂購單總價" + Convert.ToString(totaltax) + "元";
                    }
                }
                if(int折扣活動代碼 == 103)
                {
                    int 折扣杯數 = 總杯數 / 2;
                    for (int i = 0; i < 折扣杯數; i += 1)
                    {
                        折扣 += 單價列表[i] / 2;
                    }
                    totaltax -= 折扣;
                    lbl訂單總價.Text = "訂購單總價" + Convert.ToString(totaltax) + "元";
                }
            }
            else
            {
                lbl訂單總價.Text = "訂購單總價" + Convert.ToString(total) + "元";
                稅金 = 0;
                if (int折扣活動代碼 == 101)
                {
                    int 折扣杯數 = 總杯數 / 3;
                    for (int i = 0; i < 折扣杯數; i += 1)
                    {
                        total -= 單價列表[i];
                        折扣 += 單價列表[i];
                        lbl訂單總價.Text = "訂購單總價" + Convert.ToString(total) + "元";
                    }
                }
                if (int折扣活動代碼 == 102)
                {
                    int 折扣杯數 = 總杯數 / 4;
                    for (int i = 0; i < 折扣杯數; i += 1)
                    {
                        total -= 單價列表[i];
                        折扣 += 單價列表[i];
                        lbl訂單總價.Text = "訂購單總價" + Convert.ToString(total) + "元";
                    }
                }
                if(int折扣活動代碼 == 103)
                {
                    int 折扣杯數 = 總杯數 / 2;
                    for (int i = 0; i < 折扣杯數; i += 1)
                    {
                        折扣 += 單價列表[i] / 2;
                    }
                    total -= 折扣;
                    lbl訂單總價.Text = "訂購單總價" + Convert.ToString(total) + "元";
                }
            }


        }
        
        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked == true)
            {
                is計算稅金 = true;
                計算訂單總價();
            }
            else
            {
                is計算稅金 = false;
                計算訂單總價();
            }
        }

        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            int折扣活動代碼 = 101;
            計算訂單總價();
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            int折扣活動代碼 = 102;
            計算訂單總價();
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            int折扣活動代碼 = 103;
            計算訂單總價();
        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單.Show();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form菜單.Show();
        }

        private void btn儲存訂單_Click(object sender, EventArgs e)
        {
            
            string str檔案路徑 = @"C:\Users\iii\repo3\Ren\.Net";
            System.Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt"; //副檔名過濾器

            DialogResult R = sfd.ShowDialog(); //ShowDialog獨佔模式

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            }
            else
            {
                return;
            }

            //訂單內容存檔
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("**************  冷飲店訂購單  **************");
            list訂單資訊.Add("-------------------------------------------");
            list訂單資訊.Add("訂購時間:" + DateTime.Now.ToString() + "訂購人:" + GlobalVar.訂購人資訊);
            list訂單資訊.Add("-------------------------------------------");
            list訂單資訊.Add("<<<<  訂購品項  >>>>");


            for (int i = 0; i < GlobalVar.訂單資訊集合.Count; i += 1)
            {
                訂單資訊 訂單1 = GlobalVar.訂單資訊集合[i];
                string str單品資訊 = string.Format("{0} 加料:{1} 飲料單價:{2}元 加料價格:{3}元 {4}杯 共{5}元 甜度:{6} 冰塊:{7} ", 訂單1.品名, 訂單1.加料, 訂單1.單價, 訂單1.加料價格, 訂單1.品項杯數, 訂單1.品項總價, 訂單1.甜度, 訂單1.冰塊);
                list訂單資訊.Add(str單品資訊);
            }

            list訂單資訊.Add("-------------------------------------------");

            list訂單資訊.Add("折扣:" + 折扣 + "元" + " 稅金:" + 稅金 + "元");
            if(is計算稅金 == true)
            {
                list訂單資訊.Add("總價:" + totaltax + "元");
            }
            else
            {
                list訂單資訊.Add("總價:" + total + "元");
            }
            list訂單資訊.Add("-------------------------------------------");
            list訂單資訊.Add("**************  謝謝光臨  **************");
            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
            
        }
    }
}
