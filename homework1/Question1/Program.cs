using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("請輸入數字: ");
            n = int.Parse(Console.ReadLine());

            Console.Write($"{n} 是一個 {(n % 2 == 0 ? "偶數" : "奇數") }");
            Console.ReadKey();
        }
    }
}
