using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array 陣列
            int[] arrayOne = new int[6];//物件初始化要用new,物件arrry存的是記憶體(memory address)的位置,一般的資料型態存在宣告的int裡
            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;
            arrayOne[3] = 4;
            arrayOne[4] = 5;
            arrayOne[5] = 6;

            
            Console.WriteLine("arrayOne取出索引值為3的元素內容:{0}", arrayOne[3]);
            arrayOne[4] = 88;
            Console.WriteLine("arrayOne取出索引值為3的元素內容:{0}", arrayOne[4]);
            
            int[] array2 = new int[] { 6, 5, 4, 3, 2, 1 };
            int[] array3 = { 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("array3取出索引值為6的元素內容:{0}", array3[5]);
            Console.WriteLine("----------------------");

            for (int i = 0; i <= 5; i += 1)
            {
                Console.WriteLine("arrayOne[{0}] = {1}", i, arrayOne[i]);
            }

            string[] array科目名稱 = { "國文", "數學", "英文", "自然", "社會" };
            Console.WriteLine("array科目名稱[{0}] = {1}", 1, array科目名稱[1]);
            Console.WriteLine("----------------------");

            for (int i =0; i < array科目名稱.Length; i += 1)
            {
                Console.WriteLine("array 科目名稱[{0}] = {1}", i, array科目名稱[i]);
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i <=array科目名稱.GetUpperBound(0); i += 1)
            {
                Console.WriteLine("array 科目名稱[{0}] = {1}", i, array科目名稱[i]);
            }
            Console.WriteLine("----------------------");

            foreach (string subject in array科目名稱)
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine("----------------------");

            //2維陣列, Two Dimesion Array, Dim
            int[,] array2D_One = new int[4, 2];//四樓兩個房間
            array2D_One[0, 0] = 8;
            array2D_One[0, 1] = 7;
            array2D_One[1, 0] = 6;
            array2D_One[1, 1] = 5;
            array2D_One[2, 0] = 4;
            array2D_One[2, 1] = 3;
            array2D_One[3, 0] = 2;
            array2D_One[3, 1] = 1;
            int[,] array2D_Two = { { 8, 7 }, { 6, 5 }, { 4, 3 }, { 2, 1 } };

            for (int i = 0; i < 4; i++)
            {
               for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("array2D_One[{0},{1}]={2}",i, j, array2D_One[i,j]);
                }
                
            }
            Console.WriteLine("----------------------");

            for (int i = 0; i <= array2D_One.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=array2D_One.GetUpperBound(1); j++)
                {
                    Console.WriteLine("array2D_One[{0},{1}]={2}", i, j, array2D_One[i, j]);
                }

            }
            Console.WriteLine("----------------------");
            //3維陣列
            int[,,] array3D_One = new int[2, 3, 4]//兩棟三個樓層四個房間
            {
                {
                    {1,2,3,4 },
                    {5,6,7,8 },
                    {9,10,11,12 }
                },
                {
                    {13,14,15,16 },
                    {17,18,19,20 },
                    {21,22,23,24 }
                }
            };
            for (int i = 0; i <= array3D_One.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array3D_One.GetUpperBound(1); j++)
                {                    
                    for (int k = 0;k<= array3D_One.GetUpperBound(2);k++)
                    {
                       Console.WriteLine("array3D_One[{0},{1},{2}]={3}", i, j,k, array3D_One[i, j,k]);
                    }
                }
            }
            Console.WriteLine("----------------------");

            //[1,0,2]
            Console.WriteLine("array3D_One[1,0,2] = {0}",array3D_One[1,0,2]);
            //[0,1,2]
            Console.WriteLine("array3D_One[0,1,2] = {0}", array3D_One[0, 1, 2]);
            //[1,2,2]
            Console.WriteLine("array3D_One[1,2,2] = {0}", array3D_One[1, 2, 2]);
            Console.WriteLine("----------------------");

            Console.WriteLine("請輸入搜尋科目名稱(輸入完成按Enter:");
            string str搜尋科目 = Console.ReadLine();
            bool is有這科目 = false;

            for (int k = 0; k <= array科目名稱.GetUpperBound(0); k++) 
            {
                if (array科目名稱[k] == str搜尋科目)
                {
                    Console.WriteLine("有此科目:" + array科目名稱[k] + ",index:" + k);
                    is有這科目 = true;
                    break;
                }//else
                //{
                    //Console.WriteLine("找不到這科目");
                //}會出現多次"找不到這科目"
            }

            if (is有這科目 == false)
            {
                Console.WriteLine("找不到這科目");
            }

            //改while迴圈
            /*int a = 0;
            while (a < array科目名稱.Length)
            {
                a++;
                if (array科目名稱[a] == str搜尋科目)  有錯誤
                {
                    Console.WriteLine("有此科目:" + array科目名稱[a] + ",index:" + a);
                    is有這科目 = true;
                    break;
                }
                else
                {
                    is有這科目 = false;
                    Console.WriteLine("找不到這科目");
                }
            }
            if (is有這科目 == false)
            {
                Console.WriteLine("找不到這科目");
            }*/

            //便當

            string[,] array2D_便當名稱 = new string[20, 2]
            {
                {"雞腿便當","80元" },{"雞排便當","80元" },{"豬腳便當","70元" },{"豬排便當","80元" },{"牛排便當","100元" },{"羊排便當","90元" },{"叉燒便當","80元" },{"鴨肉便當","70元" },{"三寶便當","90元" },{"鰻魚便當","110元" },{"鱈魚便當","110元" },{"鮭魚便當","110元" },{"鯖魚便當","110元" },{"排骨便當","70元" },{"魚排便當","80元" },{"沙茶羊便當","80元" },{"三杯雞便當","90元" },{"宮保雞便當","90元" },{"蔥爆豬便當","90元" },{"蔥爆牛便當","100元" }
            };

            /*array2D_便當名稱[0, 0] = "雞腿便當";    array2D_便當名稱[0, 1] ="80元";
            array2D_便當名稱[1, 0] = "雞排便當";    array2D_便當名稱[1, 1] ="80元";
            array2D_便當名稱[2, 0] = "豬腳便當";    array2D_便當名稱[2, 1] = "70元";
            array2D_便當名稱[3, 0] = "豬排便當";    array2D_便當名稱[3, 1] = "80元";
            array2D_便當名稱[4, 0] = "牛排便當";    array2D_便當名稱[4, 1] = "100元";
            array2D_便當名稱[5, 0] = "羊排便當";    array2D_便當名稱[5, 1] = "90元";
            array2D_便當名稱[6, 0] = "叉燒便當";    array2D_便當名稱[6, 1] = "80元";
            array2D_便當名稱[7, 0] = "鴨肉便當";    array2D_便當名稱[7, 1] = "70元";
            array2D_便當名稱[8, 0] = "三寶便當";    array2D_便當名稱[8, 1] = "90元";
            array2D_便當名稱[9, 0] = "鰻魚便當";    array2D_便當名稱[9, 1] = "110元";
            array2D_便當名稱[10, 0] = "鱈魚便當";   array2D_便當名稱[10, 1] = "110元";
            array2D_便當名稱[11, 0] = "鮭魚便當";   array2D_便當名稱[11, 1] = "110元";
            array2D_便當名稱[12, 0] = "鯖魚便當";   array2D_便當名稱[12, 1] = "110元";
            array2D_便當名稱[13, 0] = "排骨便當";   array2D_便當名稱[13, 1] = "70元";
            array2D_便當名稱[14, 0] = "魚排便當";   array2D_便當名稱[14, 1] = "80元";
            array2D_便當名稱[15, 0] = "沙茶羊便當"; array2D_便當名稱[15, 1] = "80元";
            array2D_便當名稱[16, 0] = "三杯雞便當"; array2D_便當名稱[16, 1] = "90元";
            array2D_便當名稱[17, 0] = "宮保雞便當"; array2D_便當名稱[17, 1] = "90元";
            array2D_便當名稱[18, 0] = "蔥爆豬便當"; array2D_便當名稱[18, 1] = "90元";
            array2D_便當名稱[19, 0] = "蔥爆牛便當"; array2D_便當名稱[19, 1] = "100元";*/

            while (true)//可以一直搜尋
            {
                Console.Clear();
                Console.WriteLine("============================");
                Console.WriteLine("=====    超好吃便當    ======");
                Console.WriteLine("============================");

                Console.WriteLine("請輸入搜尋便當名稱(輸入完成按Enter):");
                string str搜尋便當 = Console.ReadLine();
                bool is有這便當 = false;

                for (int k = 0; k <= array2D_便當名稱.GetUpperBound(0); k++)
                {
                    for (int l = 0; l <= array2D_便當名稱.GetUpperBound(1); l++)
                    {
                        if (array2D_便當名稱[k, l] == str搜尋便當)
                        {
                            Console.WriteLine("有此便當:" + "{0}", array2D_便當名稱[k, l] + "、價格:" + array2D_便當名稱[k, l + 1]);
                            is有這便當 = true;
                            break;
                        }
                    }
                }
                if (is有這便當 == false)
                {
                    Console.WriteLine("找不到這便當");
                }
                if (str搜尋便當 == "exit")
                {
                    break;
                }
                Console.ReadKey();
            }
            

            Console.WriteLine("----------------------");
            Console.ReadKey();

        }
    }
}
