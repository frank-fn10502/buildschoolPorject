using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 100000;
            bool[] array = new bool[n];
            for (int i = 0 ; i < n ; i++) array[i] = true;

            for (int i = 2 ; i < n ; i++)
            {
                if(array[i])
                {
                    for (int j = i + i ; j < n ; j += i) array[j] = false;
                }
            }
            for(int i = 101 ; i <= 200 ; i++)
            {
                if (array[i]) Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
