using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題
{
    class Globalvar
    {       
        public static List<phone> list訂購品項列表 = new List<phone>();
        public static Form1 form登入;
        public static Form2 form訂單;
        public static Form3員工登入修改 form員工;        
        public static int ID = 0;
        public static string 帳號 = "";
        public static string 密碼 = "";
        public static string 會員名稱 = "";
        public static string 電話 = "";
        public static string 地址 = "";
        public static string Email = "";
        public static DateTime 生日 = new DateTime(1900, 01, 01, 0, 0, 0);       
    }
}
