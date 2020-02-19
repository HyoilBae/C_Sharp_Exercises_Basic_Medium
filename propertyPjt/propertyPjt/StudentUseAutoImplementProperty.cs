using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    class StudentUseAutoImplementProperty
    {

        public StudentUseAutoImplementProperty()
        {
            Console.WriteLine(" === StudentUseAutoImplementProperty DEFAULT CONSTRUCTOR === ");
        }

        public string Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public string Major
        {
            get; set;
        }
    }
}
