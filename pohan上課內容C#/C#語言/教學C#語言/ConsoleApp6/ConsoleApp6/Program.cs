using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //While 迴圈
            while (true)
            {
                Console.WriteLine("Hello World.");
                break;
            }
            Console.WriteLine("------------------------------");
            int d = 1;
            while (true)
            {
                if (d > 10)
                {
                    break;
                }

                Console.WriteLine("d:" + d);
                d += 1;
            }
            Console.WriteLine("------------------------------");
            int dd = 1;
            while (dd <= 10)
            {
                Console.WriteLine("dd:" + dd);
                dd += 1;
            }
            Console.WriteLine("------------------------------");
            //do ... while 迴圈
            do
            {
                Console.WriteLine("Hello World.");
            }
            while (false);

            int g = 1;
            do
            {
                Console.WriteLine("g:" + g);
                g += 1;
            }
            while (g <= 10);



            Console.WriteLine("------------------------------");
            Console.WriteLine("按任意鍵結束程式");
            Console.ReadKey();
        }
    }
}
