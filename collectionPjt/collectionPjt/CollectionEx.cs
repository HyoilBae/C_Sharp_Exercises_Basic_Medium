using System;
using System.Collections;
using System.Collections.Generic;

namespace collectionPjt
{
    class CollectionEx
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList arrayList = new ArrayList();

            //// ArrayList - Add()
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            for (int i = 5; i < 11; i++)
            {
                arrayList.Add(i);
            }

            //// ArrayList - Count
            for (int j = 0; j < arrayList.Count; j++)
            {
                Console.WriteLine($"arrayList{j} : {arrayList[j]}");
            }

            int sum = 0;
            foreach (int kNum in arrayList)
            {
                sum = sum + kNum;
            }
            Console.WriteLine($"sum : {sum}");

            //// ArrayList - Insert()
            arrayList.Insert(2, 30);
            for (int j = 0; j < arrayList.Count; j++)
            {
                Console.Write($"{arrayList[j]}\t");
            }

            Console.WriteLine();

            //// ArrayList - RemoveAt();
            arrayList.RemoveAt(2);
            foreach (int hNum in arrayList)
            {
                Console.Write($"{hNum}\t");
            }

            Console.WriteLine();

            //// ArrayList - Remove();
            arrayList.Remove(5);
            foreach (int hNum in arrayList)
            {
                Console.Write($"{hNum}\t");
            }

            Console.WriteLine();

            // Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable[0] = "zero";
            hashtable["one"] = 1;
            hashtable["2019_000001"] = new Student("2019_000001", "홍길동", 20, "computer");

            Console.WriteLine(hashtable[0]);
            Console.WriteLine(hashtable["one"]);
            Console.WriteLine(hashtable["2019_000001"]);

            Student student = (Student)hashtable["2019_000001"];
            Console.WriteLine($"Id\t: {student.GetId()}");
            Console.WriteLine($"Name\t: {student.GetName()}");
            Console.WriteLine($"Age\t: {student.GetAge()}");
            Console.WriteLine($"Major\t: {student.GetMajor()}");

            //// Hashtable - Add()
            hashtable.Add("ten", 10);
            hashtable.Add("KOREA", "대한민국");
            hashtable.Add("2019_000002", new Student("2019_000001", "홍길순", 22, "sports"));

            Console.WriteLine(hashtable["ten"]);
            Console.WriteLine(hashtable["KOREA"]);

            student = (Student)hashtable["2019_000002"];
            Console.WriteLine($"Id\t: {student.GetId()}");
            Console.WriteLine($"Name\t: {student.GetName()}");
            Console.WriteLine($"Age\t: {student.GetAge()}");
            Console.WriteLine($"Major\t: {student.GetMajor()}");

            //hashtable.Add("KOREA", "한국");
            if (!hashtable.ContainsKey("KOREA"))
            {
                Console.WriteLine("The hashtable does not contain 'KOREA' key.");
                hashtable.Add("KOREA", "한국");
                Console.WriteLine(hashtable["KOREA"]);
            }
            hashtable["KOREA"] = "한국";
            Console.WriteLine(hashtable["KOREA"]);

            Console.WriteLine();

            if (hashtable.ContainsValue("한국"))
            {
                Console.WriteLine("The hashtable contains '한국' value.");
            }
            else
            {
                Console.WriteLine("The hashtable does not contain '한국' value.");
            }

            if (hashtable.ContainsValue("미국"))
            {
                Console.WriteLine("The hashtable contains '미국' value.");
            }
            else
            {
                Console.WriteLine("The hashtable does not contain '미국' value.");
            }

            Console.WriteLine();

            //// Hashtable - key & value
            ICollection keys = hashtable.Keys;
            foreach (Object obj in keys)
            {
                Console.WriteLine($"obj : {obj}");
                Console.WriteLine($"hashtable[{obj}] : {hashtable[obj]}");
            }

            ICollection values = hashtable.Values;
            foreach (Object obj in values)
            {
                Console.WriteLine($"obj : {obj}");
            }

            //// Hashtable - DictionaryEntry
            foreach (DictionaryEntry dObj in hashtable)
            {
                Console.WriteLine($"key : {dObj.Key},\tvalue : {dObj.Value}");
            }

            Console.WriteLine();

            //// Hashtable - Remove
            Console.WriteLine($"hashtableCount : {hashtable.Count}");
            hashtable.Remove("KOREA");
            Console.WriteLine($"hashtableCount : {hashtable.Count}");
            foreach (DictionaryEntry dObj in hashtable)
            {
                Console.WriteLine($"key : {dObj.Key},\tvalue : {dObj.Value}");
            }

            Console.WriteLine();

            hashtable.Remove("2019_000002");
            Console.WriteLine($"hashtableCount : {hashtable.Count}");
            foreach (DictionaryEntry dObj in hashtable)
            {
                Console.WriteLine($"key : {dObj.Key},\tvalue : {dObj.Value}");
            }

            Console.WriteLine();

            // Dictionary
            Dictionary<string, Student> dic = new Dictionary<string, Student>();
            dic.Add("2019-00001", new Student("2019-00001", "박찬호", 22, "Baseball"));
            dic.Add("2019-00002", new Student("2019-00002", "손흥민", 21, "Soccer"));
            dic.Add("2019-00003", new Student("2019-00003", "박태환", 20, "Swim"));
            dic["2019-00004"] = new Student("2019-00004", "박세리", 19, "Golf");

            Console.WriteLine($"{dic.Count}");

            Console.WriteLine();

            //// Dictionary - Keys & values
            ICollection keysOfDic = dic.Keys;
            foreach (Object obj in keysOfDic)
            {
                Console.WriteLine($"obj : {obj}");
            }

            Console.WriteLine();

            ICollection valuesOfDic = dic.Values;
            foreach (Object obj in valuesOfDic)
            {
                Console.WriteLine($"Id\t:{((Student)obj).GetId()}");
                Console.WriteLine($"Name\t:{((Student)obj).GetName()}");
                Console.WriteLine($"Age\t:{((Student)obj).GetAge()}");
                Console.WriteLine($"Major\t:{((Student)obj).GetMajor()}");
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine();

            //// Dictionary - Keys
            if (dic.ContainsKey("2019-00001"))
            {
                Console.WriteLine("The hashtable contains '2019-00001' key.");
            }
            else
            {
                Console.WriteLine("The hashtable dose not contain '2019-00001' key.");
            }

            Console.WriteLine();

            Console.WriteLine($"{dic.Count}");
            dic.Remove("2019-00004");
            Console.WriteLine($"{dic.Count}");
            keysOfDic = dic.Keys;
            foreach (Object obj in keysOfDic)
            {
                Console.WriteLine($"obj : {obj}");
            }

            Console.WriteLine();

            dic.Remove("2019-00001");
            Console.WriteLine($"{dic.Count}");
            keysOfDic = dic.Keys;
            foreach (Object obj in keysOfDic)
            {
                Console.WriteLine($"obj : {obj}");
            }

            Console.WriteLine();

            // SortedSet
            SortedSet<int> numberSet1 = new SortedSet<int>();
            numberSet1.Add(30);
            numberSet1.Add(0);
            numberSet1.Add(100);
            numberSet1.Add(7);
            numberSet1.Add(25);

            foreach (int i in numberSet1)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            if (!numberSet1.Add(100))
            {
                Console.WriteLine("The numberSet contains '100'.");
            }
            else
            {
                Console.WriteLine("The numberSet dose not contain '100'.");
            }

            foreach (int i in numberSet1)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            //// SortedSet - Remove
            numberSet1.Remove(100);
            foreach (int i in numberSet1)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            //// SortedSet - Max & Min
            Console.WriteLine($"numberSet.min : {numberSet1.Min}");
            Console.WriteLine($"numberSet.Max : {numberSet1.Max}");

            Console.WriteLine();

            //// SortedSet - UnionWith()
            SortedSet<int> numberSet2 = new SortedSet<int>();
            numberSet2.Add(130);
            numberSet2.Add(10);
            numberSet2.Add(1100);
            numberSet2.Add(17);
            numberSet2.Add(125);
            foreach (int i in numberSet2)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            numberSet2.UnionWith(numberSet1);
            foreach (int i in numberSet2)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            //// SortedSet - Clear
            Console.WriteLine($"numberSet.Count : {numberSet1.Count}");
            numberSet1.Clear();
            Console.WriteLine($"numberSet.Count : {numberSet1.Count}");

            Console.WriteLine();

            // SortedSet
            HashSet<int> hashSet1 = new HashSet<int>();
            hashSet1.Add(30);
            hashSet1.Add(0);
            hashSet1.Add(100);
            hashSet1.Add(7);
            hashSet1.Add(25);

            foreach (int i in hashSet1)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            HashSet<int> hashSet2 = new HashSet<int>();
            hashSet2.Add(130);
            hashSet2.Add(10);
            hashSet2.Add(1100);
            hashSet2.Add(17);
            hashSet2.Add(125);
            foreach (int i in hashSet2)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            hashSet2.UnionWith(hashSet1);
            foreach (int i in hashSet2)
            {
                Console.WriteLine($"i : {i}");
            }

            Console.WriteLine();

            // Queue
            Queue queue1 = new Queue();
            queue1.Enqueue(10);
            queue1.Enqueue(20);
            queue1.Enqueue(30);
            queue1.Enqueue(40);
            queue1.Enqueue(50);

            int queue1Count = queue1.Count;
            Console.WriteLine($"queue1Count : {queue1Count}");
            for (int i = 0; i < queue1Count; i++)
            {
                Console.WriteLine($"i : {i}");
                Console.WriteLine($"queue1.Dequeue() : {queue1.Dequeue()}");
            }

            Console.WriteLine();

            Queue queue2 = new Queue();
            queue2.Enqueue(new Student("2019-00001", "박찬호", 22, "Baseball"));
            queue2.Enqueue(new Student("2019-00002", "손흥민", 21, "Soccer"));
            queue2.Enqueue(new Student("2019-00003", "박태환", 20, "Swim"));
            queue2.Enqueue(new Student("2019-00004", "박세리", 19, "Golf"));
            queue2.Enqueue(new Student("2019-00005", "김연아", 19, "Skate"));

            int queue2Count = queue2.Count;
            Console.WriteLine($"queue2Count : {queue2Count}");
            for (int i = 0; i < queue2Count; i++)
            {
                Console.WriteLine($"i : {i}");
                Student sd = (Student)queue2.Dequeue();
                Console.WriteLine($"Id\t: {sd.GetId()}");
                Console.WriteLine($"Name\t: {sd.GetName()}");
                Console.WriteLine($"Age\t: {sd.GetAge()}");
                Console.WriteLine($"Major\t: {sd.GetMajor()}");
            }

            Console.WriteLine();

            // Stack
            Stack stack1 = new Stack();
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            stack1.Push(40);
            stack1.Push(50);

            int stack1Count = stack1.Count;
            Console.WriteLine($"stack1Count : {stack1Count}");
            for (int i = 0; i < stack1Count; i++)
            {
                Console.WriteLine($"i : {i}");
                Console.WriteLine($"stack1.Pop() : {stack1.Pop()}");
            }

            Console.WriteLine();

            Stack stack2 = new Stack();
            stack2.Push(new Student("2019-00001", "박찬호", 22, "Baseball"));
            stack2.Push(new Student("2019-00002", "손흥민", 21, "Soccer"));
            stack2.Push(new Student("2019-00003", "박태환", 20, "Swim"));
            stack2.Push(new Student("2019-00004", "박세리", 19, "Golf"));
            stack2.Push(new Student("2019-00005", "김연아", 19, "Skate"));

            int stack2Count = stack2.Count;
            Console.WriteLine($"stack2Count : {stack2Count}");
            for (int i = 0; i < stack2Count; i++)
            {
                Console.WriteLine($"i : {i}");
                Student sd = (Student)stack2.Pop();
                Console.WriteLine($"Id\t: {sd.GetId()}");
                Console.WriteLine($"Name\t: {sd.GetName()}");
                Console.WriteLine($"Age\t: {sd.GetAge()}");
                Console.WriteLine($"Major\t: {sd.GetMajor()}");
            }
        }

    }
}
