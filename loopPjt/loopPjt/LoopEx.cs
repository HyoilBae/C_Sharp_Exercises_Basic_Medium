using System;

namespace loopPjt
{
    class LoopEx
    {
        static void Main(string[] args)
        {
            Console.Write("\nfor문\n");

            // for문
            int sum = 0;

            for (int i = 0; i < 11; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine($"sum: {sum}");


            // 특정 구구단 출력
            Console.Write("\n특정 구구단 출력\n");

            int gugudan = 3;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", gugudan, i, (gugudan * i));
            }

            Console.WriteLine();


            // 사용자가 입력한 구구단 출력
            Console.Write("\n사용자가 입력한 구구단 출력\n");

            Console.WriteLine("원하는 구구단을 입력하세요.");
            int userInputData = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", userInputData, i, (userInputData * i));
            }

            Console.WriteLine();


            // 구구단 전체 출력 - I
            Console.Write("\n구구단 전체 출력 - I\n");

            Console.WriteLine("구구단 전체를 출력합니다. (세로)");
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                }
                Console.WriteLine();
            }


            // 구구단 전체 출력 - II
            Console.Write("\n구구단 전체 출력 - II\n");

            Console.WriteLine("구구단 전체를 출력합니다. (가로)");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write("{0} * {1} = {2}\t", j, i, (j * i));
                }
                Console.WriteLine();
            }

            Console.Write("\nforeach문\n");

            string[] strArr = { "H", "E", "L", "L", "O" };
            Console.Write($"strArr[0] : {strArr[0]}");
            Console.Write($"strArr[1] : {strArr[1]}");
            Console.Write($"strArr[2] : {strArr[2]}");
            Console.Write($"strArr[3] : {strArr[3]}");
            Console.WriteLine($"strArr[4] : {strArr[4]}");

            foreach (string str in strArr)
            {
                Console.WriteLine($"str : {str}");
            }

            Console.Write("\nwhile문\n");

            int iNum = 1;
            while (iNum <= 9)
            {
                Console.WriteLine($"2 * {iNum} = {2 * iNum}");
                iNum++;
            }

            Console.Write("\nwhile문을 이용한 구구단 출력\n");

            int iGuguNum = 1;
            int jGuguNum = 2;

            while (iGuguNum <= 9)
            {
                while (jGuguNum <= 9)
                {
                    Console.Write($"{jGuguNum} * {iGuguNum} = {jGuguNum * iGuguNum}\t");
                    jGuguNum++;
                }
                Console.WriteLine();
                jGuguNum = 2;
                iGuguNum++;
            }

            Console.Write("\ndo ~ while문\n");

            int kNum = 10;

            do
            {
                Console.WriteLine($"kNum = {kNum}");
            }
            while (kNum < 0);

            Console.Write("\nbreak, continue\n");

            // break
            for (int i = 1; i < 10; i++)
            {
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            // continue
            for (int j = 0; j < 10; j++)
            {
                if (j % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

            Console.Write("\n사용자가 입력한 구구단을 제외한 전체구구단 출력\n");

            int userData = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    if (j == userData) continue;
                    Console.Write($"{j} * {i} = {j * i}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
