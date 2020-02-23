using System;

namespace lambdaPjt
{
    class LambdaEx
    {
        static void Main(string[] args)
        {
            // Delegate
            Anonymouse anonymouse = new Anonymouse();

            Calculator cal1 = new Calculator(anonymouse.DoAddition);
            Console.WriteLine($"cal1(10, 30) : {cal1(10, 30)}");

            cal1 = new Calculator(anonymouse.DoSubtraction);
            Console.WriteLine($"cal1(10, 30) : {cal1(10, 30)}");

            Console.WriteLine();

            // Anonymouse method
            Calculator cal2 = delegate (int n1, int n2)
            {
                return n1 + n2;
            };
            Console.WriteLine($"cal2(10, 30) : {cal2(10, 30)}");

            cal2 = delegate (int n1, int n2)
            {
                return n1 - n2;
            };
            Console.WriteLine($"cal2(10, 30) : {cal2(10, 30)}");

            Console.WriteLine();

            // Lambda
            Calculator cal3 = (int n1, int n2) => n1 + n2;
            Console.WriteLine($"cal3(10, 30) : {cal3(10, 30)}");

            cal3 = (int n1, int n2) => n1 - n2;
            Console.WriteLine($"cal3(10, 30) : {cal3(10, 30)}");

            Console.WriteLine();

            CalculatorPrint calculatorPrint = (int n1, int n2) =>
            {
                Console.WriteLine($"n1 + n2 : {n1 + n2}");
                Console.WriteLine($"n1 - n2 : {n1 - n2}");
                Console.WriteLine($"n1 * n2 : {n1 * n2}");
                Console.WriteLine($"n1 / n2 : {n1 / n2}");
                Console.WriteLine($"n1 / n2 : {Math.Round((double)n1 / n2, 2)}");
                Console.WriteLine($"n1 % n2 : {n1 % n2}");
            };
            calculatorPrint(10, 30);

            Console.WriteLine();

            // Func, Action 대리자
            // Func 반환값 O
            Func<int> func0 = () => 0;
            Console.WriteLine($"func0() : {func0()}");

            Func<int, int> func1 = (n1) => n1;
            Console.WriteLine($"func1(10) : {func1(10)}");

            Func<int, int, int> func2 = (n1, n2) => n1 + n2;
            Console.WriteLine($"func2(10, 30) : {func2(10, 30)}");

            Func<int, int, int, int> func3 = (n1, n2, n3) => n1 + n2 + n3;
            Console.WriteLine($"func3(10, 30, 50) : {func3(10, 30, 50)}");

            Func<int, int, int, int> func4 = (n1, n2, n3) =>
            {
                int res = n1 + n2 + n3;
                return res;
            };
            Console.WriteLine($"func4(10, 30, 50) : {func4(10, 30, 50)}");

            // Action 반환값  X
            Action action0 = () => Console.WriteLine($"{0}");
            action0();

            Action<int> action1 = (n1) => Console.WriteLine($"n1: {n1}");
            action1(10);

            Action<int, int> action2 = (n1, n2) => Console.WriteLine($"n1 + n2 : {n1 + n2}");
            action2(10, 30);

            Action<int, int, int> action3 = (n1, n2, n3) => Console.WriteLine($"n1 + n2 + n3 : {n1 + n2 + n3}");
            action3(10, 30, 50);

            Action<int, int, int> action4 = (n1, n2, n3) =>
            {
                int res = n1 + n2 + n3;
                Console.WriteLine($"n1 + n2 + n3 : {res}");
            };
            action4(10, 30, 50);
        }
    }
}
