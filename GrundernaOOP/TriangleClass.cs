using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    internal class TriangleClass
    {
        private int _base;//Base
        private int _height;//Height

        public int tArea;
        //Method calculates area of a triangle.
        public int GetArea(int baseMeasure, int height)
        {
            tArea = baseMeasure * height;
            return tArea;
        }
    }
}
