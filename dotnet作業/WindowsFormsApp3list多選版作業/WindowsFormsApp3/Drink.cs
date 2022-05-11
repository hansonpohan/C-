using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Drink
    {
        public int 品項杯數 = 0;
        public int 單價 = 0;
        public int 單價加料 = 0;
        public string 訂購品項 = "";
        public string 甜度 = "";
        public string 冰塊 = "";
        public string 加料 = "";
        public int 加料價格 = 0;
        public int 品項總價 = 0;

        //把所有品項的加料單價放進陣列列出
        public int[] 所有單價()
        {
            int[] 列表 = new int[品項杯數];

            for (int i = 0; i < 品項杯數; i++)
            {
                列表[i] = 單價;
                if (單價加料 != 0 && 單價加料 != 單價)
                {
                    列表[i] = 單價加料;
                }
            }
            return 列表;
        }
    }
}
