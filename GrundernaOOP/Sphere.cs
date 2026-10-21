using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Sphere
    {
        //Properties.
        private int diameter;
        /*Constructor demands input at the creation of objects.
         * In this case the constructor serves the usual purpose of parameters.*/
        public Sphere(int diameter)
        {
            this.diameter = diameter;
        }

        //Calculates the math.
        public double GetCircumference()
        {
            double cirCumference = diameter * Math.PI;
            return cirCumference;
        }
    }
}
