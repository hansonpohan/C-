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
            // 變數 Variable 的宣告
            short a;
            a = 2000;
            int amount = 250000;
            long count = 42000000000;
            //無正負號
            ushort aa = 65000;
            uint aamount = 36000000;
            ulong ccount = 7000000000000;

            Console.WriteLine("整數的宣告");
            Console.WriteLine(a);
            Console.WriteLine(amount);
            Console.WriteLine(count);
            Console.WriteLine(aa);
            Console.WriteLine(aamount);
            Console.WriteLine(ccount);

            //浮點數
            float average = 888.23f;
            double pi = 3.141592;
            Console.WriteLine("平均:" + average);
            Console.WriteLine("圓周率:" + pi);

            //布林 Boolean
            bool isSuccess = true;
            bool isFinish = false;
            Console.WriteLine("是否成功:" + isSuccess);
            Console.WriteLine("是否完成:" + isFinish);

            //字串 string
            string name = "王大衛";
            string 電話 = "0912-345-678";
            string email = "test@mmm.com";
            Console.Write("姓名:");
            Console.Write(name);
            Console.Write(", 電話:" + 電話);
            Console.Write(", email:" + email);
            Console.WriteLine();

            //字元 char
            char myCharOne = 'x';
            char myCharTwo = '微';
            Console.WriteLine("字元輸出:" + myCharTwo + myCharOne);

            //字串插入, 字串插值
            Console.WriteLine("姓名:{0} 電話:{2} Email:{1} 年齡:{3}", name, email, 電話, 36);
            //變數插入
            Console.WriteLine($"姓名:{name} 電話:{電話} Email:{email} 年齡:{36}");

            //Console.WriteLine("\n按Enter結束");
            //Console.ReadLine();

            Console.WriteLine("\n按任意鍵結束");
            Console.ReadKey();

        }
    }
}
