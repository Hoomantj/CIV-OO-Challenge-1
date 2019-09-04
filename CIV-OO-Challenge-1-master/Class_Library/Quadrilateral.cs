using System;
namespace Class_Library
{
    public class Quadrilateral : Shape
    {
        public int Side1Length;
        public int Side2Length;
        public int Side3Lenght;
        public int Side4Lenght;

        public Quadrilateral(string c, int s1, int s2, int s3, int s4) : base(c)
        {
            this.Side1Length = s1;
            this.Side1Length = s2;
            this.Side3Lenght = s3;
            this.Side4Lenght = s4;
        }

        public int GetPerimeter(int s1, int s2, int s3, int s4)
        {
            int Perimeter = s1 + s2 + s3 + s4;
            return Perimeter;
        }
    }
}
