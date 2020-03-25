using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_MultiDimensional_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Multidimensional Array Examples
             * Reference: https://moodle.stmartin.edu/mod/assign/view.php?id=529532
             * 
             */

            // Part A: create 2D array of strings.
            string[,] array = new string[,]
            {
            {"cat", "dog"},
            {"bird", "fish"},
            };
            // Part B: access (and print) values.
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            Console.WriteLine();

            //--------------------------------------------------------------------------
            string[,] codes = new string[,]
            {
            {"AA", "BB"},
            {"CC", "DD"}
            };

            // Get the upper bound.
            // ... Use for-loop over rows.
            for (int i = 0; i <= codes.GetUpperBound(0); i++)
            {
                string s1 = codes[i, 0];
                string s2 = codes[i, 1];
                Console.WriteLine("{0}, {1}", s1, s2);
            }
        }
    }
}
