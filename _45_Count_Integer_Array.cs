using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Count_Integer_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] intArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArr[i] = random.Next(1, 10);
            }

            foreach (var item in intArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            arrCounter(intArr,random.Next(1, 10));

            //Console.WriteLine("\nInput an integer:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            //Console.WriteLine("Number of " + x + " present in the said array:");
            //Console.WriteLine(nums.Count(n => n == x));
        }

        static void arrCounter(int[] arr, int target)
        {
            //List<int> counter = new List<int>();
            int numInCounter = 0;
            

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    numInCounter++;
                }
            }
            Console.WriteLine($"This array has {target} | {numInCounter} times");
        }
    }
}
