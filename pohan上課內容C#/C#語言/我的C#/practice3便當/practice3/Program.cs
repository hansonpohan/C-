using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 便當選單, 輸入便當名稱, 告訴使用者有沒有販售, 此便當多少錢
            // 建立2維陣列string陣列, 儲存便當名稱跟價格, 做搜尋
            // 至少有十種便當, string[20(種便當),2(便當價格.名稱)]
            string[,] array2D_便當 = new string[20,2];//[20(種便當),2(便當價格.名稱)]

            

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
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
