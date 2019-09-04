using System;

namespace Class_Library
{
    public class Square : Quadrilateral
    {
        public int Side1;
        public Square(string c, int s1) : base(c, s1,s1,s1,s1)
        {
            this.Side1 = s1;
        }

        public int GetArea(int s1)
        {
            int area = s1 * s1;
            return area;
        }

         
    }
}
