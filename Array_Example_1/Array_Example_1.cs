using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb_11_2020
{
    class Array_Example_1
    {
        static void Main(string[] args)
        {
            /**
             * 
             * Reference: https://www.w3resource.com/csharp-exercises/array/index.php
             * This will write a program to store elements in an array and print it.
             * 
             * 
             */

            //Get a blarnk array size or 10
            int[] arr = new int[10];
            //declare i integer as a variable
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            //Ask user to put 10 elements
            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                //save user-input numbers in arr[i] as converting string to int value
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //print elemetns in the array
            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }
    }
    
}
