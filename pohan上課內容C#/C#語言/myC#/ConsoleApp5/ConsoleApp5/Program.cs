using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop 迴圈式範
            for (int i = 1;i <= 20; i+=1 )//20到1
            {
                Console.WriteLine("i: " + i);
            }
            Console.WriteLine("------------------------");
            for (int i = 2; i <= 100; i += 2)//偶數2到100
            {
                Console.WriteLine("i: " + i);
            }
            Console.WriteLine("------------------------");
            //輸出 10...1
            for (int i = 10; i >= 1; i -= 1)
            {
                Console.WriteLine("i: " + i);
            }
            Console.WriteLine("------------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                if (i > 9)
                {
                    break; //中斷迴圈
                }
                Console.WriteLine("i: " + i);
            }
            Console.WriteLine("------------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                if (i == 8)
                {
                    continue; //跳過此次迴圈;
                }
                Console.WriteLine("i: " + i);
            }
            Console.WriteLine("------------------------");

            //內層迴圈產生行(coulmn)外層迴圈串產生(row)
            for (int i = 1; i <= 5; i += 1)
            {
               for (int j = 1; j <= 10; j += 1)
               {
                    Console.Write("*");
               }
               Console.WriteLine();     
            }
            Console.WriteLine("------------------------");

            //內層迴圈先跑完再跑外層的迴圈
            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");

            for (int i = 1;i <= 9;i += 1)
            {
                for (int j = 1;j <= 9;j += 1) 
                {
                    Console.Write(i+"x"+j+"="+i*j+"  ");
                    //Console.Write("{0} x {1} = {2},", i, j,i*j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");


            //練習:輸出 等腰三角形, 菱形
            //課程作業加分題: 請輸出 聖誕樹 彩色 有裝飾(思考,可以任意輸入聖誕樹的高度 例如:值10到500之間)
            //等腰三角形
            for (int i = 1; i <= 10; i+=1)
                {
                    Console.Write("*");
                for (int k = 9; k >= i ; k--)
                {
                    Console.Write(" ");
                }                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int m = 2; i >= m ; m++)
                {
                    Console.Write("*");
                }
                for (int l = 2 ; i >= l ; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");

            for (int i = 1;i <= 5;i++)//第i列
            {
                for (int a = 1;a <= 5-i;a++)//第i列要a個空白
                {
                    Console.Write(" ");
                }
                for (int b = 1;b < 2*i;b++)//第i列要b個星號
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
            //菱形

            for (int i = 1; i <= 5; i++)
            {
                for (int a = 1; a <= 5 - i; a++)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b < 2 * i; b++)//[b<2*i]=[b<=2*i-1]
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int j = 1; j <= 4; j++)
            {
                for (int c = 1; c <= j; c++)
                {
                    Console.Write(" ");
                }
                for (int d = 1; d <= 9-2 * j; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 

            //聖誕樹






            Console.WriteLine();
            Console.WriteLine("------------------------");

            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
