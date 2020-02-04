using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInString_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Write a C# Sharp Program to display the following pattern using the alphabet.";

            string[] arrayTest = test.Split(' ');
            
            
            string longestStr = " ";
            for (int i = 0; i < arrayTest.Length; i++)
            {
                if (arrayTest[i].Length > longestStr.Length)
                {
                    longestStr = arrayTest[i];
                }
            }
            Console.WriteLine(test);
            Console.WriteLine("The longest word in this sentence is : {0}", longestStr);



            //char[] charTest = test.ToCharArray();
            //foreach (char c in charTest)
            //{
            //    Console.Write(c);
            //}
            //for (int i = 0; i < charTest.Length; i++)
            //{
            //    Console.Write(charTest[0]);
            //}

        }
    }
}
