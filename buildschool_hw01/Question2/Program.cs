using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitArray = null;
            int[] numberArray = null;
            string oddStr = "", evenStr = "";

            Console.Write("請輸入數字字串: ");
            splitArray = Console.ReadLine().Split(',');
            numberArray = Array.ConvertAll(splitArray ,a => int.Parse(a));
            Array.Sort(numberArray);

            foreach (int n in numberArray)
            {
                if(n % 2 == 0)
                {
                    evenStr += (evenStr != "" ? ", " : "") + n.ToString();
                }
                else
                {
                    oddStr += (oddStr != "" ? ", " : "") + n.ToString();
                }
            }
            Console.Write($"偶數: {evenStr} \n" +
                          $"奇數: {oddStr}");

            Console.ReadKey();
        }
    }
}
