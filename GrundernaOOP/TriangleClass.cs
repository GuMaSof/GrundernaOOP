using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    internal class TriangleClass
    {
        //Method calculates area of a triangle.
        public int GetArea(int baseMeasure, int height)
        {
            int tArea = baseMeasure * height;
            return tArea;
        }
    }
}
