using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input line of number: ");
            var line = Console.ReadLine();
            var numbers = line.Split(',');

            var odd = numbers.Where(x => int.Parse(x) % 2 == 0);
            var even = numbers.Except(odd);

            Console.WriteLine($"odd: {string.Join("," ,odd)}\n" +
                              $"even: {string.Join("," ,even)}");

            Console.ReadKey();
        }
    }
}
