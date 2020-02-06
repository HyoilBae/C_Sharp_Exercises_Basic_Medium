using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnLast4Chars_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your punch line please");
            //string testString = "The quick borwn fox jumps over the lazy dog.";
            string testString = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write(testString.Substring((testString.Length -4), 4));
            }
        }
    }
}
