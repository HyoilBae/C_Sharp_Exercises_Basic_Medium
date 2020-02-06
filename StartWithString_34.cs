using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartWithString_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello how are you?";

            //while (test.StartsWith("Hello"))
            //{
            //    Console.WriteLine(true);
            //}

            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }
    }
}
