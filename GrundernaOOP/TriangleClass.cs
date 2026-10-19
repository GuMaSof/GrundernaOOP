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

        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }

        //Height constructor
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        //
        public int tArea;
        //Method calculates area of a triangle.
        public int GetArea(int baseMeasure, int height)
        {
            tArea = baseMeasure * height;
            return tArea;
        }
    }
}
