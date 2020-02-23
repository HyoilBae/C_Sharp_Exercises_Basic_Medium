using System;
using System.Collections.Generic;

namespace delegatePjt
{
    class DelegateEx
    {
        static void Main(string[] args)
        {
            // Delegate
            CircleCalculator circleCalculator = new CircleCalculator();

            CircleDelegate circleDelegate = new CircleDelegate(circleCalculator.GetArea);
            double circleArea = circleDelegate(10);
            Console.WriteLine($"circleArea : {circleArea}");

            circleDelegate = new CircleDelegate(circleCalculator.GetLength);
            double circleLength = Math.Round(circleDelegate(10), 2);
            Console.WriteLine($"circleLength : {circleLength}");

            Console.WriteLine();

            Dictionary<string, Student> students = new Dictionary<string, Student>();
            students.Add("2019-000001", new Student("2019-000001", 80));
            students.Add("2019-000002", new Student("2019-000002", 90));
            students.Add("2019-000003", new Student("2019-000003", 75));
            students.Add("2019-000004", new Student("2019-000004", 69));
            students.Add("2019-000005", new Student("2019-000005", 91));

            Score score = new Score(80);
            Console.WriteLine("\n-- PASS STUDENT ---");
            ScoreCompare scoreCompare = new ScoreCompare(score.GetPassScore);
            score.GetRequireScore(students, scoreCompare);
            Console.WriteLine("\n-- FAIL STUDENT ---");
            scoreCompare = new ScoreCompare(score.GetFailScore);
            score.GetRequireScore(students, scoreCompare);

            score.PASS_SCORE = 70;
            Console.WriteLine("\n-- PASS STUDENT ---");
            scoreCompare = new ScoreCompare(score.GetPassScore);
            score.GetRequireScore(students, scoreCompare);
            Console.WriteLine("\n-- FAIL STUDENT ---");
            scoreCompare = new ScoreCompare(score.GetFailScore);
            score.GetRequireScore(students, scoreCompare);

            Console.WriteLine();

            // Delegate Chain
            PassNoticeListener passNoticeListener = new PassNoticeListener();
            passNoticeListener.postMessage += passNoticeListener.SendToSMS;
            passNoticeListener.postMessage += passNoticeListener.SendToBlog;
            passNoticeListener.postMessage += passNoticeListener.SendToKaka;
            passNoticeListener.postMessage += passNoticeListener.SendToARS;

            passNoticeListener.postMessage("Congratulations! Passed!!");

            passNoticeListener.postMessage -= new PostMessage(passNoticeListener.SendToSMS);
            passNoticeListener.postMessage -= new PostMessage(passNoticeListener.SendToARS);

            passNoticeListener.postMessage("Congratulations! Passed!!");


            // Event
            PassNoticeEventListener passNoticeEventListener = new PassNoticeEventListener();
            passNoticeEventListener.postEventMessage += passNoticeEventListener.SendToSMS;
            passNoticeEventListener.postEventMessage += passNoticeEventListener.SendToBlog;
            passNoticeEventListener.postEventMessage += passNoticeEventListener.SendToKaka;
            passNoticeEventListener.postEventMessage += passNoticeEventListener.SendToARS;

            passNoticeEventListener.SendMessage("Congratulations! Passed!!");

        }
    }
}
