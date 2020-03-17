using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_immediatelyFollowedByTwoWW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string userInput = Console.ReadLine();

            Console.WriteLine(wCheck(userInput));
        }
        static bool wCheck(string str)
        {
            string firstTwo = str.Substring(0, 2);
            string theThird = str.Substring(2, 1);
            if (firstTwo == "ww" && theThird == "w")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool test(string str)
        {
            var ctr = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('w')) ctr++;
                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true;
            }
            return false;
        }
    }
}
