using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int layers = 0;
            Console.Write("輸入: ");
            layers = int.Parse(Console.ReadLine());

            for(int i = layers ,j = 1 ; i > 0 ; i-- ,j++)
            {
                for(int k = 0 ; k < j ; k++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
