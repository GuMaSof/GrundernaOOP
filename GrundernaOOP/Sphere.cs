using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Sphere
    {
        private int _diameter;

        public int _Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public double cirCumference;

        //Calculates the math.
        public double GetCircumference(int diameter)
        {
            cirCumference = diameter * Math.PI;
            return cirCumference;
        }
    }
}
