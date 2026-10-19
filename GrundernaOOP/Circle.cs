using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Circle
    {
        private int _radius;

        public Circle (int Radius)
        {
            Radius = _radius;
        }

        //Själva mattematiken utförs inuti denna metod.
        public double GetArea(double area)
        {
            area = _radius * _radius * Math.PI;
            return area;
        }
    }
}
