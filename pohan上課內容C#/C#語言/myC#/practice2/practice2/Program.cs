using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用條件判段式, 隨意輸入三個數字比大小
            int a = 100;
            int b = 10;
            int c = 1;

            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            if (a > c)
            {
                Console.WriteLine("a>c");
            }
            if (b > a)
            {
                Console.WriteLine("b>a");
            }
            if (b > c)
            {
                Console.WriteLine("b>c");
            }
            if (c > a)
            {
                Console.WriteLine("c>a");
            }
            if (c > b)
            {
                Console.WriteLine("c>b");
            }
            Console.WriteLine("--------------------------");

            if (a > b && b > c)
            {
                Console.WriteLine("a>b>c");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("a>c>b");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("b>a>c");
            }
            else if (b > c && c > a)
            {
                Console.WriteLine("b>c>a");
            }
            else if (c > b && b > a)
            {
                Console.WriteLine("c>b>a");
            }
            else
            {
                Console.WriteLine("c>a>b");
            }
            Console.WriteLine("--------------------------");


            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("a>b>c");
                }
                else
                {
                    Console.WriteLine("a>c>b");
                }
            }
            else if (b > c && b > a)
            {
                if (c > a)
                {
                    Console.WriteLine("b>c>a");
                }
                else
                {
                    Console.WriteLine("b>a>c");
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("c>a>b");
                }
                else
                {
                    Console.WriteLine("c>b>a");
                }

            }
            Console.WriteLine("--------------------------");

            int[] num = new int[] { a, b, c };

            num.Max();
            num.Min();

            
            
            
            
            Console.WriteLine(num.Max() + ">" + num[0]+">"+num.Min());
            


            Console.WriteLine("--------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
