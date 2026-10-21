using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Circle
    {
        /*Properties, that in this case serve as an empty container until creation of the object.
         Normally I would follow the naming convention of keeping all properties english,
        but it says it shall be called "radie", and I will obey the intstructions to the letter.*/
        private double radie;

        //Constructor that demands input upon creation of the object, so that we have no need of parameters in the method below.
        public Circle (double radie)
        {
            this.radie = radie;
        }

        //Method that calculates area by multiplying radius with itself, and Pi.
        public double GetArea()
        {
            double area = radie * radie * Math.PI;

            return area;
        }
    }
}
