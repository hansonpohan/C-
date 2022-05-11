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
    class 訂單資訊
    {
        public string 品名 = "";
        public int 單價 = 0;
        public int 加料單價 = 0;
        public int 品項杯數 = 0;
        public int 品項總價 = 0;
        public string 冰塊 = "";
        public string 甜度 = "";
        public string 加料 = "";
        public int 加料價格 = 0;

        public int[] 所有單價()
        {
            int[] 列表 = new int[品項杯數];
            
            for (int i = 0; i < 品項杯數; i += 1)
            {
                列表[i] = 單價;
                if ((加料單價 != 0) && (加料單價 != 單價))
                {
                    列表[i] = 加料單價;
                }
            }
            return 列表;
        }
        
    }
}
