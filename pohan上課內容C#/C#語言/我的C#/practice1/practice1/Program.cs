using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Hello World!!"); Console.WriteLine("Hello C#");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello C#");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("藍綠色代表空間space");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("黃色代表函式function");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("位元bits");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("位元組byte");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("C#語言");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t縮排");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n換行");
            //簡介
            Console.WriteLine("\tHello everyone");
            Console.WriteLine("My name is \'pohan\'");
            Console.WriteLine("My hometown is \"kaohsiung\"");
            Console.WriteLine("There are many beatiful attrations");
            Console.WriteLine("My interesting is playing basketball");
            Console.WriteLine("And my star sign is cancer");
            Console.WriteLine("I come for here to learn some skill\nbefore i find a job");
            Console.WriteLine("So i hope i can end of training smoothly"); 
            Console.WriteLine("And have a chance to enter nice company.");
            Console.WriteLine("^^");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("李白《望廬山瀑布》");
            Console.WriteLine("日照香爐生紫煙，");
            Console.WriteLine("遙看瀑布掛前川。");
            Console.WriteLine("飛流直下三千尺，");
            Console.WriteLine("疑是銀河落九天。");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            int a = 10;
            float b = 20;
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            bool c=true;
            Console.WriteLine(c);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            int x = 10;
            do
            {
                Console.WriteLine(x);
                x--;
            } while (x > 0);
                        
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("C#");

            string aa = "Hello";
            string bb = "C#";
            Console.Write((aa+bb).Length);*/

            Console.WriteLine("--------------------------------------");

            /*string[,] array2D_飲料名稱 = new string[5, 2]
            {
                {"鐵觀音鮮奶茶","65元"},{"紅豆鮮奶茶","70元"},{"翡翠檸檬","65元"},{"鮮檸冬瓜","60元"},{"冬瓜鮮奶茶","60元"}
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("------茶湯會排行榜------");
                Console.WriteLine("=======================");
                Console.WriteLine("請輸入飲料名稱(輸入完請按Enter):");
                string str飲料名稱 = Console.ReadLine();
                bool is有這飲料 = false;//bool定義

                for (int x = 0; x <= array2D_飲料名稱.GetUpperBound(0); x++)
                {                    
                    for (int y = 0; y <= array2D_飲料名稱.GetUpperBound(1); y++)
                    {
                        if (str飲料名稱 == array2D_飲料名稱[x, y])
                        {
                            Console.WriteLine("有這飲料:" + "{0}", array2D_飲料名稱[x, y]+"、價格:" + array2D_飲料名稱[x, y + 1]);
                            is有這飲料 = true;
                            break;
                        }

                    }
                }
                if (is有這飲料 == false)
                {
                    Console.WriteLine("沒有這飲料");
                }
                if (str飲料名稱 == "exit")
                {
                    break;
                }
                Console.ReadKey();
            }*/


            Console.WriteLine("-------------------------------------");

            //輸入層數印出輸入層數之三角形

            Console.WriteLine("請輸入層數");
            string aa = Console.ReadLine();
            int z = Convert.ToInt32(aa);
            
            for (int i = 1; i <= z ; i++)
            {
                for (int a = 1; a <= z - i; a++)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b <= 2 * i - 1; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------");


















            Console.WriteLine("結束按Enter");
            Console.ReadLine();

        }
    }
}
