using System;
using System.Collections.Generic;
using System.Text;

namespace collectionPjt
{
    class Student
    {
        private string Id;
        private string Name;
        private int Age;
        private string Major;

        public Student(string Id, string Name, int Age, string Major)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Major = Major;
        }

        public string GetId()
        {
            return this.Id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public string GetMajor()
        {
            return this.Major;
        }
    }
}
