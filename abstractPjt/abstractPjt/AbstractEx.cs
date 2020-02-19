using System;

namespace abstractPjt
{
    class AbstractEx
    {
        static void Main(string[] args)
        {
            string sMsg = "Hello. Nice to meet you.";
            string mMsg = "Hello. Nice to meet you. Today is fine.";
            mMsg += "Hello. Nice to meet you. Today is fine.";
            mMsg += "Hello. Nice to meet you. Today is fine.";
            mMsg += "Hello. Nice to meet you. Today is fine.";
            mMsg += "Hello. Nice to meet you. Today is fine.";

            ShotMessageService sms = new ShotMessageService();
            if(sms.CountStr(sMsg))
            {
                sms.SetAddress("010-1234-5678");
                sms.SendSMS();
            }

            MultimediaMessagingService mms = new MultimediaMessagingService();
            if (mms.CountStr(mMsg))
            {
                mms.SetAddress("010-9874-5632");
                mms.SendMMS();
            }

        }
    }
}
