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
            //PrintWithOut(testString);
            letterCombine(testString);

            //Console.WriteLine("Enter your word : ");
            //String userInput = Console.ReadLine();

            //Console.WriteLine("Enter the letter you want to remove from your input word : ");
            //String userInputLetter = Console.ReadLine();

            //PrintWithOut(userInput, userInputLetter);

        }

        static void PrintWithOut(string userStr, string userLetter)
        {
            if (userStr.Length > 0 && userLetter.Length > 0)
            {

            int letterPosition = userStr.IndexOf($"{userLetter}");
            //Console.WriteLine(letterPosition);

            String userSubStr = userStr.Substring(letterPosition, 2);
            //Console.WriteLine(userSubStr);

            String userRemoveStr = userStr.Remove(letterPosition, 2);
            Console.WriteLine(userRemoveStr);
            }
        }

        static void PrintWithOut(string str)
        {
            if (str.Length > 0)
            {

            int letterPosition = str.IndexOf("H");
            String strRemove = str.Remove(letterPosition, 2);
            Console.WriteLine($"Original word is {str}");
            Console.WriteLine($"After you've removed HP : {strRemove}");
            }
        }

        static void letterCombine(string str)
        {
            if (str.Length > 0)
            {
                Console.Write(str[0]);
                Console.Write(str[1]);
                Console.WriteLine("frst letter is :" + str[0] + " second letter is :" + str[1]);
                Console.WriteLine();

                for (int i = 0; i < 2; i++)
                {
                    Console.Write(str[i]);
                }
                Console.WriteLine();
                //Console.WriteLine($"The combined word of first and second letter of \"{str}\" : {firstAndSecond}");

            }
        }

       
    }
}
