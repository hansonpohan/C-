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
    class 品項資訊
    {
        public List<string> 品名 = new List<string>();
        public List<int> 單價 = new List<int>();
        public List<string> 冰塊 = new List<string>();
        public List<string> 甜度 = new List<string>();
        public List<string> 加料 = new List<string>();
        public List<int> 加料價格 = new List<int>();
        public int 加料數量 = 0;
    }
}
