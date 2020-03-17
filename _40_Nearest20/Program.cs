using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Nearest20
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = 15;
            int secondInput = 12;
            nearest20(firstInput, secondInput);

            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }

        static void nearest20(int a, int b)
        {
            
            if ((20 - a) > (20 - b))
            {
                Console.WriteLine(b);
            }
            else if ((20 - a) < (20 - b))
            {
                Console.WriteLine(a);
            }
            else if ((20 - a) == (20 - b))
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("");
            }
        
        }
    }
}
