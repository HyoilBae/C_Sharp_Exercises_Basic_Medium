using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPjt
{
    class Student
    {
        private string Id;
        private string Name;

        public Student(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public string ID
        {
            get { return Id; }
        }

        public string NAME
        {
            get { return Name; }
        }
    }
}
