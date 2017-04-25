using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace programmingTest
{
    interface IPalindrome
    {

        bool isPalindrome(string original);
    }
    public class Palindrome:IPalindrome
    {
        public bool isPalindrome(string original)
        {
            int oddCount = 0;
            List<int> numberOfChar = new List<int>();
            List<char> charList = new List<char>();

            //Count numbers of all chars in this string
            foreach (char c in original)
            {
                if (charList.IndexOf(c) == -1)
                {
                    charList.Add(c);
                    numberOfChar.Add(1);
                }
                else
                {
                    numberOfChar[charList.IndexOf(c)]++;
                }
            }

            //If the number of each char appears in the string is even or only one number is odd,
            //we say its anafram could be palindrome.
            foreach (int i in numberOfChar)
            {
                if (i % 2 != 0)
                    oddCount++;
            }

           if(oddCount > 1)
                return false;
            else
                return true;
        }
    }


    class Program
    {

        private IPalindrome _stringOperate;
        //initialize nlog object
        private static Logger logger = LogManager.GetCurrentClassLogger();

        //set up a sample constructor injector
        Program(IPalindrome StringOperate)
        {
            this._stringOperate = StringOperate;
        }

        static void Main(string[] args)
        {
            Palindrome pa = new Palindrome();

            Program p = new Program(pa);


            //Print output to console using NLog
            string test1 = "anna";
            string test2 = "aaaaaaaa";
            string test3 = "aaaaaaaab";
            string test4 = "caaaaaaaab";
            string test5 = "donotbobtonod";
            string test6 = "owefhijpfwai";
            string test7 = "igdedgide";

            logger.Info(test1+" or its anagram is {0} palindrome",p._stringOperate.isPalindrome(test1)?"":"Not");
            logger.Info(test2 + " or its 6anagram is {0} palindrome", p._stringOperate.isPalindrome(test2) ? "" : "Not");
            logger.Info(test3 + " or its anagram is {0} palindrome", p._stringOperate.isPalindrome(test3) ? "" : "Not");
            logger.Info(test4 + " or its anagram is {0} palindrome", p._stringOperate.isPalindrome(test4) ? "" : "Not");
            logger.Info(test5 + " or its anagram is {0} palindrome", p._stringOperate.isPalindrome(test5) ? "" : "Not");
            logger.Info(test6 + " or its anagram is {0} palindrome", p._stringOperate.isPalindrome(test6) ? "" : "Not");
            logger.Info(test7 + " or its anagram is {0} palindrome", p._stringOperate.isPalindrome(test7) ? "" : "Not");

          
            //a process used to accept input in a loop and print result to console
            System.Console.WriteLine("Input strings to test whether this string or its anagram could be palindrome,type exit to quit ");

            string input =System.Console.ReadLine();
            while (input != "exit")
            {
                System.Console.WriteLine(input + " or its anagram is {0} palindrome",p._stringOperate.isPalindrome(input)?"":"Not");

                input = System.Console.ReadLine();

            }
            


        }
    }
}
