using System;
using System.Collections.Generic;
using System.Text;

namespace delegatePjt
{

    delegate bool PostMessage(string msg);
    class PassNoticeListener
    {
        public PostMessage postMessage;
        private string Message;

        public PassNoticeListener()
        {
            Console.WriteLine("=== PassNoticeListener CONSTRUCTOR ===");
        }

        public PassNoticeListener(string Message)
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

    }
}
