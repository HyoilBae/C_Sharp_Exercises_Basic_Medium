using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            //Console.WriteLine("Enter 3 numbers : ");
            //int numberOne = int.Parse(Console.ReadLine());
            //int numberTwo = int.Parse(Console.ReadLine());
            //int numberThree = int.Parse(Console.ReadLine());

            //numbers[0] = numberOne;
            //numbers[1] = numberTwo;
            //numbers[2] = numberThree;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter your {i+1} number : ");
                int userNumber = int.Parse(Console.ReadLine());
                numbers[i] = userNumber;
            }

            Console.Write("Your input numbers are : ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //SortNumber(numbers);

            Console.WriteLine("The biggest number : "+ Math.Max(numbers[0], Math.Max(numbers[1], numbers[2])));
            Console.WriteLine("The smallest number : " + Math.Min(numbers[0], Math.Min(numbers[1], numbers[2])));
            


            //SortNumber(numberOne, numberTwo, numberThree);

        }

        static void SortNumber(int[] arr)
        {
            int tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int compare_i= 0; compare_i < arr.Length - 1; compare_i++)
                {
                    if (arr[i] > arr[compare_i])
                    {
                        tmp = arr[compare_i];
                        arr[compare_i] = arr[i];
                        arr[i] = tmp;
                    }
                }


            }
                Console.Write("Your number in order : ");
                foreach (int a in arr)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"The smallest number is {arr[arr.Length - 1]}");
                Console.WriteLine($"The biggest number is {arr[0]}");
        }
        //static void SortNumber(int a, int b, int c)
        //{
        //    int tmp;
        //    if (a > b)
        //    {
        //        tmp = b;
        //        b = a;
        //        a = tmp;
        //        if (a > c)
        //        {
        //            tmp = a;
        //            a = c;
        //            c = tmp;
        //            Console.WriteLine($"{a} is the biggest, {c} is the smallest");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{c} is the biggest, {b} is the smallest" );
        //        }
        //    }
        //    else
        //    {
        //        if (b > c)
        //        {
        //            tmp = c;
        //            c = b;
        //            b = tmp;
        //            Console.WriteLine($"{b} is the biggest, {a} is the smallest");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{c} is the biggest, {a} is the smallest");
        //        }
        //    }
        //}
    }
}
