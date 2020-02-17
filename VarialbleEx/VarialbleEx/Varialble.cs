using System;

namespace VarialbleEx
{
    class Varialble
    {
        static void Main(string[] args)
        {
            // 문자
            char charData1 = 'H';
            char charData2 = 'e';
            char charData3 = 'l';
            char charData4 = 'l';
            char charData5 = 'o';
            Console.WriteLine("charData1 : " + charData1);
            Console.WriteLine("charData2 : " + charData2);
            Console.WriteLine("charData3 : " + charData3);
            Console.WriteLine("charData4 : " + charData4);
            Console.WriteLine("charData5 : " + charData5);

            Console.Write(charData1);
            Console.Write(charData2);
            Console.Write(charData3);
            Console.Write(charData4);
            Console.WriteLine(charData5);

            // 문자열
            string strData1 = "Hello World";
            string strData2 = "Hello C#";
            string strData3 = "Hello Java";
            Console.WriteLine("strData1 : " + strData1);
            Console.WriteLine("strData2 : " + strData2);
            Console.WriteLine("strData3 : " + strData3);

            strData1 = "Good morning";
            strData2 = "Good afternoon";
            strData3 = "Good evening";
            Console.WriteLine("strData1 : " + strData1);
            Console.WriteLine("strData2 : " + strData2);
            Console.WriteLine("strData3 : " + strData3);

            Console.WriteLine("\n\n");

            // 아스키코드
            char ascA = 'A';
            char ascB = 'B';
            char ascC = 'C';
            Console.WriteLine("ascA : " + ascA);
            Console.WriteLine("ascB : " + ascB);
            Console.WriteLine("ascC : " + ascC);

            Console.WriteLine("(int)ascA : " + (int)ascA);
            Console.WriteLine("(int)ascB : " + (int)ascB);
            Console.WriteLine("(int)ascC : " + (int)ascC);

            Console.WriteLine("ascA + ascB + ascC : " + (int)(ascA + ascB + ascC));
            Console.WriteLine(ascA + ascB + ascC);

            char asc_a = 'a';
            char asc_b = 'b';
            char asc_c = 'c';
            Console.WriteLine("(int)asc_a : " + (int)asc_a);
            Console.WriteLine("(int)asc_b : " + (int)asc_b);
            Console.WriteLine("(int)asc_c : " + (int)asc_c);

            Console.WriteLine("\n\n");

            // 문자열(string) 관련 메서드
            string str = "Hello World!";
            int temNum = 0;

            Console.WriteLine("str : " + str);
            Console.WriteLine("temNum : " + temNum);

            //// 검색 관련
            temNum = str.IndexOf("W");
            Console.WriteLine("index : " + temNum);
            temNum = str.IndexOf("w");
            Console.WriteLine("index : " + temNum);
            temNum = str.IndexOf("d!");
            Console.WriteLine("index : " + temNum);

            temNum = str.LastIndexOf("l");
            Console.WriteLine("index : " + temNum);
            temNum = str.LastIndexOf("ll");
            Console.WriteLine("index : " + temNum);

            Console.WriteLine("StartsWith : " + str.StartsWith("Hello"));
            Console.WriteLine("StartsWith : " + str.StartsWith("World!"));

            Console.WriteLine("EndsWith : " + str.EndsWith("Hello"));
            Console.WriteLine("EndsWith : " + str.EndsWith("World!"));

            Console.WriteLine("Contains : " + str.Contains("e"));
            Console.WriteLine("Contains : " + str.Contains("z"));

            //// 변경 관련
            str = str.Replace("World", "c#");
            Console.WriteLine("str : " + str);

            str = str.Replace("c#", "World");
            Console.WriteLine("str : " + str);

            str = str.ToLower();
            Console.WriteLine("str : " + str);

            str = str.ToUpper();
            Console.WriteLine("str : " + str);

            str = str.Insert(5, "_");
            Console.WriteLine("str : " + str);

            str = str.Remove(5, 1);
            Console.WriteLine("str : " + str);
            str = " " + str + " ";
            Console.WriteLine("str : " + str);

            str = str.Trim();
            Console.WriteLine("str : " + str);

            //// 구분
            Console.WriteLine("str : " + str);
            Console.WriteLine("Substring : " + str.Substring(2, 3));

            string[] strArr = str.Split(" ");
            Console.WriteLine("strArr Length : " + strArr.Length);
            Console.WriteLine("strArr[0] : " + strArr[0]);
            Console.WriteLine("strArr[1] : " + strArr[1]);
            // Console.WriteLine("strArr[1] : " + strArr[2]);

            // format : {}, $
            string myName = Console.ReadLine();
            Console.WriteLine("My name is {0}.", myName);

            string yourName = Console.ReadLine();
            Console.WriteLine("My name is {0}, Your Name is {1}.", myName, yourName);
            Console.WriteLine($"My name is {myName}, Your Name is {yourName}.");

            Console.WriteLine("\n\n");

            // bool 데이터
            bool boolTrue = true;
            bool boolFalse = false;
            Console.WriteLine($"boolTrue : {boolTrue}");
            Console.WriteLine($"boolFalse : {boolFalse}");
            Console.WriteLine($"boolFalse : {!boolFalse}");

            Console.WriteLine("\n\n");

            // 상수
            const int MY_SALARY = 1000;
            const string MY_ID = "abc@gmail.com";

            Console.WriteLine("MY_SALARY : " + MY_SALARY);
            Console.WriteLine("MY_ID : " + MY_ID);

            /*
            MY_SALARY = 500;
            MY_ID = "def@gmail.com";
            */

            Console.WriteLine("\n\n");

            // 데이터 타입 변환
            byte bNum = 123;
            int iNum = 12345678;
            long lNum = 1234567890;

            Console.WriteLine($"bNum : {bNum}");
            Console.WriteLine($"iNum : {iNum}");
            Console.WriteLine($"lNum : {lNum}");

            /*
            lNum = (long)iNum;
            Console.WriteLine($"lNum : {lNum}");
            lNum = (long)bNum;
            Console.WriteLine($"lNum : {lNum}");
            */

            bNum = (byte)iNum;
            Console.WriteLine($"bNum : {bNum}");
            bNum = (byte)lNum;
            Console.WriteLine($"bNum : {bNum}");

            Console.WriteLine("\n\n");

            //// 문자열을 숫자로 변환
            string strNum = "123";
            Console.WriteLine($"strNum type : {strNum.GetType()}");

            ////int inte = (int)str;
            int inte = int.Parse(strNum);
            Console.WriteLine(inte);
            Console.WriteLine($"inte type : {inte.GetType()}");

            //// 숫자를 문자열로 변환
            strNum = inte.ToString();
            Console.WriteLine($"strNum : {strNum}");

            //// 문자열과 숫자의 덧셈연산
            Console.WriteLine($"string + int : {("123" + 123)}");
        }
    }
}
