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
        // 不寫的預設值是 private
        public float 身高 = 0.0f; //field 欄位
        public double 體重 = 0.0; //欄位
        public DateTime 到職日 = DateTime.Now; //欄位
        public int 部門代號 = 0; //欄位



        public string 姓名 { get; set; } // 屬性 property, get:取值 set: 存值       姓名放等號右邊執行get 左邊執行set  姓名沒有做get set操作等同於欄位   薪資則是屬性
        // 屬性
        protected double _薪資; // 屬性在類別裡的存值處
        public virtual double 薪資
        {
            get //等號右邊
            { // 取值
                return _薪資;
            }

            set //使用者輸入放在value裡   等號左邊
            { //存值
                if (value < 25250.0)
                {
                    value = 25250.0;
                }
                else
                {
                    //符合勞基法最低薪資
                }
                _薪資 = value;
            }

        }

        //泛行欄位 Generics
        public PersonInfo<string> Email = new PersonInfo<string>();
        public PersonInfo<int> 年齡 = new PersonInfo<int>();

        //結構欄位 struct
        public AddressInfo 地址;



        // 建構式
        // 建構式一定不能是 private
        public Person()  // 建構式會回傳person的資料型態,不用再定義
        {
            // 預設建構式
            姓名 = "";
        }

        public Person(string myname)
        { // 建構方法多載
            this.姓名 = myname;//this 就是物件本身  this 可以省略
        }
        // 方法
        // virtual 允許複寫方法
        public virtual void 顯示基本資料()
        {
            /*string strInfo = $"姓名:{this.姓名} 身高:{this.身高} 體重:{this.體重} 到職日:{this.到職日} 薪資:{this.薪資}";*/
            string strInfo = string.Format(" 姓名:{0}\n 身高:{1:F}公分\n 體重:{2:F}公斤\n 薪資:{3:C}\n 到職日:{4:D}\n 部門代號:{5}\n 部門名稱:{6} \n 年齡:{7}\n Email:{8} \n 地址:{9}", 姓名, 身高, 體重,薪資, 到職日,部門代號,顯示部門名稱(部門代號), 年齡.data, Email.data, 地址.完整地址());

            strInfo += "本資料由 " + GlobalVar.目前使用者 + " 編輯輸入";
            MessageBox.Show(strInfo);            
        }

        // 靜態執行沒有實體化不能用 this ,object需要實體化所以不能靜態執行
        public static void aboutInfo()
        {
            MessageBox.Show("類別名稱: \n功能:儲存員工基本資料\n版本:v0.1");
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

            獎金 = 一年資獎金 * 計算年資();
            if ( 獎金 < 500)
            {
                獎金 = 500.0;
            }

            return 獎金;
        }

        // 列舉 enum
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
