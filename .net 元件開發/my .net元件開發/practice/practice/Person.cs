using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    class Person
    {
        public string 姓名 = "";
        public double 身高 = 0.0;
        public double 體重 = 0.0;
        public int 年齡 = 0;
        public int 部門代號 = 0;

        //public double 薪資 { get; set; }

        private double _薪資 = 0;
        public  double 薪資
        {
            get
            {
                return _薪資;
            }
            set
            {
                if (_薪資<25250)
                {
                    value = 25250;
                }
                else
                {
                    
                }
                _薪資 = value;
            }
        }

        public  void 顯示基本資料()
        {
            string str = string.Format("姓名:{0}",姓名);
            MessageBox.Show(str);
        }




    }
}
