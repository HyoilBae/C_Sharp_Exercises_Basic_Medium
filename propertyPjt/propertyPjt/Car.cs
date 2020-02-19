using System;
using System.Collections.Generic;
using System.Text;

namespace propertyPjt
{
    class Car :ICar
    {
        public void PrintCarInfo()
        {
            Console.WriteLine("=== PrintCarInfo() START ===");
            Console.WriteLine($"this.Name : {this.Name}");
            Console.WriteLine($"this.Color : {this.Color}");
            Console.WriteLine($"this.Price : {this.Price}");

        }

        public string Name
        {
            get; set;
        } = "Car";

        public string Color
        {
            get; set;
        } = "Black";

        public int Price
        {
            get; set;
        } = 0;
    }
}
