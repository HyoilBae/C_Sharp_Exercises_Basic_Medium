using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    class StudentUseProperty
    {
        private string id;
        private string name;
        private int age;
        private string major;

        public StudentUseProperty()
        {
            Console.WriteLine(" === StudentUseProperty DEFAULT CONSTRUCTOR === ");
        }

        public StudentUseProperty(string id, string name, int age, string major)
        {
            Console.WriteLine(" === StudentUseProperty CONSTRUCTOR === ");
            this.id = id;
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                this.age = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }

            set
            {
                this.major = value;
            }
        }

        public string Info
        {
            get
            {
                return Id + " | " + Name + " | " + Age + " | " + Major;
            }
        }
    }
}
