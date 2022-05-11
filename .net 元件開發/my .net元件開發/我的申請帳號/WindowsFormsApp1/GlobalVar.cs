using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // 全域變數
    class GlobalVar
    {
        public static string 目前使用者 = ""; // 變數只要執行static會馬上建立變數, 不需要宣告,執行即存在且唯一
                                         //public int count = 0; // count如果存在var1.2.3就不是全域變數
        public static string[] acount = new string[5];
        public static string[] pass = new string[5];
        public static int count = 0;
    }
}
