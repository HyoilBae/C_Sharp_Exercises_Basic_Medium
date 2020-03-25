using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSpacesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            spaceCounting(userInput);
           
        }
        

        static void spaceCounting(string str)
        {
            string spaceStr = " ";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                string ifSpace = str.Substring(i, 1);
                if (ifSpace == spaceStr)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
