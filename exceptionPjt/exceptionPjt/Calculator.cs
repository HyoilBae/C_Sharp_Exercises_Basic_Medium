using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionPjt
{
    class Calculator
    {
        public void addition(int n1, int n2)
        {
            Console.WriteLine($"덧셈 연산 결과 : {n1 + n2}");
        }

        public void subtraction(int n1, int n2)
        {
            Console.WriteLine($"뺄셈 연산 결과 : {n1 - n2}");
        }

        public void multiplication(int n1, int n2)
        {
            Console.WriteLine($"곱셈 연산 결과 : {n1 * n2}");
        }

        public void divisiton(int n1, int n2)
        {
            Console.WriteLine($"나눗셈 연산 결과 : {Math.Round((double)n1 / n2, 2)}");
        }
    }
}
