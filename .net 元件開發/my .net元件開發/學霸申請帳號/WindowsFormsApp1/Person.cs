using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Person
    {
        public float 身高 = 0.0f; //field 欄位
        public double 體重 = 0.0; //欄位
        public DateTime 到職日 = DateTime.Now; //欄位
        public int 部門代號 = 0;

        public Person (float height,double weight,DateTime fstday,int depcode)
        {
            身高 = height;
            體重 = weight;
            到職日 = fstday;
            部門代號 = depcode;
        }

        public string 姓名 { get; set; } //property 屬性 , get:取值 , set:存值

        protected double _薪資;
        public virtual double 薪資
        {
            get
            { //取值 等號右邊
                return _薪資;
            }

            set
            { //存值 等號左邊
                if (value < 25250.0)
                {
                    value = 25250.0;
                }
                else
                {
                    // 符合勞基法最低薪資
                }
                _薪資 = value;
            }
        }

        //泛型欄位 Generics
        public PersonInfo<string> Email = new PersonInfo<string>();
        public PersonInfo<int> 年齡 = new PersonInfo<int>();

        //結構欄位 Struct
        public AddressInfo 地址;

        public Person()
        {
            // 預設建構式
            姓名 = "";
        }

        public Person(string myName)
        { // 建構方法多載
            this.姓名 = myName; // this 物件本身 ， c#可以省略
        }

        public virtual void 顯示基本資料()
        {
            //string strInfo = $"姓名:{this.姓名} 身高:{this.身高} 體重:{this.體重} 到職日:{this.到職日} 薪資:{this.薪資}";

            string strInfo = string.Format("姓名:{0}\n身高:{1:F}公分\n體重:{2:F}公斤\n薪資:{3:C}元\n到職日:{4:D}\n部門代號:{5}\n部門名稱:{6}\nEmail:{7}\n年齡:{8}\n地址:{9}", 姓名, 身高, 體重, 薪資, 到職日,部門代號,顯示部門名稱(部門代號),Email.data,年齡.data,地址.完整地址());
            strInfo += "\n本資料由 " + GlobalVar.目前使用者 + " 編輯輸入";
            MessageBox.Show(strInfo);
        }

        public static void aboutInfo()
        {
            MessageBox.Show("類別名稱:Person\n功能:儲存員工基本資料\n版本:v0.1");
        }

        public double 計算年資()
        {
            double 年資 = 0.0;

            TimeSpan ts = DateTime.Now - this.到職日;
            年資 = ts.TotalDays / 365.0;

            return 年資;
        }

        public double 依年資計算獎金(double 一年資獎金)
        {
            //最低獎金 500
            double 獎金 = 0.0;

            獎金 = this.計算年資() * 一年資獎金;
            /*
            if(this.計算年資() < 1.0)
            {
                獎金 = 500;
            }
            */
            if(獎金 < 500)
            {
                獎金 = 500;
            }

            return 獎金;
        }

        public string 顯示部門名稱(int 部門代號)
        {
            string strDep = "";

            switch (部門代號)
            {
                case (int)MyEnums.Dep.行政處:
                    strDep = "行政執行處";
                    break;
                case (int)MyEnums.Dep.資訊處:
                    strDep = "資訊管理處";
                    break;
                case (int)MyEnums.Dep.業務部:
                    strDep = "業績推廣部";
                    break;
                case (int)MyEnums.Dep.研發部:
                    strDep = "創新研發部";
                    break;
                default:
                    strDep = "無此部門";
                    break;
            }

            return strDep;
        }
    }
}
