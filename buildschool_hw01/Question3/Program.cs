using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberArray = null;

            Console.Write("輸入: ");
            numberArray = Console.ReadLine().Split(',');

            Console.Write("結果: ");
            for(int i = numberArray.Length-1 ; i >= 0 ; i--)
            {
                Console.Write($"{numberArray[i]}{(i != 0 ? "," : "")}");
            }
            Console.ReadKey();
        }
    }
}
