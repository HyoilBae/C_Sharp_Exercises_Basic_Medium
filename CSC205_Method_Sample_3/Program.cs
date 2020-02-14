using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Method_Sample_3
{
    class Program
    {
        /*
         * 
         * Reference: https://www.w3resource.com/csharp-exercises/function/csharp-function-exercise-4.php
         * This function is to count number of spaces in a string
         * 
         */
        static void Main(string[] args)
        {
            //Ask user enter a string
            Console.Write("Please input a string : ");
            string str2 = Console.ReadLine();
            //This will call the methods and show the original string and the count of spaces in the string
            Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
        }

        //Method that will count space in the string with a parameter of strig str
        public static int SpaceCount(string str)
        {
            //set up spacing count as 0 
            int spcBetweenStr = 0;
            string str1;
            //using for loop to go thought each character in the string to check if it's string or not
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                //once space is found count + 1 to spacing count
                if (str1 == " ")
                    spcBetweenStr++;
            }
            //return spacingcount value
            return spcBetweenStr;
        }
    }
}
