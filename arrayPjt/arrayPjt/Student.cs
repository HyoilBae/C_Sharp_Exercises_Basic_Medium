using System;
using System.Collections.Generic;
using System.Text;

namespace arrayPjt
{
    class Student
    {
        private string Name;
        private int Age;
        private string Major;
        private int Grade;

        public Student()
        {
            Console.WriteLine(" === Student CONSTRUCTOR === ");
        }

        public Student(string Name, int Age, string Major, int Grade)
        {
            this.Name = Name;
            this.Age = Age;
            this.Major = Major;
            this.Grade = Grade;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Major : {Major}");
            Console.WriteLine($"Grade : {Grade}");
        }

        public string GetName(string masterId)
        {
            string name = "";
            if (masterId == "admin")
            {
                name = Name;
            }
            else
            {
                name = "You do not have access.";
            }

            return name;
        }

        public int GetAge(string masterId)
        {
            int age = 0;
            if (masterId == "admin")
            {
                age = Age;
            }
            else
            {
                age = -1;
            }

            return age;
        }

        public string GetMajor(string masterId)
        {
            string major = "";
            if (masterId == "admin")
            {
                major = Major;
            }
            else
            {
                major = "You do not have access."; ;
            }

            return major;
        }

        public int GetGrade(string masterId)
        {
            int grade = 0;
            if (masterId == "admin")
            {
                grade = Grade;
            }
            else
            {
                grade = -1;
            }

            return grade;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetName(int Age)
        {
            this.Age = Age;
        }

        public void SetMajor(string Major)
        {
            this.Major = Major;
        }

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }

    }
}
