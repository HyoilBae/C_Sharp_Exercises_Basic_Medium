using System;

namespace exceptionPjt
{
    class ExceptionEx
    {
        static void Main(string[] args)
        {
            // Exception
            Calculator calculator = new Calculator();

            Console.Write("첫 번째 숫자를 입력하세요. ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("두 번째 숫자를 입력하세요. ");
            int secondNum = int.Parse(Console.ReadLine());

            calculator.addition(firstNum, secondNum);
            calculator.subtraction(firstNum, secondNum);
            calculator.multiplication(firstNum, secondNum);
            calculator.divisiton(firstNum, secondNum);

            Console.WriteLine();

            // try ~ catch
            TryCatch tryCatch = new TryCatch();

            try
            {
                tryCatch.printNumbers(3);
                Console.WriteLine();

                tryCatch.printNumbers(7);
                Console.WriteLine();

                tryCatch.printNumbers(2);
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException e1)
            {
                Console.WriteLine($"e.Message : {e1.Message}");
            }

            Console.WriteLine();

            // throw & finally
            DatabaseTask databaseTask = new DatabaseTask();

            try
            {
                databaseTask.connectDatabase();
                databaseTask.queryDatabase();

            }
            catch (NullReferenceException e2)
            {
                Console.WriteLine($"e.Message : {e2.Message}");
            }
            finally
            {
                databaseTask.closeDatabase();
            }

            Console.WriteLine();

            // Custom Exception
            GuGuDanPrint guGuDanPrint = new GuGuDanPrint();

            try
            {
                guGuDanPrint.setUserNumber();
                guGuDanPrint.printGuGuDan();
            }
            catch(CustomException e3)
            {
                Console.WriteLine($"e.Message : {e3.Message}");
            }

        }
    }
}
