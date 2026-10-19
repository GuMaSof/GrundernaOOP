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

        public double omkrets;

        //Calculates the math.
        public double GetOmkrets(int diameter)
        {
            omkrets = diameter * Math.PI;
            return omkrets;
        }
    }
}
