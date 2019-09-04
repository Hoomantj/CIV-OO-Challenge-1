using System;
using NUnit.Framework;
// remember to reference and import your shape library
using Class_Library;
namespace Quadrilateral_Tests
{
    [TestFixture]
    public class Tests
    {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }

        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }

        Square sq3 { get; set; }
        Rectangle rec3 { get; set; }

        Square sq4 { get; set; }
        Rectangle rec4 { get; set; }

        Square sq5 { get; set; }
        Rectangle rec5 { get; set; }

        [SetUp]
        public void Init()
        {
            sq1 = new Square("Blue", 4);
            rec1 = new Rectangle("Red", 4, 3);

            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);

            sq3 = new Square("Blue", 5);
            rec3 = new Rectangle("red", 5, 10);

            sq4 = new Square("Blue", 15);
            rec4 = new Rectangle("Red", 4, 6);

            sq5 = new Square("Blue", 7);
            rec5 = new Rectangle("Red", 9, 7);
        }

        [Test]
        public void SquareTests()
        {
            int area = 16;
            int perimeter = 16;

            Assert.AreEqual(area, sq1.GetArea(4));
            Assert.AreEqual(perimeter, sq1.GetPerimeter(4,4,4,4));

            area = 36;
            perimeter = 24;

            Assert.AreEqual(area, sq2.GetArea(6));
            Assert.AreEqual(perimeter, sq2.GetPerimeter(6,6,6,6));

             area = 25;
             perimeter = 20;

            Assert.AreEqual(area, sq3.GetArea(5));
            Assert.AreEqual(perimeter, sq3.GetPerimeter(5, 5, 5, 5));

            area = 225;
            perimeter= 60;

            Assert.AreEqual(area, sq4.GetArea(15));
            Assert.AreEqual(perimeter, sq4.GetPerimeter(15, 15, 15, 15));


            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, sq5.GetArea(7));
            Assert.AreEqual(perimeter, sq5.GetPerimeter(7, 7, 7, 7));


        }

        [Test]
        public void RectangleTests()
        {
            int area = 12;
            int perimeter = 14;

            Assert.AreEqual(area, rec1.GetArea(4,3));
            Assert.AreEqual(perimeter, rec1.GetPerimeter(4,3,4,3));

            area = 20;
            perimeter = 18;

            Assert.AreEqual(area, rec2.GetArea(5,4));
            Assert.AreEqual(perimeter, rec2.GetPerimeter(5,4,5,4));

            area = 50;
            perimeter = 30;

            Assert.AreEqual(area, rec3.GetArea(5, 10));
            Assert.AreEqual(perimeter, rec3.GetPerimeter(5, 10, 5, 10));

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, rec4.GetArea(4, 6));
            Assert.AreEqual(perimeter, rec4.GetPerimeter(4, 6, 4, 6));

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, rec5.GetArea(9, 7));
            Assert.AreEqual(perimeter, rec5.GetPerimeter(9, 7, 9, 7));
        }

    }
}
