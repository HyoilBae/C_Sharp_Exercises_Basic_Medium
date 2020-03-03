using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TwoSum_Same_Triple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number :");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number :");
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum == secondNum)
            {
                Console.WriteLine((firstNum + secondNum) * 3);
            }
            else
            {
                Console.WriteLine((firstNum + secondNum));
            }

            int result = test(firstNum, secondNum);
            Console.WriteLine(result);
        }
        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
