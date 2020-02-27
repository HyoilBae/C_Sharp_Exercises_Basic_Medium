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

   
}
