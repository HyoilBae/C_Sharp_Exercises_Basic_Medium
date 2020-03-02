using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58HowManyIntegersNeededToCompleteRange
{
    class Program
    {
        static void intCount(int[] arr)
        {

        }
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int[] numbers = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //int[] intArr = new int[10];
            //for (int i = 0; i < 5; i++)
            //{
            //    int randomNumber = random.Next(1, 10);
            //    intArr[i] = randomNumber;

            //}

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] intArr = { 1, 3, 4, 7, 9 };

            int intCount = intArr.Length;
            Console.WriteLine(intCount);

            Console.Write(string.Join(", ", intArr));


        }
    }
}
