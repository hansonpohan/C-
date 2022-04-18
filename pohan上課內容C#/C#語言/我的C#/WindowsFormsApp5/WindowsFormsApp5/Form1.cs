using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        //類別變數, 本類別可視
        string[] arrayStudentName; //學生姓名陣列
        int[] arrayStudentScore; //學生成績陣列
        string[] arrayTempStudentName; //學生姓名暫存陣列
        int[] arrayTempStudentScore; //學生成績暫存陣列

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //姓名-成績 , key-value , 鍵值對應
            arrayStudentName = new string[5];
            arrayStudentName[0] = "王小明";
            arrayStudentName[1] = "陳大貓";
            arrayStudentName[2] = "林阿霈";
            arrayStudentName[3] = "張大書";
            arrayStudentName[4] = "黃忠孝";

            arrayStudentScore = new int[5];
            arrayStudentScore[0] = 76;
            arrayStudentScore[1] = 68;
            arrayStudentScore[2] = 54;
            arrayStudentScore[3] = 92;
            arrayStudentScore[4] = 86;

            arrayTempStudentName = new string[5];
            arrayTempStudentScore = new int[5];

            lbl成績總和.Text = totalScore(arrayStudentScore).ToString();
            lbl成績平均.Text = average(arrayStudentScore).ToString();
        }

        int totalScore(int[] myArrayScore)
        {
            int total = 0;
            foreach(int myScore in myArrayScore)
            {
                total += myScore;
            }
            return total;
        }

        double average(int[] myArrayScore)
        {
            double avg = 0.0;

            avg = Convert.ToDouble(totalScore(myArrayScore)) / myArrayScore.Length;

            return avg;
        }



        private void btn姓名排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);

            姓名排序(arrayTempStudentName);
        }

        void 姓名排序(string[] myArrayName)
        {
            System.Array.Sort(myArrayName);
            //
            //
            string strMsg = "";
            for (int idx = 0; idx < myArrayName.Length; idx += 1)
            {
                strMsg += string.Format("姓名:{0}\n", myArrayName[idx]);
            }

            lbl資料結果.Text = strMsg;
        }

        private void btn成績排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

            成績排序(arrayTempStudentName, arrayTempStudentScore);
        }

        void 成績排序(string[] myArrayName, int[] myArrayScore)
        {
            Array.Sort(myArrayScore, myArrayName); //key-value sort
            //
            //
            string strMsg = "";
            for (int idx = myArrayName.GetUpperBound(0); idx >=0; idx -= 1)
            {
                strMsg += string.Format("姓名:{0} 成績:{1}\n", myArrayName[idx], myArrayScore[idx]);
            }

            lbl資料結果.Text = strMsg;
        }

        private void btn列出所有學生_Click(object sender, EventArgs e)
        {
            列出所有人員();
        }

        void 列出所有人員()
        {
            string strMsg = "";
            for (int idx = 0; idx < arrayStudentName.Length; idx += 1)
            {
                strMsg += string.Format("索引值:{0} 姓名:{1} 成績:{2}\n", idx, arrayStudentName[idx], arrayStudentScore[idx]);
            }

            lbl資料結果.Text = strMsg;
        }

        private void btn姓名搜尋_Click(object sender, EventArgs e)
        {
            if (txt輸入姓名.Text.Length > 0)
            {
                int index, num = 0;
                string strMsg = "搜尋結果\n-------------------------\n";
                string strSearchName = txt輸入姓名.Text;

                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

                成績排序(arrayTempStudentName, arrayTempStudentScore);

                index = System.Array.IndexOf(arrayTempStudentName, strSearchName);

                if (index == -1)
                { //找不到
                    strMsg += "查無此人";
                } else
                { //找到了
                    num = arrayTempStudentName.Length - index; //求名次
                    strMsg += string.Format($"{arrayTempStudentName[index]} {arrayTempStudentScore[index]}分 \n第{num} 名");
                }

                lbl資料結果.Text = strMsg;
            } else
            {
                MessageBox.Show("請輸入姓名");
            }
        }



    }
}
