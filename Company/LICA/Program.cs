using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
        public int Summation(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;

        }


        public string[] combination(string original)
        {
            int count = 0;
            List<string> returnArray = new List<string>();

            //while (count < original.Length)
            //{
            //Recursion could start only when string length >1, deal with condition original lenght e1  
            if (count == (original.Length - 1))
                returnArray.Add(original[count].ToString());
            else
            {
                char c = original[count];
                string[] subArray = combination(original.Substring(count + 1, original.Length - count - 1));

                returnArray.Add(c.ToString());
                foreach (string s in subArray)
                {
                    returnArray.Add(s);
                    returnArray.Add(c + s);
                }
            }
            //    count++;


            //}
            return returnArray.ToArray();


        }


        public string[] Anagram(string original)
        {
            int count = 0;
            List<string> anagramList = new List<string>();

            if (1 == original.Length)
                return new string[] { original };
            else
            {
                char c = original[count];

                string[] returnArray = Anagram(original.Substring(count + 1, original.Length - count - 1));

                foreach (string s in returnArray)
                {
                    for (int i = 0; i < s.Length; i++)
                    { string temp = s.Insert(i, c.ToString());
                        anagramList.Add(temp);
                    }
                    anagramList.Add(s + c);
                 

                }
            }

            return anagramList.ToArray();
        }


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

            //int count = Convert.ToInt32(System.Console.ReadLine());
            //int[] numbers = new int[count];

            //if (count > 0 && count < 100)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        numbers[i] = Convert.ToInt32(System.Console.ReadLine());
            //    }
                
            //}

            Program p = new Program();

            //System.Console.WriteLine("The result of calculation of {0}", p.Summation(numbers));

       

            string input = System.Console.ReadLine();

            //string[] output = p.combination(input);

            string[] output = p.Anagram(input);

            foreach (string s in output)
            {
                if (s[0].Equals(s[s.Length - 1]) && s[1].Equals(s[s.Length - 2]) && s[2].Equals(s[s.Length - 3]) && s[3].Equals(s[s.Length - 5]))
                    System.Console.WriteLine(s);
            }

            System.Console.ReadLine();
        }
    }


interface Shape
    {
        int getArea();

    }

    class Rectangle : Shape
    {

        private int _height;
        private int _width;
        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public int getArea()
        {
            return _height * _width;
        }

    }

    class Triangle : Shape
    {

        private int _height;
        private int _width;
        public Triangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public int getArea()
        {
            return (int)((_height * _width) / 2);
        }

    }

    class Circle : Shape
    {

        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;

        }

        public int getArea()
        {
            return (int)3.14 * _radius * _radius;
        }

    }


}
