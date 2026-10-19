using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Sphere
    {
        //Calculates the math.
        public double GetCircumference(int diameter)
        {
            double cirCumference = diameter * Math.PI;
            return cirCumference;
        }
    }
}
