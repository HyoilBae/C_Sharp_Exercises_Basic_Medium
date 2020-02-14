using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Method_Sample_2
{
    class Program
    {
        /*
        * 
        * Reference: https://www.w3resource.com/csharp-exercises/function/csharp-function-exercise-1.php
        * This function will create a funtion for the sum of two numbers
        * 
        * 
        */
        static void Main(string[] args)
        {
            //Ask user input two numbers and covert those string numers to int numbers
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            //calling methods with using two input numbers
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
        }

        //This method will calculate the sum of two input numbers with two int number parameters
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

    }
}
