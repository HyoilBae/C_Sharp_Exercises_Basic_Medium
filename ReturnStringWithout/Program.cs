using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnStringWithout
{
    class Program
    {
        static void Main(string[] args)
        {
            String testString = "PHP Tutorial"; //output should be P Tutorial
            PrintWithOut(testString);

            //Console.WriteLine("Enter your word : ");
            //String userInput = Console.ReadLine();

            //Console.WriteLine("Enter the letter you want to remove from your input word : ");
            //String userInputLetter = Console.ReadLine();

            //PrintWithOut(userInput, userInputLetter);

        }

        static void PrintWithOut(string userStr, string userLetter)
        {
            int letterPosition = userStr.IndexOf($"{userLetter}");
            //Console.WriteLine(letterPosition);

            String userSubStr = userStr.Substring(letterPosition, 2);
            //Console.WriteLine(userSubStr);

            String userRemoveStr = userStr.Remove(letterPosition, 2);
            Console.WriteLine(userRemoveStr);
        }

        static void PrintWithOut(string str)
        {
            int letterPosition = str.IndexOf("H");
            String strRemove = str.Remove(letterPosition, 2);
            Console.WriteLine($"Original word is {str}");
            Console.WriteLine($"After you've removed HP : {strRemove}");
        }
    }
}
