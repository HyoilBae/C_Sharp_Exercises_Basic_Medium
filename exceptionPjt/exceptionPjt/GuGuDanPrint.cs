using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionPjt
{
    class GuGuDanPrint
    {

        private int userNumber;

        public GuGuDanPrint()
        {
            Console.WriteLine("=== GuGuDanPrint CONSTRUCTOR ===");
        }


        public void printGuGuDan()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{userNumber} * {i} = {userNumber * i}");
            }
        }

        public void setUserNumber()
        {
            Console.Write("0보다 큰 정수를 입력하세요. ");
            int userInputNum = int.Parse(Console.ReadLine());

            if (userInputNum <= 0)
            {
                throw new CustomException("0보다 작거나 같은 정수를 입력했습니다.");
            }
            else
            {
                Console.WriteLine($"사용자가 입력한 정수는 {userInputNum}입니다.");
                userNumber = userInputNum;
            }
        }

    }
}
