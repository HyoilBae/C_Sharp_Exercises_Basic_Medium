using System;
using System.Collections.Generic;
using System.Text;

namespace delegatePjt
{
    delegate double CircleDelegate(double r);
    class CircleCalculator
    {
        double circleRatio = 3.14d;
        public CircleCalculator()
        {
            Console.WriteLine("=== CircleCalculator CONSTRUCTOR ===");
        }

        public double GetArea(double r)
        {
            return r * r * circleRatio;
        }

        public double GetLength(double r)
        {
            return 2 * circleRatio * r; 
        }
    }
}
