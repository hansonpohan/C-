using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 便當選單:輸入便當名稱，告訴使用者有沒有販售、此便當多少錢
            // 建立2維string陣列，儲存便當名稱跟價格，做搜尋
            // 至少有十種便當   例:[20,2] -> 20種便當，1個名稱、1個價格

            String[,] array2D_餐點 = { { "排骨飯", "80元" }, { "咖哩飯", "70元" }, { "雞腿飯", "95元" }, { "肉燥飯", "35元" }, { "三寶飯", "100元" }, { "雞排飯", "95元" }, { "爌肉飯", "80元" }, { "豬排飯", "85元" }, { "鮮魚飯", "90元" }, { "招牌飯", "70元" } };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine("========好吃便當店========");
                Console.WriteLine("==========================");
                Console.WriteLine("請輸入餐點名稱");
                Console.WriteLine("輸入完成請按Enter");
                Console.WriteLine("若要結束請輸入Exit");
                string str搜尋餐點 = Console.ReadLine();
                bool is有這種餐點 = false;

                for (int i = 0; i <= array2D_餐點.GetUpperBound(0); i += 1)
                {
                    for (int j = 0; j <= array2D_餐點.GetUpperBound(1); j += 1)
                    {
                        if (array2D_餐點[i, j] == str搜尋餐點)
                        {
                            Console.WriteLine("有此種餐點" + array2D_餐點[i, j] + "、價格:" + array2D_餐點[i, j + 1]);
                            is有這種餐點 = true;
                            break;
                        }
                    }
                }
                if (is有這種餐點 == false)
                {
                    Console.WriteLine("很抱歉，並無販售此種餐點");
                }
                if (str搜尋餐點 == "Exit")
                {
                    break;
                }
                
                Console.WriteLine("==========================");
                Console.WriteLine("按任意鍵繼續");
                Console.ReadKey();
            }






        }
    }
}
