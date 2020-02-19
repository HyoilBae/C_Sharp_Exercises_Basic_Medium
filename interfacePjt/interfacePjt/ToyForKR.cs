using System;
using System.Collections.Generic;
using System.Text;

namespace interfacePjt
{
    class ToyForKR : IToy
    {
        public ToyForKR()
        {
            Console.WriteLine(" === ToyForKR CONSTRUCTOR === ");
        }

        public void DoGreet()
        {
            Console.WriteLine("안녕하세요. 만나서 반갑습니다.");
        }

        public void Greet()
        {
            Console.WriteLine("안녕하세요. 만나서 반갑습니다.");
        }

    }
}
