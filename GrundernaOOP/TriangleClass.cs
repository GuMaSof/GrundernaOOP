using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    internal class TriangleClass
    {
        //Vi ska räkna ut en triangels area. För att åstadkomma detta mål som måste vi multiplicera basen med höjden.

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
