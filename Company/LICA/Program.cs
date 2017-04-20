using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
      

        /*This function take a string as input and return true if this string is palindrome 
         * or the anagram of this string is palindrome. 
         * Otherwise return false */
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

            if (oddCount > 1)
                return false;
            else
                return true;
        }
 


        static void Main(string[] args)
        {

          
        }
    }



}
