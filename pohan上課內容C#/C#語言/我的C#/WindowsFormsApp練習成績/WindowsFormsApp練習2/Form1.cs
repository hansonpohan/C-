using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp練習2
{
    public partial class Form1 : Form
    {
        string[] arraystudentname;
        int[] arraystudentscore;
        string[] arraytempstudentname;
        int[] arraytempstudentscore;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arraystudentname = new string[5];

            arraystudentname[0] = "王小明";
            arraystudentname[1] = "陳大貓";
            arraystudentname[2] = "林阿霈";
            arraystudentname[3] = "張大書";
            arraystudentname[4] = "黃忠孝";

            arraystudentscore = new int[5];

            arraystudentscore[0] = 76;
            arraystudentscore[1] = 68;
            arraystudentscore[2] = 54;
            arraystudentscore[3] = 92;
            arraystudentscore[4] = 86;

            arraytempstudentname = new string[5];
            arraytempstudentscore = new int[5];

            lbl成績總和.Text = totalscore(arraystudentscore).ToString();
            lbl成績平均.Text = avg(arraystudentscore).ToString();

        }
        int totalscore(int [] myscore)
        {
            int total = 0;
            foreach (int myScore in myscore)
            {
                total += myScore;
            }
            return total;
        }

        double avg(int [] myscore)
        {
            double avg = 0;
                avg = Convert.ToDouble(totalscore(myscore)) / myscore.Length;
            return avg;
        }

        private void btn姓名排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arraystudentname, arraytempstudentname, arraystudentname.Length);
            姓名排序();
        }

        void 姓名排序()
        {
            System.Array.Sort(arraytempstudentname);
            string stra = "";
            for (int a = 0;a < arraystudentname.Length;a++)
            {
                stra += string.Format("姓名:{0}\n",arraytempstudentname[a]);
            }
            lbl資料顯示結果.Text = stra;
        }
        private void btn成績排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arraystudentname, arraytempstudentname, arraystudentname.Length);
            System.Array.Copy(arraystudentscore,arraytempstudentscore,arraystudentscore.Length);
            成績排序(arraytempstudentname,arraytempstudentscore);
        }

        void 成績排序(string[]myname,int[]myscore)
        {
            System.Array.Sort(myscore,myname);
            string stra = "";
            for (int a = arraystudentscore.GetUpperBound(0); a >= 0 ;a--)//不能用.length是5超過陣列
            {
                stra += string.Format("姓名:{0} 成績:{1}\n", myname[a], myscore[a]);
            }
            lbl資料顯示結果.Text = stra;
        }

        private void btn列出所有學生_Click(object sender, EventArgs e)
        {
            列出所有學生();
        }

        void 列出所有學生()
        {
            string stra = "";
            for (int a = 0; a < arraystudentname.Length; a++)
            {                
                stra += string.Format("索引值:{0} 姓名:{1} 成績:{2}\n",a,arraystudentname[a],arraystudentscore[a]);
            }
            lbl資料顯示結果.Text = stra;
        }

        private void btn姓名搜尋_Click(object sender, EventArgs e)
        {
            if (tet姓名搜尋.Text.Length > 0)
            {
                int num, index = 0;
                string stra = "搜尋結果\n-------------------------\n";
                string strsearchname = tet姓名搜尋.Text;

                System.Array.Copy(arraystudentname, arraytempstudentname, arraystudentname.Length);
                System.Array.Copy(arraystudentscore, arraytempstudentscore, arraystudentscore.Length);
                成績排序(arraytempstudentname, arraytempstudentscore);

                index = System.Array.IndexOf(arraytempstudentname,strsearchname);
                
                if (index == -1)
                {
                    stra += "找不到此人";
                }
                else
                {
                    num = arraystudentname.Length - index;
                    stra += string.Format("姓名:{0} 成績:{1} 名次:第{2}名",arraytempstudentname[index],arraytempstudentscore[index], num);
                }
                lbl資料顯示結果.Text = stra;
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }
    }
}
