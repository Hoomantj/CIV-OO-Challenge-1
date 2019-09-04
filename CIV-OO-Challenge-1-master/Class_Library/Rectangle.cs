using System;
namespace Class_Library
{
    public class Rectangle : Quadrilateral
    {
        public int Side1;
        public int Side2;

        public Rectangle(string c,int s1, int s2): base(c, s1, s1, s2, s2)
        {
            this.Side1 = s1;
            this.Side2 = s2;

        }

        public int GetArea(int s1, int s2)
        {
            int area = s1 * s2;
            return area;
        }
    }
}
