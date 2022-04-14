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
            Console.ForegroundColor = ConsoleColor.Red;
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

            Console.Write((aa+bb).Length);









                Console.WriteLine("結束按Enter");
            Console.ReadLine();

        }
    }
}
