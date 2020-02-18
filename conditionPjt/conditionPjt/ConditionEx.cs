using System;

namespace conditionPjt
{
    class ConditionEx
    {
        static void Main(string[] args)
        {
            Console.Write("\nif문\n");

            //if문
            int iNum = 10;
            int jNum = 20;

            if (iNum > jNum)
            {
                Console.WriteLine("iNum은 jNum보다 크다.");
            }

            if (iNum < jNum)
            {
                Console.WriteLine("iNum은 jNum보다 작다.");
            }

            if (iNum == jNum)
            {
                Console.WriteLine("iNum은 jNum보다 같다.");
            }

            Console.Write("\nif, if ~ else문\n");

            // if문을 이용한 성인 구분
            int adultAuth = int.Parse(Console.ReadLine());

            if (adultAuth >= 19)
            {
                Console.WriteLine("성인 입니다.");
            }

            if (adultAuth < 19)
            {
                Console.WriteLine("미성년자 입니다.");
            }

            if (adultAuth >= 19)
            {
                Console.WriteLine("성인 입니다.");
            }
            else
            {
                Console.WriteLine("미성년자 입니다.");
            }

            Console.Write("\nif ~ else if문\n");

            int userNum = int.Parse(Console.ReadLine());

            if (userNum > 0)
            {
                Console.WriteLine($"입력한 숫자 {userNum}는 양수 입니다.");
            }
            else if (userNum == 0)
            {
                Console.WriteLine($"입력한 숫자 {userNum}는 0 입니다.");
            }
            else if (userNum < 0)
            {
                Console.WriteLine($"입력한 숫자 {userNum}는 음수 입니다.");
            }

            Console.Write("\n홀/짝 게임\n");

            // 홀/짝 게임
            Random random = new Random();
            int comNum = random.Next(1, 3);

            Console.WriteLine("1. 홀수 \t 2. 짝수");
            int userData = int.Parse(Console.ReadLine());

            if (comNum % 2 == 0)
            {
                if (userData == 1)
                {
                    Console.WriteLine("오답");
                }
                else
                {
                    Console.WriteLine("정답");
                }
            }
            else
            {
                if (userData == 1)
                {
                    Console.WriteLine("정답");
                }
                else
                {
                    Console.WriteLine("오답");
                }
            }

            Console.WriteLine($"comNum = {comNum}");
            Console.WriteLine($"userData = {userData}");

            Console.Write("\nswitch문\n");

            Console.WriteLine("Please enter your country.");
            Console.WriteLine("1.한국 \t2.미국 \t3.중국");

            int userCountry = int.Parse(Console.ReadLine());

            switch (userCountry)
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
                    Console.WriteLine("Hello~.");
                    break;
            }
        }
    }
}
