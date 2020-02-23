using System;
using System.Collections.Generic;
using System.Text;

namespace delegatePjt
{
    class Student
    {
        private string id;
        private int score;

        public Student(string id, int score)
        {
            this.id = id;
            this.score = score;
        }

        public string Id
        {
            get { return id; }
        }
        public int Score
        {
            get { return score; }
        }

    }
}
