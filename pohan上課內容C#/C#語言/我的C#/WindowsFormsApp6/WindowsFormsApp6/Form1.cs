using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//要先加

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        //類別變數class層級
        List<ArrayList> 員工資料集合 = new List<ArrayList>();
        List<Hashtable> 員工資料集合2 = new List<Hashtable>();//list是變動的不用定義長度

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //List Demo
            List<int> myIntList = new List<int> { 1, 2, 3, 4, 5, 6 };//list不允許語法糖必須要new
            List<string> myList = new List<string>();//null記憶體位置還沒配置
            myList.Add("red");
            myList.Add("yellow");
            myList.Add("blue");
            myList.Add("purple");
            myList.Add("green");

            Console.WriteLine("List Demo");
            Console.WriteLine("============= 列出所有List所有元素 =============");
            foreach(string mycolorString in myList)
            {
                Console.WriteLine(mycolorString);
            }
            Console.WriteLine("============ 修改List元素 =============");
            myList[0] = "darkred";//修改方式跟Array一樣
            myList[2] = "deepblue";
            for (int i = 0;i < myList.Count;i += 1)//List要用.Count
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("========== 加入另一個集合(List,Array) ==========");
            //新加的陣列要是同類型(string,int)
            string[] arrayStringOther = new string[] { "pink", "gray", "brown" };
            myList.AddRange(arrayStringOther);//用addrange加入
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("========== Insret插入元素 ===========");
            //insert(要插入元素的索引值,要插入元素的內容)
            myList.Insert(2, "skyblue");
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("============ Insretrange 插入集合  =============");
            //insertrange(要插入元素的索引值,要插入元素的集合)
            myList.InsertRange(3, arrayStringOther);
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("=========== Remove 移除元素 ==========");
            string strRemove = "gray";
            myList.Remove(strRemove);//可以搭配 while 迴圈移除
            //myList2.Add(strRemove); 假設例子
            myList.Remove("gray");//只會移除第一個元素
            myList.RemoveAt(3);//RemoveAt移除索引值為3的元素
            myList.RemoveRange(4, 2);//從4的索引質(包含4)移除2個 移除 index:4和5的元素
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("=========== Sort 排序 =========");
            myList.Sort();
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("=========== reverse 反向排列 ===========");
            myList.Reverse();//大數據應用for迴圈由大到小,盡量不要用reverse
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("========== Indexof 元素搜尋 ===========");
            int idx = myList.IndexOf("darkred");
            Console.WriteLine("darkred index" + idx);

            Console.WriteLine("============ List 轉換成 Array ==========");
            string[] myTempArray = myList.ToArray();
            foreach (string myColorString in myTempArray)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("============ Array 轉換成 List ==========");
            //建立全新物件
            List<string> myListNew = new List<string>(myTempArray);
            foreach (string myColorString in myTempArray)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("=========== Clear 清除 ==========");
            myList.Clear();
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("===========================");
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=========== ArrayList Demo ==========");
            ArrayList myPersonInfo = new ArrayList(); //風險高可以混合不同的資料型態但無法判斷
            myPersonInfo.Add("王小明");            //index:0
            myPersonInfo.Add(32000.0);            //index:1
            myPersonInfo.Add(DateTime.Now);       //index:2
            myPersonInfo.Add("0912-345-678");     //index:3
            myPersonInfo.Add("高雄市前金區中正路"); //index:4
            myPersonInfo.Add(26);                 //index:5

            ArrayList myPersonInfo2 = new ArrayList();
            myPersonInfo2.Add("張大書");
            myPersonInfo2.Add(45000.0);
            myPersonInfo2.Add(DateTime.Now);
            myPersonInfo2.Add("0911-333-666");
            myPersonInfo2.Add("台南市東區中華路");
            myPersonInfo2.Add(40);

            員工資料集合.Add(myPersonInfo);
            員工資料集合.Add(myPersonInfo2);

            foreach (ArrayList perinfo in 員工資料集合)
            {
                string 姓名 = Convert.ToString(perinfo[0]);
                double 薪水 = Convert.ToDouble(perinfo[1]);
                DateTime 到職日 = Convert.ToDateTime(perinfo[2]);
                string 電話 = Convert.ToString(perinfo[3]);
                string 地址 = Convert.ToString(perinfo[4]);
                int 年齡 = Convert.ToInt32(perinfo[5]);

                string strMsg = string.Format("{0} {1} {2:d} {3} {4} {5}",姓名,薪水,到職日,電話,地址,年齡);
                Console.WriteLine(strMsg);
            }

            Console.WriteLine("===============================");
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=========== Dictionary Demo ==============");
            Dictionary<string, int> dictScore = new Dictionary<string, int>();
            //現實生活中的key常用身分證字號,會員編號(主流),手機,e-mail,流水號
            dictScore.Add("王小明", 84);//key不能重複,value可以重複
            dictScore.Add("陳大貓", 72);
            dictScore.Add("李瑪莉", 69);
            dictScore["陳大貓"] = 76;//dictionary要用key去修改值
            dictScore["張大書"] = 77;//不存在的key會新增,已存在的會覆蓋

            Console.WriteLine("李瑪莉分數:{0}", dictScore["李瑪莉"]);

            dictScore.Remove("王小明");//用key
            //字典用KeyValuePair<string,int>
            foreach (KeyValuePair<string,int> myDict in dictScore)
            {
                Console.WriteLine("key:{0} ,value:{1}", myDict.Key, myDict.Value);
            }
            //dictionary沒有index,要用containskey搜尋,只能搜尋key
            if (dictScore.ContainsKey("陳大貓"))
            {
                Console.WriteLine("陳大貓: {0}", dictScore["陳大貓"]);
            }
            else
            {
                Console.WriteLine("查無此人");
            }
            Console.WriteLine("===============================");
            Dictionary<string, string> stockCode = new Dictionary<string, string>()
            {//賦值
                {"AAPL", "蘋果公司"},
                {"AMZN", "亞馬遜公司"},
                {"TSLA", "特斯拉公司"}
            };
            //.count包含的數目
            for (int i = 0; i < stockCode.Count; i += 1)
            {//ElementAt傳回特定位置的元素
                Console.WriteLine("key:{0}, value:{1}", stockCode.ElementAt(i).Key, stockCode.ElementAt(i).Value);
            }
            //另一種寫法
            /*foreach (KeyValuePair<string,string> mydict in stockCode)
            {
                Console.WriteLine("key:{0}, value:{1}", mydict.Key, mydict.Value);
            }*/
            Console.WriteLine("===============================");
            dictScore.Clear();
            Console.WriteLine("dictScore count:{0}", dictScore.Count);

            Console.WriteLine("===============================");
        }

        private void btnHashtable_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=========== Hashtable Demo ===========");


            //hashtable用演算法的方式儲存,順序會改變

            Hashtable memberInfo = new Hashtable();
            memberInfo.Add("姓名", "王大衛");
            memberInfo.Add("年齡", 30);
            memberInfo.Add("身高", 170.5);
            memberInfo.Add("電話", "0912-555-888");
            memberInfo.Add("Email","testWang@test.com");
            memberInfo["電話"] = "0988-999-111";
            memberInfo["地址"] = "高雄市新興區";
            memberInfo.Remove("身高");
            


            //hashtable用DictionaryEntry
            foreach (DictionaryEntry element in memberInfo)
            {
                Console.WriteLine("key:{0} value:{1}", element.Key, element.Value);
            }

            if (memberInfo.ContainsKey("電話"))
            {
                Console.WriteLine("電話:{0}", memberInfo["電話"]);
            }
            else
            {
                Console.WriteLine("無此欄位");
            }
            Console.WriteLine("===============================");
            string name = Convert.ToString(memberInfo["姓名"]);
            int age = Convert.ToInt32(memberInfo["年齡"]);
            string email = Convert.ToString(memberInfo["Email"]);

            Console.WriteLine($"姓名:{name} 年齡:{age} Email:{email}");

            員工資料集合2.Add(memberInfo);

            foreach (Hashtable myMemInfo in 員工資料集合2)
            {
                string myName = Convert.ToString(memberInfo["姓名"]);
                int myAge = Convert.ToInt32(memberInfo["年齡"]);
                string myEmail = Convert.ToString(memberInfo["Email"]);

                Console.WriteLine($"姓名:{name} 年齡:{age} Email:{email}");
            }

            Hashtable stockCode2 = new Hashtable()
            {
                {"AAPL", "蘋果公司"},
                {"AMZN", "亞馬遜公司"},
                {"TSLA", "特斯拉公司"}
            };

            stockCode2.Clear();

            Console.WriteLine("===============================");

        }

        private void btnString進階_Click(object sender, EventArgs e)
        {
            Console.WriteLine("============== string 字串的進階操作 ============");
            //C# string == string 是基本資料型態,也是物件
            string strA = "string on \n string one";
            string strB = @"c:\windows\notes\test.txt";//@忽略特殊符號字元

            Console.WriteLine(strA);
            Console.WriteLine(strB);

            string strOne = "Hello World !! C# string World.";
            Console.WriteLine(strOne);
            Console.WriteLine("字串長度:{0}", strOne.Length);

            int index = strOne.IndexOf("World");
            Console.WriteLine("World第一個起始字元index:{0}", index);

            //myList.Insert(2, "skyblue");reference type 傳址
            string strTwo = strOne.Insert(6, "Hi ");//value type 傳值
            Console.WriteLine(strTwo);

            string strThree = strOne.Remove(6);
            Console.WriteLine(strThree);
            //從索引值12開始刪除3個字元
            string strFour = strOne.Remove(12,3);
            Console.WriteLine(strFour);

            //取代
            string strFive = strOne.Replace("World", "Earth");
            Console.WriteLine(strFive);

            //Substring 截取字串15後2個索引值(包含15)
            string strSix = strOne.Substring(15, 2);
            Console.WriteLine(strSix);

            //截取test@domain.com
            string stra = "test@domain.com";
            string strb = stra.Substring(5, 10);
            Console.WriteLine(strb);

            //轉小寫, ToUpper()轉大寫
            string strSeven = strOne.ToLower();
            Console.WriteLine(strSeven);
            
            //比對字串必須統一大小寫
            bool isContain = strSeven.Contains("c#");
            Console.WriteLine("是否有C#字串:{0}", isContain);
            Console.WriteLine("第三個字元:{0}", strOne[2]);

            //拆成5個元素的陣列,盡量用少用的符號
            string strCollection = "珍珠|波霸|QQ|椰果|芋圓";
            string[] arrayWords = strCollection.Split('|');

            foreach (string myWord in arrayWords)
            {
                Console.WriteLine(myWord);
            }



            Console.WriteLine("===============================");
        }
    }
}
