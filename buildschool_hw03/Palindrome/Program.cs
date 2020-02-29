using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input string: ");
            var str = Console.ReadLine();
            Palindrome palindrome = new Palindrome();
            Console.WriteLine($"{str}: {(palindrome.checkIsPalindrome(str) ? "是回文" : "不是回文")}");
        }
    }
}
