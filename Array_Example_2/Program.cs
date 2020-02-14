using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 
             * Reference: https://www.w3resource.com/csharp-exercises/array/index.php
             * This program is to read n number of values in an array and display it in revers order.
             * 
             * 
             */

            //declare int i and n as variables
            int i, n;
            //get a int array size of 100
            int[] a = new int[100];

            Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
            Console.Write("------------------------------------------------------------------------\n");

            //asking user how many elements will be in the array
            Console.Write("Input the number of elements to store in the array :");
            //user input will decide the number of integers
            n = Convert.ToInt32(Console.ReadLine());

            //user input random numbers as number of elements he choose
            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //showing what numbers in the array
            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            
            //showing number in the array in reverse order
            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }
    }
    
}
