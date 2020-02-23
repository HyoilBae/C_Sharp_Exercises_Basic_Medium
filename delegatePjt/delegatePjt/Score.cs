using System;
using System.Collections.Generic;
using System.Text;

namespace delegatePjt
{
    delegate bool ScoreCompare(int n);

    class Score
    {
        private int PassScore;

        public Score()
        {
            Console.WriteLine("=== Score CONSTRUCTOR ===");
        }

        public Score(int PassScore)
        {
            this.PassScore = PassScore;
        }

        public int PASS_SCORE
        {
            get { return PassScore; }
            set { PassScore = value; }
        }

        public bool GetPassScore(int score)
        {
            if(score >= PassScore)
                return true;
            else
                return false;

        }

        public bool GetFailScore(int score)
        {
            if (score < PassScore)
                return true;
            else
                return false;
        }

        public void GetRequireScore(Dictionary<string, Student> ss, ScoreCompare sc)
        {

            List<string> keyList = new List<string>(ss.Keys);
            for(int i = 0; i < keyList.Count; i++)
            {
                bool result = sc(ss[keyList[i]].Score);

                if(result)
                    Console.WriteLine($"ID: {ss[keyList[i]].Id}, SCORE: {ss[keyList[i]].Score}");
            }

        }
    }
}
