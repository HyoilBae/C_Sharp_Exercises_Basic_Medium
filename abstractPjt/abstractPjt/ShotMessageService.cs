using System;
using System.Collections.Generic;
using System.Text;

namespace abstractPjt
{
    class ShotMessageService : Message
    {
        public override bool CountStr(string str)
        {
            Console.WriteLine(" === ShotMessageService - CountStr() START === ");

            Console.WriteLine($"str.Length : {str.Length}");
            if (str.Length <= 70)
                return true;

            return false;
        }

        public void SendSMS()
        {
            SendMessage();
        }
    }
}
