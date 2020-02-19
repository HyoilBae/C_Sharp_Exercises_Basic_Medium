using System;
using System.Collections.Generic;
using System.Text;

namespace abstractPjt
{
    abstract class Message
    {
        private string strAddress;

        public void SetAddress(string strAddress)
        {
            this.strAddress = strAddress;
        }

        protected void SendMessage()
        {
            Console.WriteLine(" === SendMessage() START === ");
            Console.WriteLine($"To. {strAddress}");
        }

        public abstract bool CountStr(string str);

    }
}
