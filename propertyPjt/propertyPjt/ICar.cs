using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    interface ICar
    {
        public void PrintCarInfo();

        public string Name
        {
            get; set;
        } 

        public string Color
        {
            get; set;
        }

        public int Price
        {
            get; set;
        }
    }
}
