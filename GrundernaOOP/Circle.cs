using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    public class Circle
    {
        private int _radius;

        public int _Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double area;
        //Själva mattematiken utförs inuti denna metod.
        public double GetArea()
        {
            area = _radius * _radius * Math.PI;
            return area;
        }
    }
}
