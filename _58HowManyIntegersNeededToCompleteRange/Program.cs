using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58HowManyIntegersNeededToCompleteRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] intArr = new int[] { random.Next(1, 10) };

            int intCount = intArr.Length;
            Console.WriteLine(intCount);


        }
    }
}
