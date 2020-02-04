using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = Convert.ToInt32(Console.ReadLine());
            int secondInt = Convert.ToInt32(Console.ReadLine());

            int result = twoSum(firstInt, secondInt);
            Console.WriteLine(result);
        }

        public static int twoSum(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
