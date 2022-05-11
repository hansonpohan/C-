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
        int int折扣活動代碼 = 0;
        int int總價 = 0;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chkTax.Checked = true;
            is計算稅金 = true;
            
            lbl訂購人資料.Text = GlobalVar.訂購人資訊;

            foreach (ArrayList 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {
                string 訂購品項 = (string)訂購品項資訊[0];
                int 單價 = (int)訂購品項資訊[1];
                int 品項杯數 = (int)訂購品項資訊[2];
                int 品項總價 = (int)訂購品項資訊[3];
                string 甜度 = (string)訂購品項資訊[4];
                string 冰塊 = (string)訂購品項資訊[5];
                string 加料 = (string)訂購品項資訊[6];
                int 加料價格 = (int)訂購品項資訊[7];

                string str單品資訊 = string.Format("{0} 單價:{1} {2}杯 總價:{3} {4} {5} {6} {7}", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

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
                lbox訂購品項列表.Items.RemoveAt(selIndex);
                GlobalVar.list訂購品項列表.RemoveAt(selIndex);
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lbox訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項列表.Clear();
            計算訂單總價();
        }

        void 計算訂單總價()
        {
            //作業規格:計算訂單總價;

        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked == true)
            {
                is計算稅金 = true;
                MessageBox.Show("計算稅金");
            } else
            {
                is計算稅金 = false;
                MessageBox.Show("不計算稅金");
            }
            計算訂單總價();
        }

        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            //加分題
            int折扣活動代碼 = 101;
            計算訂單總價();
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            //加分題
            int折扣活動代碼 = 102;
            計算訂單總價();
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            //加分題
            int折扣活動代碼 = 103;
            計算訂單總價();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form菜單.Show();
        }

        private void btn儲存訂單_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\iii\Documents\教學\dotNet元件開發";
            System.Random myRnd = new Random();
            int myNum = myRnd.Next(1000,9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt";

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            } else
            {
                return;
            }

            /////訂單內容存檔
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("*************** 冷飲店訂購單 *****************");
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("訂購時間:" + DateTime.Now.ToString() + " 訂購人:" + GlobalVar.訂購人資訊);
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("<<<< 訂購品項 >>>>");
            foreach (ArrayList 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {
                string 訂購品項 = (string)訂購品項資訊[0];
                int 單價 = (int)訂購品項資訊[1];
                int 品項杯數 = (int)訂購品項資訊[2];
                int 品項總價 = (int)訂購品項資訊[3];
                string 甜度 = (string)訂購品項資訊[4];
                string 冰塊 = (string)訂購品項資訊[5];
                string 加料 = (string)訂購品項資訊[6];
                int 加料價格 = (int)訂購品項資訊[7];

                string str單品資訊 = string.Format("{0} 單價:{1} {2}杯 總價:{3} {4} {5} {6} {7}", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

                list訂單資訊.Add(str單品資訊);
            }
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("折扣:" + "買二送一" + " 稅金:" + "35" + "元");
            list訂單資訊.Add("總價:" + int總價);
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("******************謝謝光臨********************");

            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }
    }
}
