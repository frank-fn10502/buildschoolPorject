using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint i = 0, j = 1 ,t = 0 ,c = 0;
            while(i < 1836311903)
            { 
                t = i;
                i = i + j;
                j = t;
                Console.WriteLine($"{++c}: {i}");
            }
            Console.ReadKey();
        }
    }
}
