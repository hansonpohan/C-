using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("第一個Windows Form程式");
            Console.WriteLine("小數位數 pi: {0:F4}", 3.141592);//F預設值小數點後兩位,自動四捨五入
            Console.WriteLine("百分比號: {0:P}", 0.8765);//87.65%
            Console.WriteLine("科學記號: {0:E}", 0.00000000000012345);//科學記號
            Console.WriteLine("科學記號: {0:E}", 1234500000000000000.0);//科學記號
            Console.WriteLine("金融符號: {0:C}", 100000000);//金融符號NT
            Console.WriteLine("整數補零: {0:D8}", 12345);//D8整數補零到八位

            Console.WriteLine("現在時間: {0}", System.DateTime.Now);//DateTime取得時間類別
            Console.WriteLine("{0:d}", DateTime.Now);//DateTime.Now取得電腦主機現在時間
            Console.WriteLine("{0:D}", DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);
            Console.WriteLine("{0:T}", DateTime.Now);//多秒數
            Console.WriteLine("{0:t}", DateTime.Now);
            Console.WriteLine("{0:M}", DateTime.Now);
            Console.WriteLine("{0:y}", DateTime.Now);
            Console.WriteLine("{0:Y}", DateTime.Now);

            System.Windows.Forms.MessageBox.Show("歡迎使用本程式");//彈跳窗
            MessageBox.Show("Windows Form App 開發","標題",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            lbl標題.Text = "Super好喝冷飲自動販賣機";
            lbl回應訊息.Text = "請選擇您要購買的飲料";
        }




        private void btn紅茶_Click(object sender, EventArgs e)
        {//Test只支援字串
            lbl回應訊息.Text = "您選擇了紅茶, 請投入 20 元";
        }

        private void btn綠茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選擇了綠茶, 請投入 25 元";
        }

        private void btn奶茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選擇了奶茶, 請投入 40 元";
        }

        private void btn可樂_Click(object sender, EventArgs e)
        {//修改按屬性中的閃電符號
            lbl回應訊息.Text = "您選擇了可樂, 請投入 15 元";
        }

    }
}
