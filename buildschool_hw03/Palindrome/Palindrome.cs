using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public bool checkIsPalindrome(string str)
        {
            for(int start = 0 ,end = str.Length - 1 ; start <= end ; start++ ,end--)
            {
                if(str[start] != str[end])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
