using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildBaseOverride
{
    class Program : SuperClass
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine();

            Console.WriteLine($"child.strOfChild : {child.strOfChild}");
            Console.WriteLine($"child.strOfParents : {child.strOfParents}");
            Console.WriteLine();

            child.methodChild();
            child.methodOfParents();
            Console.WriteLine();

            Console.WriteLine("--------------Overriding-----------------");
            ChildClass childClass = new ChildClass();
            childClass.makeJjajang();

            ParentClass parentClass;
            parentClass = childClass;

            parentClass.makeJjajang();
            Console.WriteLine();

            Console.WriteLine(" --------------Method hiding-------------");
            childClass.makeJjamppong();
            parentClass.makeJjamppong();
            Console.WriteLine();

            Console.WriteLine("--------------------private, static----------------");
            SubClass subClass = new SubClass();
            Console.WriteLine($"subClass.iNum : {subClass.iNum}");
            //Console.WriteLine($"subClass.jNum : {subClass.jNum}");

            Console.WriteLine($"subClass.GetJNum() : {subClass.GetJNum("admin")}");
            Console.WriteLine($"subClass.GetJNum() : {subClass.GetJNum("ad")}");

            //Console.WriteLine($"subClass.kNum : {subClass.kNum}");
            Console.WriteLine($"superClass.kNum : {SuperClass.kNum}");

            subClass.doPublicMethod();

            SuperClass.doStaticMethod();
            //SuperClass.doPrivateMethod();
            Console.WriteLine();

            Console.WriteLine("-----------------protected---------------");
            Program program = new Program();
            Console.WriteLine($"protected x from SuperClasss: {program.x}");
        }

    }

    class Parents
    {
        public string strOfParents = "strOfParents";
        public int intOfParents = 100;

        public Parents()
        {
            Console.WriteLine("=== Parents class Constructor ===");
        }

        public void methodOfParents()
        {
            Console.WriteLine("==== Parents Method ===");
        }
    }

    class Child : Parents
    {
        public string strOfChild = "strOfChild";
        public int intOfChild = 200;

        public Child()
        {
            Console.WriteLine("=== Child Class Constructor ====");
        }

        public void methodChild()
        {
            Console.WriteLine("=== Child Method ===");
        }
    }
}
