using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_cal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number: ");
            int result = 0;
            int num = int.Parse(Console.ReadLine());

            //method 1
            //for (int i = 1 ; i < num ; i += 2)
            //{
            //    result += i - (i + 1);
            //}
            result = (num / 2) * (-1);
            result = num % 2 != 0 ? result + num : result;

            Console.WriteLine($"{FormulaToString(Enumerable.Range(1 ,num).ToList())} = {result}");
            Console.ReadKey();
        }
        static string FormulaToString(List<int> numList)
        {
            string result = "";
            foreach (var item in numList)
            {
                result += item.ToString();
                if (item != numList.Count)
                {
                    result += (item % 2 != 0 ? " - " : " + ");
                }
            }

            return result;
        }
    }
}
