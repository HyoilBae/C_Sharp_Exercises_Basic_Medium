using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            User alice = new User("Alice", "Password");
            alice.Hello();

            //Console.WriteLine(alice.ToString());
            //Console.WriteLine(alice._PassWord);

            Student bob = new Student("bob", "Password");
            bob.Hello();

            User test1 = new Student();
            test1.Hello();

            User st1 = new User();
            st1._UserName = "st1";
            User st2 = new User();
            st2._UserName = "st2";
            User st3 = new User();
            st3._UserName = "st3";

            MagicList<User> MagicListUser = new MagicList<User>();
            MagicListUser.Add(st1);
            MagicListUser.Add(st2);
            MagicListUser.Add(st3);
            Console.WriteLine(MagicListUser.ChooseRandom());
          

        }
    }

    class MagicList<T> : List<T>
    {
        public T ChooseRandom()
        {
            Random randomGenerator = new Random();
            return this[randomGenerator.Next(0, Count)];
        }
    }

    class User
    {
        public string _UserName { get; set; }
        protected string _PassWord { get; set; }

        public User(string UserName, string PassWord)
        {
            _UserName = UserName;
            _PassWord = PassWord;

        }

        public User()
        {

        }
        public void Hello()
        {
            Console.WriteLine("Hello {0}", _UserName);
            //Console.WriteLine($"Hello {UserName}");
        }
        public override string ToString()
        {
            return _UserName;
        }
    }

    class Student : User
    {
        public Student(string Name, string passWord)
        {
            base._UserName = Name;
            base._PassWord = passWord;
        }

        public Student()
        {

        }
    }
}
