using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_4lowerCase_UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string : ");
            string userInput = Console.ReadLine();
            caseChanger(userInput);
        }

        static void caseChanger(string str)
        {
            if (str.Length < 4)
            {
                Console.WriteLine(str.ToUpper());
            }
            else if (str.Length >= 4)
            {
                string first4 = str.Substring(0, 4);
              
                Console.WriteLine(first4.ToLower() + str.Substring(4, str.Length - 4));
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
