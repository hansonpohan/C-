using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PersonInfo<T>
    {
        public T data;

        public void saveData(T inputData)
        {
            data = inputData;

            //判斷資料型態
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.String:
                    Console.WriteLine("string 型態");
                    break;
                case TypeCode.Int32:
                    Console.WriteLine("int32 型態");
                    break;
                case TypeCode.Double:
                    Console.WriteLine("double 型態");
                    break;
                case TypeCode.Boolean:
                    Console.WriteLine("boolean 型態");
                    break;
                default:
                    Console.WriteLine("其他資料型態");
                    break;
            }
        }

        
    }
}
