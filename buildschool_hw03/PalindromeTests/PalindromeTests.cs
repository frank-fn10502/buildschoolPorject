using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void checkIsPalindromeTest()
        {
            //arrange
            Palindrome c = new Palindrome();
            string str = "12321";
            bool expected = true;

            //act
            bool actual = c.checkIsPalindrome(str);

            //assert
            Assert.AreEqual(expected ,actual);
            //Assert.Fail();
        }
    }
}