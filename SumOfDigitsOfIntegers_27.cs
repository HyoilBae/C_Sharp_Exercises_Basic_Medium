using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsOfIntegers
{
    class SumOfDigitsOfIntegers_27
    {
        static void Main(string[] args)
        {
            int userInt = Convert.ToInt32(Console.ReadLine());
            sumDigits(userInt);

            //string userInput = Console.ReadLine();
            //sumDigits(userInput);

            //char[] charUserInput = userInput.ToCharArray();
            //sumDigits(charUserInput);
        }

        public static void sumDigits(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += (a % 10);
                a /= 10;
            }
            Console.WriteLine(sum);
        }

        //public static void sumDigits(char[] arrChar)
        //{
        //    int sum = 0;
        //    foreach (char c in arrChar)
        //    {
        //        Console.WriteLine(c);
        //        int intC = Convert.ToInt32(c);
        //        sum = sum + c;
        //    }
        //    Console.WriteLine(sum);
        //}

        //public static void sumDigits(string str)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        Console.WriteLine(str[i]);
        //        int strInt = Convert.ToInt32(str[i]);
        //        sum = sum + strInt;
        //    }
        //    Console.WriteLine(sum);
        //}
    }
}
