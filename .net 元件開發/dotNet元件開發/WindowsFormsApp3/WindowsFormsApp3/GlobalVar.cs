using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    class GlobalVar
    {
        public static string 訂購人資訊 = "";
        public static List<ArrayList> list訂購品項列表 = new List<ArrayList>();
        //作業規格: 品項資訊要由ArrayList改成自訂類別Class;
        public static Form1 form菜單;
        public static Form2 form結帳單;

    }
}
