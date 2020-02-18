using System;

namespace methodPjt
{
    class MethodEx
    {
        static void Main(string[] args)
        {
            // 메서드(Method)란?, 메서드 문법 구조
            PrintIntro("Hello~");

            // 메서드 호출
            int userData = int.Parse(Console.ReadLine());
            printNationalGreeting(userData);

            // 매개 변수
            int result = add(10, 20);
            Console.WriteLine($"result : {result}");

            Console.WriteLine("Please input data format : integer integer string(operator)");

            Console.Write("input first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("input operator : ");
            string oper = Console.ReadLine();

            // return
            double res = calculator(num1, num2, oper);
            Console.WriteLine($"{num1} {oper} {num2} = {res}");

            // 메서드 오버로딩
            PrintIntroOverloading("Hello");
            PrintIntroOverloading("Hello ", "World");

            int printSumResult = PrintSum(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"printSumResult : {printSumResult}");

            Console.Write("input width : ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("input height : ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("0: Squre, 1:Triangle");
            Console.Write("input shape : ");
            int shape = int.Parse(Console.ReadLine());

            double getAreaResult = GetArea(width, height, shape);
            Console.WriteLine($"getAreaResult : {getAreaResult}");
        }

        public static void PrintIntro(string str)
        {
            Console.WriteLine(str);
        }

        public static void printNationalGreeting(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("안녕하세요.");
                    break;

                case 2:
                    Console.WriteLine("Hello.");
                    break;

                case 3:
                    Console.WriteLine("的大衣.");
                    break;
                default:
                    Console.WriteLine("Hello~");
                    break;
            }
        }

        public static int add(int i, int j)
        {
            int sum = i + j;
            return sum;
        }

        public static double calculator(int i, int j, string o)
        {
            double result = 0.0;

            switch (o)
            {
                case "+":
                    result = (double)i + j;
                    break;

                case "-":
                    result = (double)i - j;
                    break;

                case "*":
                    result = (double)i * j;
                    break;

                case "/":
                    result = (double)i / j;
                    break;
            }

            return result;
        }

        public static void PrintIntroOverloading(string str1)
        {
            Console.WriteLine(" --- START --- PrintIntro(string str1)");
            Console.WriteLine($"str1 : {str1}");
        }

        public static void PrintIntroOverloading(string str1, string str2)
        {
            Console.WriteLine(" --- START --- PrintIntro(string str1, string str2)");
            Console.WriteLine($"str1 : {str1}");
            Console.WriteLine($"str2 : {str2}");
        }

        public static int PrintSum(params int[] args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                sum = sum + args[i];
            }

            return sum;
        }

        public static double GetArea(double d1, double d2, int shape)
        {
            double res = 0.0;

            switch (shape)
            {
                case 0:
                    res = d1 * d2;
                    break;

                case 1:
                    res = (d1 * d2) / 2;
                    break;
            }
            return res;
        }
    }
}
