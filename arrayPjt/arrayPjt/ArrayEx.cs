using System;

namespace arrayPjt
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            // 배열 선언 - I
            int[] iNums = new int[5];
            iNums[0] = 1;
            iNums[1] = 2;
            iNums[2] = 3;
            iNums[3] = 4;
            iNums[4] = 5;

            Console.WriteLine($"iNums[0] : {iNums[0]}");
            Console.WriteLine($"iNums[1] : {iNums[1]}");
            Console.WriteLine($"iNums[2] : {iNums[2]}");
            Console.WriteLine($"iNums[3] : {iNums[3]}");
            Console.WriteLine($"iNums[4] : {iNums[4]}");

            Console.WriteLine();

            for (int i = 0; i < iNums.Length; i++)
            {
                Console.WriteLine($"iNums[{i}] : {iNums[i]}");
            }

            Console.WriteLine();

            foreach (int iNum in iNums)
            {
                Console.WriteLine($"iNum : {iNum}");
            }

            Console.WriteLine("\n\n");

            // 배열 선언 - II
            int[] jNums = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"jNums[0] : {jNums[0]}");
            Console.WriteLine($"jNums[1] : {jNums[1]}");
            Console.WriteLine($"jNums[2] : {jNums[2]}");
            Console.WriteLine($"jNums[3] : {jNums[3]}");
            Console.WriteLine($"jNums[4] : {jNums[4]}");

            Console.WriteLine();

            for (int i = 0; i < jNums.Length; i++)
            {
                Console.WriteLine($"jNums[{i}] : {jNums[i]}");
            }

            Console.WriteLine();

            foreach (int jNum in jNums)
            {
                Console.WriteLine($"jNum : {jNum}");
            }

            Console.WriteLine("\n\n");

            // 배열 선언 - III
            int[] kNums = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"kNums[0] : {kNums[0]}");
            Console.WriteLine($"kNums[1] : {kNums[1]}");
            Console.WriteLine($"kNums[2] : {kNums[2]}");
            Console.WriteLine($"kNums[3] : {kNums[3]}");
            Console.WriteLine($"kNums[4] : {kNums[4]}");

            Console.WriteLine();

            for (int i = 0; i < kNums.Length; i++)
            {
                Console.WriteLine($"kNums[{i}] : {kNums[i]}");
            }

            Console.WriteLine();

            foreach (int kNum in kNums)
            {
                Console.WriteLine($"kNum : {kNum}");
            }

            Console.WriteLine("\n\n");

            // 배열 관련 메서드
            string[] names = new string[5] { "정우람", "박찬호", "박으뜸", "박재홍", "천영웅" };

            int len = names.Length;
            Console.WriteLine($"len : {len}");

            Console.WriteLine();

            int index = Array.IndexOf(names, "박재홍");
            Console.WriteLine($"index : {index}");

            int lastIndex = Array.LastIndexOf(names, "박찬호");
            Console.WriteLine($"lastIndex : {lastIndex}");

            Array.Reverse(names);
            Console.Write($"Reverse names : ");
            foreach (string name in names)
            {
                Console.Write($"{name}\t");
            }

            Console.WriteLine();

            Console.Write($"names : ");
            foreach (string name in names)
            {
                Console.Write($"{name}\t");
            }
            Console.WriteLine();

            Array.Sort(names);

            Console.Write($"names : ");
            foreach (string name in names)
            {
                Console.Write($"{name}\t");
            }
            Console.WriteLine();

            Array.Clear(names, 0, names.Length - 2);
            Console.Write($"Clear names : ");
            foreach (string name in names)
            {
                Console.Write($"{name}\t");
            }
            Console.WriteLine();

            // 객체를 담고 있는 배열
            Student[] Students = new Student[5];
            Students[0] = new Student("박찬호", 20, "Baseball", 2);
            Students[1] = new Student("손흥민", 19, "Soccer", 1);
            Students[2] = new Student("김연경", 21, "Volleyball", 3);
            Students[3] = new Student("서장훈", 22, "Basketball", 4);
            Students[4] = new Student("박태환", 22, "Swimming", 4);


            Console.WriteLine($"Students.Length : {Students.Length}");
            foreach (Student student in Students)
            {
                Console.WriteLine($"Name\t: {student.GetName("admin")}");
                Console.WriteLine($"Age\t: {student.GetAge("admin")}");
                Console.WriteLine($"Major\t: {student.GetMajor("admin")}");
                Console.WriteLine($"Grade\t: {student.GetGrade("admin")}\n");
            }

        }
    }
}
