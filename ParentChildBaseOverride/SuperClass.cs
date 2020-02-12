using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildBaseOverride
{
    public class SuperClass
    {
        public int iNum = 10;
        private int jNum = 20;

        protected int x = 123;

        public static int kNum = 30;

        public SuperClass()
        {
            Console.WriteLine(" === SuperClass Constructor === ");
        }

        public int GetJNum(string masterId)
        {
            if (masterId == "admin")
            {
                return jNum;
            }
            return 0;
        }

        public void doPublicMethod()
        {
            Console.WriteLine(" === doPublicMethod() ===");
        }

        private void doPrivateMethod()
        {
            Console.WriteLine(" === doPrivateMethod() === ");
        }

        public static void doStaticMethod()
        {
            Console.WriteLine(" === doStaticMethod() ==== ");
        }

       
    }
}
