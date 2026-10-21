using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    internal class TriangleClass
    {
        private int baseMeasure;
        private int height;

        //Constructor ensures we fill the properties above with values.
        public TriangleClass(int baseMeasure, int height)
        {
            this.baseMeasure = baseMeasure;
            this.height = height;
        }

        /*Method calculates area of a triangle.
         * Since input is provided at the creation of objects we have no need of parameters.*/
        public int GetArea( )
        {
            int tArea = baseMeasure * height;
            return tArea;
        }
    }
}
