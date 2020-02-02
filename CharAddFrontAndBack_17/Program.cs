using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAddFrontAndBack_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine(AddFandB(sentence));
        }

        static string AddFandB(string str)
        {
            return str.Substring(0, 1) + str + str.Substring(0, 1);
        }
    }
}
