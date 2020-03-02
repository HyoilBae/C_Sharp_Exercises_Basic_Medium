using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58HowManyIntegersNeededToCompleteRange
{
    class Program
    {
        static void intCountArr(int[] arr)
        {
            int count = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == numbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static int consecutive_array(int[] input_Array)
        {
            Array.Sort(input_Array);
            int ctr = 0;
            for (int i = 0; i < input_Array.Length - 1; i++)
            {
                ctr += input_Array[i + 1] - input_Array[i] - 1;
            }
            return ctr;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(consecutive_array(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(consecutive_array(new int[] { 0, 10 }));
            //Random random = new Random();
            //int[] numbers = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //int[] intArr = new int[10];
            //for (int i = 0; i < 5; i++)
            //{
            //    int randomNumber = random.Next(1, 10);
            //    intArr[i] = randomNumber;

            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] intArr = { 1, 3, 4, 7, 9 };

            //int intCount = intArr.Length;
            //Console.WriteLine(intCount);

            //Console.Write(string.Join(", ", intArr));

            //intCountArr(intArr);
            //Console.WriteLine();


        }
    }
}
