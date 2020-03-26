using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolZZakGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int conNum = random.Next(1, 3);

            Console.WriteLine("1. Odd | 2. Even");
            int userInput = int.Parse(Console.ReadLine());

            if (conNum%2 == 0) //when conNum is 2
            {
                if (userInput == 1)
                {
                    Console.WriteLine("You lost");
                }
                else
                {
                    Console.WriteLine("You won");
                }
            }
            else //when conNum is 1
            {
                if (userInput == 1)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }

            Console.WriteLine($"conNum is {conNum}");
            Console.WriteLine($"userInput is {userInput}");
        }
    }
}
