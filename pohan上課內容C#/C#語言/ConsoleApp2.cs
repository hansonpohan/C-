using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 變數 Varibale 的宣告,同一變數不能重複宣告,但內容質可以改變
            short a;//16位元
            a = 2000;//"="Assign指定運算子
            int amount = 2500000;//32位元
            long count = 42000000000;//64位元
            //無正負號前面+n
            ushort aa = 65000;
            uint aamount = 36000000;
            ulong ccount = 70000000000000;

            Console.WriteLine("整數的宣告");
            Console.WriteLine(a);
            Console.WriteLine(amount);
            Console.WriteLine(count);
            Console.WriteLine(aa);
            Console.WriteLine(aamount);
            Console.WriteLine(ccount);
            Console.ReadLine();
        }
    }
}
