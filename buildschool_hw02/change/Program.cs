using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> _dict = new Dictionary<int, string>();
            _dict[1] = "一";
            _dict[2] = "二";
            _dict[3] = "三";
            _dict[4] = "四";
            _dict[5] = "五";
            _dict[6] = "六";
            _dict[7] = "七";
            _dict[8] = "八";
            _dict[9] = "九";
            _dict[0] = "零";

            Console.Write("請輸入一串四位數字: ");
            string str = Console.ReadLine();
            string result = "";
            foreach(var s in str)
            {
                int n = (int)Char.GetNumericValue(s);
                if(_dict.ContainsKey(n))
                {
                    result += _dict[n];
                }
                else if(s != '\n' && s != '\r')
                {
                    Console.WriteLine(s);
                    Console.WriteLine("不能有數字以外的東西!!!");
                    Console.ReadKey();
                    return;
                }
                
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
