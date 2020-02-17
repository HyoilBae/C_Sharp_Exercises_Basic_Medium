using System;

namespace VariableEx
{
    class Variable
    {
        static void Main(string[] args)
        {
            // 변수 선언 및 초기화
            int myScore;
            myScore = 100;
            Console.WriteLine("myScore : " + myScore);

            // 변수 선언 및 초기화
            int comScore = 1000;
            Console.WriteLine("comScore : " + comScore);
            
            // 변수 데이터 변경
            myScore = 110;
            Console.WriteLine("myScore : " + myScore);

            // 정수형 데이터
            byte iByetNum = 10;
            byte jByteNum = 100;
            Console.WriteLine("iByetNum, jByteNum : " + iByetNum + ", " + jByteNum);

            int iIntNum = 10;
            int jIntNum = 20;
            Console.WriteLine("iIntNum, jIntNum : " + iIntNum + ", " + jIntNum);

            iIntNum = -10;
            jIntNum = -20;
            Console.WriteLine("iIntNum, jIntNum : " + iIntNum + ", " + jIntNum);

            long ilongNum = -25687452684125;
            long jlongNum = 36521589641256;
            Console.WriteLine("ilongNum, jlongNum : " + ilongNum + ", " + jlongNum);

            // 실수형 데이터
            float iFloatNum = 3.14f;
            float jFloatNum = -3.14f;
            Console.WriteLine("iFloatNum, jFloatNum : " + iFloatNum + ", " + jFloatNum);

            double iDoubleNum = 3.14159;
            double jDoubleNum = -3.14159;
            Console.WriteLine("iDoubleNum, jDoubleNum : " + iDoubleNum + ", " + jDoubleNum);
        }
    }
}
