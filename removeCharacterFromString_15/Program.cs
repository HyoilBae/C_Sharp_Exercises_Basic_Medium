using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeCharacterFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your TestData: ");
            string testData = Console.ReadLine();
            char[] testDataChar = testData.ToCharArray();

            Console.WriteLine("Enter the character you want to get rid of from TestData: ");
            char character = char.Parse(Console.ReadLine());

            foreach (char letter in testDataChar)
            {
                if (letter == character)
                {
                    continue;
                }
                else
                {
                    Console.Write(letter);
                }
            }
            Console.Write("\n");

            //Book Solution
            string str = "w3resource";
            int n = 1;
            Console.WriteLine(remove_char(str, n));
        }


        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
