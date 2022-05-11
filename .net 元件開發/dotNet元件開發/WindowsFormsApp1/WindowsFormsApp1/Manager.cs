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
    class Manager : Person, IMan
    {
        public int 職稱代號 = 0;

        public Manager()
        {

        }
        
        public Manager(string myName)
        {
            姓名 = myName + " 主管";
        }

        public override double 薪資
        {
            get
            {
                return _薪資;
            }

            set
            {
                if (value < 25250.0)
                {
                    value = 25250.0;
                }
                else
                {
                    //符合勞基法最低薪資
                }
                value += 6000; //主管管理加給
                _薪資 = value;
            }
        }

        public override void 顯示基本資料()
        {
            string strInfo = string.Format("姓名:{0}\n身高:{1:F}公分\n體重:{2:F}公斤\n薪資:{3:C}元\n到職日:{4:D}\n職稱:{5}\n部門名稱:{6}\n", 姓名, 身高, 體重, 薪資, 到職日, 顯示職稱(職稱代號), 顯示部門名稱(部門代號));
            strInfo += "管理者職務";

            MessageBox.Show(strInfo);
        }

        public string 顯示職稱(int 職稱代號)
        {
            string strMan = "";

            switch (職稱代號)
            {
                case (int)MyEnums.Man.董事長:
                    strMan = "董事長";
                    break;
                case (int)MyEnums.Man.總經理:
                    strMan = "總經理";
                    break;
                case (int)MyEnums.Man.經理:
                    strMan = "經理";
                    break;
                case (int)MyEnums.Man.組長:
                    strMan = "組長";
                    break;
                case (int)MyEnums.Man.副總:
                    strMan = "副總";
                    break;
                default:
                    strMan = "無此職稱";
                    break;
            }

            return strMan;
        }


    }
}
