using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp練習
{
    public partial class Form1 : Form
    {
        string[] array便當name;
        int[] arrayprice;
        string[] arraytemp便當name;
        int[] arraytempprice;
        string[] array剩餘數量;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            array便當name = new string[5];
            array便當name[0] = "雞腿便當";
            array便當name[1] = "排骨便當";
            array便當name[2] = "魚排便當";
            array便當name[3] = "三寶便當";
            array便當name[4] = "豬排便當";

            arrayprice = new int[5];
            arrayprice[0] = 80;
            arrayprice[1] = 75;
            arrayprice[2] = 90;
            arrayprice[3] = 95;
            arrayprice[4] = 85;

            array剩餘數量 = new string[5];
            array剩餘數量[0] = "24個";
            array剩餘數量[1] = "13個";
            array剩餘數量[2] = "18個";
            array剩餘數量[3] = "19個";
            array剩餘數量[4] = "20個";

            arraytemp便當name = new string[5];
            arraytempprice = new int[5];

            string strmsg = "";
            for (int idx = 0; idx < array便當name.Length; idx ++)
            {
                strmsg += string.Format("{0} 價格:{1} 剩餘數量:{2}\n", array便當name[idx], arrayprice[idx], array剩餘數量[idx]);
            }
            lbl資料顯示結果.Text = strmsg;
        }

        private void btn便當排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(array便當name,arraytemp便當name,array便當name.Length);

            便當排序(arraytemp便當name);
        }

        void 便當排序(string[] myarray便當)
        {
            System.Array.Sort(myarray便當);
            string strmsg = "";
            for (int idx = 0; idx <= array便當name.GetUpperBound(0); idx+=1)
            {
                strmsg += string.Format("便當名稱:{0}\n",myarray便當[idx]);
            }
            lbl資料顯示結果.Text = strmsg;
        }

        private void btn價格排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(array便當name,arraytemp便當name,array便當name.Length);
            System.Array.Copy(arrayprice,arraytempprice,arrayprice.Length);
            價格排序(arraytemp便當name,arraytempprice );
        }

        void 價格排序(string[]myarray便當, int[]myarrayprice)
        {
            System.Array.Sort(myarrayprice);
            string strmsg = "";
            for (int idx = 0;idx <= myarrayprice.GetUpperBound(0) ;idx += 1)
            {
                strmsg += string.Format("索引值:{0} 便當名稱:{1} 價格:{2}\n", idx, myarray便當[idx] ,myarrayprice[idx]);
            }
            lbl資料顯示結果.Text = strmsg;
        }

        private void btn列出所有便當_Click(object sender, EventArgs e)
        {
            列出所有便當();
        }

        void 列出所有便當()
        {
            string strmsg = "";
            for (int idx = 0; idx < array便當name.Length; idx+=1)
            {
                strmsg += string.Format("索引值:{0} 便當名稱:{1} 價格:{2}\n", idx, array便當name[idx], arrayprice[idx]);
            }
            lbl資料顯示結果.Text = strmsg;
        }

        private void btn便當搜尋_Click(object sender, EventArgs e)
        {
            if (txt便當搜尋.Text.Length > 0)
            {
                int num, index = 0;
                string strmsg = "搜尋結果\n--------------------------\n";
                string strsearch便當 = txt便當搜尋.Text;

                System.Array.Copy(array便當name, arraytemp便當name, array便當name.Length);
                System.Array.Copy(arrayprice, arraytempprice, arrayprice.Length);
                價格排序(arraytemp便當name, arraytempprice);

                index = System.Array.IndexOf(arraytemp便當name, strsearch便當);

                if (index == -1)
                {
                    strmsg += "找不到此便當";
                }
                else
                {                    
                        strmsg += string.Format($"{arraytemp便當name[index]}{arraytempprice[index]}元\n" + "剩餘數量:" + array剩餘數量[index] );                    
                }
                lbl資料顯示結果.Text = strmsg;
            }
            else
            {
                MessageBox.Show("請輸入便當名稱");
            }
        }

    }
}
