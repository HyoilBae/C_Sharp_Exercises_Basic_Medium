using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_HightestValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] intArray = new int[20];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1, 20);
            }

            Console.WriteLine(string.Join(", ", intArray));

            int biggestNumber = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (biggestNumber < intArray[i])
                {
                    biggestNumber = intArray[i];
                }
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
 