using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    class Student
    {
        private string id;
        private string name;
        private int age;
        private string major;

        public Student()
        {
            Console.WriteLine(" === Student DEFAULT CONSTRUCTOR === ");
        }

        public Student(string id, string name, int age, string major)
        {
            Console.WriteLine(" === Student CONSTRUCTOR === ");
            this.id = id;
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public string GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetMajor()
        {
            return major;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetMajor(string major)
        {
            this.major = major;
        }
    }
}
