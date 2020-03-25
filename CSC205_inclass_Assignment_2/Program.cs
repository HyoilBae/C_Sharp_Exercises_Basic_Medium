using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
 * This assignment show you examples of how to use while and for loops.
 * 
 * 
 */

namespace CSC205_inclass_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------while #1----------------------------------------
            //reference website https://www.w3schools.com/cs/cs_while_loop.asp
            //this while loops will show you how to print out numbers from 0 to 4.
            //first, you need to set a value to integer i as a start number
            Console.WriteLine("-------While Example #1-------");
            int i = 0;
            //this while loops will continue to work until this condition (i < 5) is False.
            while (i < 5)
            {
                //This will print out i 
                Console.Write(i+ ", ");

                //This will + 1 to cunrrent i value.
                i++;
            }
            Console.WriteLine("\n"); //this will make a new line space between each examples
            //Result will be 0, 1, 2, 3 ,4

            //--------------------------------------while #2----------------------------------------
            //reference website https://www.dotnetperls.com/while
            //this while loop will print out string by using Console.WriteLine function until the condition (value > 5) is true.
            Console.WriteLine("-------While Example #2-------");
            int index = 0;
            // Continue looping infinitely until internal condition is met.
            while (true)
            {
                int value = ++index;
                // Check to see if limit is hit.
                if (value > 5)
                {
                    Console.WriteLine("While-loop break");
                    break;
                }
                // Write to the screen on each iteration.
                Console.WriteLine("While-loop statement");
            }
            Console.WriteLine("\n"); //this will make a new line space between each examples
            //output will be While-loop statement
            //While - loop statement
            //While - loop statement
            //While - loop statement
            //While - loop statement
            //While - loop break



            //--------------------------------------for #1----------------------------------------
            //reference website: https://www.w3schools.com/cs/cs_for_loop.asp
            //This is for loops that will print out same number as the first while loop
            //The output will be 0, 1, 2, 3, 4 
            Console.WriteLine("-------For Example #1-------");
            for (int j = 0; j < 5; j++) //initial j value, it will keep looping until the condition (j < 5) is false, and add 1 every loop.
            {
                //it will print i value
                Console.Write(j+ ", ");
            }
            Console.WriteLine("\n"); //this will make a new line space between each examples


            //--------------------------------------for #2----------------------------------------
            //reference website: https://www.dotnetperls.com/for
            //This for loope will print out i value until the condition (k >=0) is False.
            Console.WriteLine("-------For Example #2-------");
            for (int k = 10 - 1; k >= 0; k--) //initiate k value as 10-1, condition statement, and a decreament after going through each for loop
            {
                Console.Write(k + ", "); //print out k value
            }
            //output will be countind down from 9 to 0; 9, 8, 7 , 6, 5, 4, 3, 2, 1
        }
    }
}
