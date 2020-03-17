using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Two_Integers_return_True_30_or_Sum30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number :");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number :");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(thirtyOrWhat(firstNum, secondNum));
        }

        static bool thirtyOrWhat(int a, int b)
        {
            if (a == 30 || b == 30 || a+b ==30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool test(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }
    }
}
