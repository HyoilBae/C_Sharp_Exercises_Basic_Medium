using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericPjt
{
    class GenericEx
    {
        static void Main(string[] args)
        {
            // GenericMethod
            PrintMethod printMethod = new PrintMethod();
            // int
            printMethod.doPrint(10);
            // double
            printMethod.doPrint(3.14);
            // string
            printMethod.doPrint("Hello");

            Console.WriteLine();

            PrintMethodGeneric printMethodGeneric = new PrintMethodGeneric();
            printMethodGeneric.doPrint<int>(10);
            printMethodGeneric.doPrint<double>(3.14);
            printMethodGeneric.doPrint<string>("Hello");

            Console.WriteLine();

            // GenericClass
            PrintClassInt printClassInt = new PrintClassInt(10);
            printClassInt.printVar();

            PrintClassDouble printClassDouble = new PrintClassDouble(3.14);
            printClassDouble.printVar();

            PrintClassString printClassString = new PrintClassString("Hello");
            printClassDouble.printVar();

            Console.WriteLine();

            PrintClassGeneric<int> printClassGenericInt = new PrintClassGeneric<int>(10);
            printClassGenericInt.printVar();

            PrintClassGeneric<double> printClassGenericDouble = new PrintClassGeneric<double>(3.14);
            printClassGenericDouble.printVar();

            PrintClassGeneric<string> printClassGenericString = new PrintClassGeneric<string>("Hello");
            printClassGenericString.printVar();

            Console.WriteLine();

            // ArrayList & List<T>
            ArrayList arrayList = new ArrayList()
            {
                10, 3.14, "Hello", new Student("2019-0001", "Kim")
            };

            Console.WriteLine(arrayList[0].GetType());
            Console.WriteLine(arrayList[1].GetType());
            Console.WriteLine(arrayList[2].GetType());
            Console.WriteLine(arrayList[3].GetType());

            // Console.WriteLine(arrayList[0] + 1);
            Console.WriteLine($"(int)arrayList[0] + 1 : {(int)arrayList[0] + 1}");

            // Console.WriteLine(arrayList[1] + 0.1);
            Console.WriteLine($"(double)arrayList[1] + 0.1 : {(double)arrayList[1] + 0.1}");

            // Student student = arrayList[3];
            Student student = (Student)arrayList[3];
            Console.WriteLine($"student.ID : {student.ID}");
            Console.WriteLine($"student.NAME : {student.NAME}");

            List<int> list1 = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            Console.WriteLine($"list1[0] + 1 : {list1[0] + 1}");
            Console.WriteLine($"list1[1] + 1 : {list1[1] + 1}");

            List<string> list2 = new List<string>()
            {
                "c/c++", "c#", "java"
            };

            Console.WriteLine($"list2[0] + 1 : {list2[0] + 1}");
            Console.WriteLine($"list2[1] + 1 : {list2[1] + 1}");

            Console.WriteLine();

            // Hashtable & Dictionary<T>
            Hashtable hashtable = new Hashtable();
            hashtable[0] = "zero";
            hashtable["one"] = 1;
            hashtable["2019_000001"] = new Student("2019_000001", "홍길동");

            Console.WriteLine(hashtable[0]);
            Console.WriteLine(hashtable["one"]);
            Console.WriteLine(hashtable["2019_000001"]);

            //Student studentHash = hashtable["2019_000001"];
            Student studentHash = (Student)hashtable["2019_000001"];
            Console.WriteLine($"Id\t: {studentHash.ID}");
            Console.WriteLine($"Name\t: {studentHash.NAME}");

            Dictionary<string, Student> dic = new Dictionary<string, Student>();
            dic.Add("2019_000001", new Student("2019_000001", "박찬호"));
            dic.Add("2019_000002", new Student("2019_000002", "손흥민"));

            Student studentDic = dic["2019_000001"];
            Console.WriteLine($"Id\t: {studentDic.ID}");
            Console.WriteLine($"Name\t: {studentDic.NAME}");

            studentDic = dic["2019_000002"];
            Console.WriteLine($"Id\t: {studentDic.ID}");
            Console.WriteLine($"Name\t: {studentDic.NAME}");

            Console.WriteLine();

            // Queue<T>
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            int queueCount = queue.Count;
            Console.WriteLine($"queueCount : {queueCount}");
            for (int i = 0; i < queueCount; i++)
            {
                Console.WriteLine($"i : {i}");
                Console.WriteLine($"queue.Dequeue() : {queue.Dequeue()}");
            }

            Console.WriteLine();

            // Stack<T>
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            int stackCount = stack.Count;
            Console.WriteLine($"stackCount : {stackCount}");
            for (int i = 0; i < stackCount; i++)
            {
                Console.WriteLine($"i : {i}");
                Console.WriteLine($"stack.Pop() : {stack.Pop()}");
            }
        }
    }
}
