using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_string_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string exString1 = "aac1d1caa";
            string exString2 = "abcd";
            palindromeCheck(exString1);
            palindromeCheck(exString2);
        }

        static void palindromeCheck(string str)
        {
          
            char[] charStr = str.ToCharArray();
            char[] reversedCharStr = charStr.Reverse().ToArray();
            Console.Write(string.Join(", ", charStr));
            Console.WriteLine();
            Console.Write(string.Join(", ", reversedCharStr));
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (charStr[i] == reversedCharStr[i])
                    Console.WriteLine(true);
            }
            
        }
    }
}
