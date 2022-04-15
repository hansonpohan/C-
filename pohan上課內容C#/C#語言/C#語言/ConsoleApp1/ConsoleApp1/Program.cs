using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 單行註解
            /*
              多行註解
                1234
            ABCD
              +_+_+_+
             */
            System.Console.WriteLine("Hello World !!");
            System.Console.WriteLine("Hi, 這是第一個Console程式");
            Console.WriteLine("C# 語言第一個示範");
            Console.WriteLine("C# Demo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. 主控台應用程式");
            Console.WriteLine("2. Windows Form 應用程式");
            Console.WriteLine("3. Web 應用程式");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("特殊字元符號");
            Console.WriteLine("\"雙引號\"");
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\t\t縮排");
            Console.WriteLine("換行\n\n\n");

            Console.WriteLine("按Enter結束程式");
            System.Console.ReadLine();
        }
    }
}
