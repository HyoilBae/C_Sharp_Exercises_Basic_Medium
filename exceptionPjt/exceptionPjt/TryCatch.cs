using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionPjt
{
    class TryCatch
    {

        private List<int> numbers;

        public TryCatch()
        {
            Console.WriteLine("=== TryCatch CONSTRUCTOR ===");

            init();
        }

        private void init()
        {
            numbers = new List<int>();
            for (int i = 0; i < 5; i++)
                numbers.Add(i);
        }

        public void printNumbers(int endIndex)
        {
            for (int i = 0; i <= endIndex; i++)
            {
                Console.WriteLine($"numbers[{i}] : {numbers[i]}");
            }
        }
    }
}
