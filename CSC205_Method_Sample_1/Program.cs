using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Creating_Methods
{
    class Program
    {

        /*
         * 
         * Reference: https://www.w3resource.com/csharp-exercises/function/csharp-function-exercise-1.php
         * This function will pop up greeting messages 
         * 
         * 
         */
        static void Main(string[] args)
        {
            //calling welcome method
            welcome();
            //calling HaveAnice method
            HaveAnice();
        }

        //This methods will print out Welcome Friends!
        public static void welcome()
        {
            Console.WriteLine("Welcome Friends!");
        }

        //This methods will print out welcome Friends!
        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }

    }
}
