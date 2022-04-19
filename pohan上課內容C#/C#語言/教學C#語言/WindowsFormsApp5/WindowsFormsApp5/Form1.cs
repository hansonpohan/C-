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
            //姓名-成績 , key-value , 索引值對應陳大貓對應68
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
            //回傳值要轉成字串
            lbl成績總和.Text = totalScore(arrayStudentScore).ToString();
            lbl成績平均.Text = average(arrayStudentScore).ToString();
        }

        int totalScore(int[] myArrayScore)
        {
            int total = 0;
            //設myScore在myArrayScore裡的值
            foreach (int myScore in myArrayScore)
            {//foreach將myArrayScore中的陣列值取出且相加
                total += myScore;
            }
            return total;//傳回至totalScore
        }

        double average(int[] myArrayScore)
        {
            double avg = 0.0;

            avg = Convert.ToDouble(totalScore(myArrayScore)) / myArrayScore.Length;

            return avg;//傳回至average
        }



        private void btn姓名排序_Click(object sender, EventArgs e)
        {// 把舊的陣列放進暫存陣列才不會影響舊的鎮列,從arrayStudentName複製到arrayTempStudentName且複製多長(arrayStudentName.Length)
            System.Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);

            姓名排序(arrayTempStudentName);
        }
        //方法中命名(string[] myArrayName)不要跟外面全域名稱一樣
        void 姓名排序(string[] myArrayName)
        {//單陣列排序
            System.Array.Sort(myArrayName);//筆畫排序            
            
            string strMsg = "";
            for (int idx = 0; idx < myArrayName.Length; idx += 1)
            {
                strMsg += string.Format("索引值:{0} 姓名:{1}\n",idx , myArrayName[idx]);
            }

            lbl資料結果.Text = strMsg;
        }

        private void btn成績排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

            成績排序(arrayTempStudentName, arrayTempStudentScore);
        }
        //成績沒有姓名是沒用的,=key沒有value是沒用的,姓名=key 成績=value
        void 成績排序(string[] myArrayName, int[] myArrayScore)
        {//跟姓名排序同名異式
            //第一個參數(value)排序,第二個參數(key)跟著第一個參數排序
            Array.Sort(myArrayScore, myArrayName); //key-value sort key-value排序

            //分數由大到小排序
            string strMsg = "";
            for (int idx = myArrayName.GetUpperBound(0); idx >=0; idx -= 1)
            {
                strMsg += string.Format("索引值:{0} 姓名:{1} 成績:{2}\n", idx ,myArrayName[idx], myArrayScore[idx]);
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
                int index, num = 0;// index搜尋到這個學生的索引值
                string strMsg = "搜尋結果\n-------------------------\n";
                string strSearchName = txt輸入姓名.Text;
                //拿上面已經排序過的值,已存在暫存陣列且已排序
                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

                成績排序(arrayTempStudentName, arrayTempStudentScore);
                //搜尋資料arrayTempStudentName所在的索引值(成績排序)並回傳用index接
                //index代表這個元素所在的索引值,strSearchName代表要搜尋比對的內容
                index = System.Array.IndexOf(arrayTempStudentName, strSearchName);

                if (index == -1)
                { //找不到
                    strMsg += "查無此人";
                } else
                { //找到了
                    // 總和減掉成績排序之索引值
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
