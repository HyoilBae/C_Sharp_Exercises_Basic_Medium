using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionPjt
{
    class CustomException : Exception
    {

        public CustomException()
        {
            Console.WriteLine("=== CustomException CONSTRUCTOR ===");
        }

        public CustomException(string message) : base(message)
        {
            Console.WriteLine("=== CustomException(string message) CONSTRUCTOR ===");
        }

    }
}
