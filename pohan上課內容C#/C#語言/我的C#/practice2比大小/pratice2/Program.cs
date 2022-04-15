using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //用條件判斷式, 隨意輸入三個數字比大小;
            int a = 10;
            int b = 50;
            int c = 20;

            if (a > b )
            {
                Console.WriteLine("a>b");
            }
            if (b > c)
            {
                Console.WriteLine("b>c");
            }
            if (b > a)
            {
                Console.WriteLine("b>a");
            }
            if (c > a)
            {
                Console.WriteLine("c>a");
            }
            if (c > b)
            {
                Console.WriteLine("c>b");
            }
            if (a > c)
            {
                Console.WriteLine("a>c");
            }
            Console.WriteLine("-------------------");

            if (a > b && b > c)
            {
                Console.WriteLine("a>b>c");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("a>c>b");
            }
            else if (b > c && c > a)
            {
                Console.WriteLine("b>c>a");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("b>a>c");
            }
            else if (c > a && a > b)
            {
                Console.WriteLine("c>a>b");
            }
            else 
            {
                Console.WriteLine("c>b>a");
            }

            Console.WriteLine("請案任意鍵");
            Console.ReadLine();
        }
    }
}
