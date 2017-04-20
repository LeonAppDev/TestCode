using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace PracticeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();

            int[] numbers = { 9,5,6,3,4,21,1/5};

            Assert.AreEqual(48,p.Summation(numbers));

            string s = "abc";

            //Assert.AreEqual(string[])({ "a", "b", "c"},p.combination(s));


            string test1 = "anna";
            string test2 = "aaaaaaaa";
            string test3 = "aaaaaaaab";
            string test4 = "caaaaaaaab";
            string test5 = "donotbobtonod";
            string test6 = "owefhijpfwai";
            string test7 = "igdedgide";
          

            Assert.AreEqual(true, p.isPalindrome(test1));
            Assert.AreEqual(true, p.isPalindrome(test2));
            Assert.AreEqual(true, p.isPalindrome(test3));
            Assert.AreEqual(false, p.isPalindrome(test4));
            Assert.AreEqual(true, p.isPalindrome(test5));
            Assert.AreEqual(false, p.isPalindrome(test6));
            Assert.AreEqual(true, p.isPalindrome(test7));


        }
    }
}
