using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41WcharacterBetween1and3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string userInput = Console.ReadLine();
            //.WriteLine(userInput.Substring(1, 1));
            bool result = checkW(userInput);
            Console.WriteLine(result);

            //Console.Write("Input a string (conatins at least one 'w' char) : ");
            //string str = Console.ReadLine();
            //var count = str.Count(s => s == 'w');
            //Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            //Console.WriteLine(count >= 1 && count <= 3);
        }
    }
        static bool checkW(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str.Substring(i, 1) == "w") || (str.Substring(i, 1) == "W"))
                {
                    count += 1;
                }
                
            }
            if (count >= 1 && count <= 3)
            {
                //Console.WriteLine(true);
                return true;
            }
            else
            {
                //Console.WriteLine(false);
                return false;
            }

        }
    }
}
