using System;
using System.Collections.Generic;
using System.Text;

namespace abstractPjt
{
    class MultimediaMessagingService : Message
    {
        public override bool CountStr(string str)
        {
            Console.WriteLine(" === MultimediaMessageService - CountStr() START === ");

            Console.WriteLine($"str.Length : {str.Length}");
            if (str.Length > 70 && str.Length <= 200)
                return true;

            return false;
        }

        public void SendMMS()
        {
            SendMessage();
        }
    }
}
