using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Sphere
    {
        private int _diameter;
        public double cirCumference;

        //Calculates the math.
        public double GetCircumference(int diameter)
        {
            cirCumference = diameter * Math.PI;
            return cirCumference;
        }
    }
}
