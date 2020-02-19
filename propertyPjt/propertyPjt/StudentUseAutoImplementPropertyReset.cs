using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    class StudentUseAutoImplementPropertyReset
    {

        public StudentUseAutoImplementPropertyReset()
        {
            Console.WriteLine(" === StudentUseAutoImplementPropertyReset DEFAULT CONSTRUCTOR === ");
        }

        public string Id
        {
            get; set;
        } = "2019-00000X";

        public string Name
        {
            get; set;
        } = "STUDENT's NAME";

        public int Age
        {
            get; set;
        } = 0;

        public string Major
        {
            get; set;
        } = "STUDENT's MAJOR";
    }
}
