using System;

namespace operatorPjt
{
    class OperatorEx
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            // 산술 연산자
            Console.WriteLine($"a + b : {a + b}");
            Console.WriteLine($"a - b : {a - b}");
            Console.WriteLine($"a * b : {a * b}");
            Console.WriteLine($"a / b : {(double)a / b}");
            Console.WriteLine($"a % b : {a % b}");

            Console.WriteLine("\n");

            // 자동 증가/감소 연산자
            Console.WriteLine($"a++ : {a++}");
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"++a : {++a}");

            Console.WriteLine($"b++ : {b++}");
            Console.WriteLine($"b : {b}");
            Console.WriteLine($"++b : {++b}");

            Console.WriteLine("\n");

            // 관계 연산자
            Console.WriteLine($"a > b : {a > b}");
            Console.WriteLine($"a >= b : {a >= b}");
            Console.WriteLine($"a < b : {a < b}");
            Console.WriteLine($"a <= b : {a <= b}");
            Console.WriteLine($"a == b : {a == b}");
            Console.WriteLine($"a != b : {a != b}");

            Console.WriteLine("\n");

            // 논리 연산자
            bool c = true;
            bool d = false;
            Console.WriteLine($"c && d : {c && d}");
            Console.WriteLine($"c || d : {c || d}");

            Console.WriteLine("\n");

            // 할당 연산자
            byte bNum = 123;
            int iNum = 12345;
            long longNum = 1234567;
            Console.WriteLine($"bNum : {bNum}");
            Console.WriteLine($"iNum : {iNum}");
            Console.WriteLine($"longNum : {longNum}");

            Console.WriteLine("\n");

            // 조건 연산자
            int e = 100;
            string str1 = e == 100 ? "O" : "X";
            Console.WriteLine($"str1 : {str1}");

            string str2 = e == 200 ? "O" : "X";
            Console.WriteLine($"str2 : {str2}");
        }
    }
}
