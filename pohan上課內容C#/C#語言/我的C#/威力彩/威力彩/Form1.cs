using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 威力彩
{
    public partial class Form1 : Form
    {
        int[] randomarray;
        int[] randomspecialarray;
        string[] arraytemp;
        string[] randomarray1;
        string[] arrayspecialtemp;
        string[] randomarray2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             randomarray = new int[6];
             randomspecialarray = new int[1];
             randomarray1 = new string[6];
            
             arraytemp = new string[6];
            arrayspecialtemp = new string[1];
            randomarray2 = new string[1];
            
        }

        private void btn產生號碼_Click(object sender, EventArgs e)
        {
            產生號碼();
        }

        void 產生號碼()
        {            
            Random runnum = new Random();
            for (int i = 0;i <= 5; i++)
            {
                randomarray[i] = runnum.Next(1,38);
                for (int j = 0; j < i; j++)//j<i j是i的前一個陣列
                {
                    if (randomarray[i] == randomarray[j])
                    {
                        randomarray[i] = runnum.Next(1, 38);
                    }
                }

            }
            System.Array.Sort(randomarray);            
            lbl隨機號碼1.Text = randomarray[0].ToString();
            lbl隨機號碼2.Text = randomarray[1].ToString();
            lbl隨機號碼3.Text = randomarray[2].ToString();
            lbl隨機號碼4.Text = randomarray[3].ToString();
            lbl隨機號碼5.Text = randomarray[4].ToString();
            lbl隨機號碼6.Text = randomarray[5].ToString();            

            Random a = new Random();
            for (int i = 0; i < 1; i++)
            {
                randomspecialarray[i] = a.Next(1, 8);
            }
            lbl隨機特別號碼1.Text = randomspecialarray[0].ToString();
            
        }

        private void btn兌獎_Click(object sender, EventArgs e)
        {           
            兌獎();
        }

        void 兌獎()
        {
            string stra = "";
            
            arraytemp[0] = randomarray[0].ToString();
            arraytemp[1] = randomarray[1].ToString();
            arraytemp[2] = randomarray[2].ToString();
            arraytemp[3] = randomarray[3].ToString();
            arraytemp[4] = randomarray[4].ToString();
            arraytemp[5] = randomarray[5].ToString();

            arrayspecialtemp[0] = randomspecialarray[0].ToString();
            
            randomarray1[0] = txt自行號碼1.Text;
            randomarray1[1] = txt自行號碼2.Text;
            randomarray1[2] = txt自行號碼3.Text;
            randomarray1[3] = txt自行號碼4.Text;
            randomarray1[4] = txt自行號碼5.Text;
            randomarray1[5] = txt自行號碼6.Text;
            
            randomarray2[0] = txt自行特別號碼1.Text;

            if (txt自行號碼1.Text.Length > 0 || txt自行號碼2.Text.Length > 0 || txt自行號碼3.Text.Length > 0 || txt自行號碼4.Text.Length > 0 || txt自行號碼5.Text.Length > 0 || txt自行號碼6.Text.Length > 0)
            {
                var samearr = arraytemp.Intersect(randomarray1).ToArray();
                bool a = samearr.Length == 6;
                bool b = samearr.Length == 5;
                bool c = samearr.Length == 4;
                bool d = samearr.Length == 3;
                bool e = samearr.Length == 2;
                bool f = samearr.Length == 1;

                if (a == true && randomarray2[0] == arrayspecialtemp[0])
                {
                    stra += "中頭獎";
                }
                else if (a == true && randomarray2[0] != arrayspecialtemp[0])
                {
                    stra += "中貳獎";
                }
                else if (b == true && randomarray2[0] == arrayspecialtemp[0])
                {
                    stra += "中參獎";
                }
                else if (b == true && randomarray2[0] != arrayspecialtemp[0])
                {
                    stra += "中肆獎";
                }
                else if (c == true && randomarray2[0] == arrayspecialtemp[0])
                {
                    stra += "中伍獎";
                }
                else if (c == true && randomarray2[0] != arrayspecialtemp[0])
                {
                    stra += "中陸獎";
                }
                else if (d == true && randomarray2[0] == arrayspecialtemp[0])
                {
                    stra += "中柒獎";
                }
                else if (e == true && randomarray2[0] == arrayspecialtemp[0])
                {
                    stra += "中捌獎";
                }
                else if (d == true && randomarray2[0] != arrayspecialtemp[0])
                {
                    stra += "中玖獎";
                }
                else if (f == true && randomarray2[0] == arrayspecialtemp[0])
                {
                    stra += "中普獎";
                }
                else
                {
                    stra += "沒中獎";
                }
                lbl是否中獎.Text = stra;                
            }
            else
            {
                MessageBox.Show("請輸入號碼");
            }
            
        }
    }
}
