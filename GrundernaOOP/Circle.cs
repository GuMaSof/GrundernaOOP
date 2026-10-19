using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Circle
    {
        //Method that calculates area by multiplying radius with itself, and Pi.
        public double GetArea(double radius)
        {
            double area = radius * radius * Math.PI;

            return area;
        }
    }
}
