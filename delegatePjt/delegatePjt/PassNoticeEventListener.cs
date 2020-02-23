using System;
using System.Collections.Generic;
using System.Text;

namespace delegatePjt
{

    delegate bool PostEventMessage(string msg);

    class PassNoticeEventListener
    {
        public event PostEventMessage postEventMessage;
        private string Message;

        public PassNoticeEventListener()
        {
            Console.WriteLine("=== PassNoticeEventListener CONSTRUCTOR ===");
        }

        public PassNoticeEventListener(string Message)
        {
            this.Message = Message;
        }

        public bool SendToSMS(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("--- SendToSMS SUCCESS ---\n");
            return true;
        }

        public bool SendToBlog(string msg)
        {
            Console.WriteLine(msg, "\n");
            Console.WriteLine("--- SendToBlog SUCCESS ---\n");
            return true;
        }

        public bool SendToKaka(string msg)
        {
            Console.WriteLine(msg, "\n");
            Console.WriteLine("--- SendToKaka SUCCESS ---\n");
            return true;
        }

        public bool SendToARS(string msg)
        {
            Console.WriteLine(msg, "\n");
            Console.WriteLine("--- SendToARS SUCCESS ---\n");
            return true;
        }

        public void SendMessage(string msg)
        {
            postEventMessage(msg);
        }
    }
}
