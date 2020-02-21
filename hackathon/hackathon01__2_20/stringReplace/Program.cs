using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringReplace
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int i = 1 ; i <= 100 ; i++)
            {
                //m1(i);
                m2(i);
            }
            Console.ReadKey();
        }
        static void m1(int nn)
        {
            Dictionary<int ,string> dict = new Dictionary<int ,string>();
            dict[3] = "A";
            dict[5] = "B";
            dict[9] = "C";
            dict[0] = "D";

            string target = nn.ToString();
            foreach (var item in target)
            {
                int n = (int)Char.GetNumericValue(item);
                if (dict.ContainsKey(n))
                {
                    Console.Write(dict[n]);
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.Write("\n");
        }
        static void m2(int nn)
        {
            string target = nn.ToString();
            Console.WriteLine(target.Replace('3' ,'A').Replace('5' ,'B')
                                    .Replace('9' ,'C').Replace('0' ,'D'));
        }
    }
}
