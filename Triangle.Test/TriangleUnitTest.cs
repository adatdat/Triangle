using System;
using NUnit.Framework;

namespace Triangle.Test
{
    [TestFixture]
    class TriangleUnitTest
    {
        private TriangleModel _triangle;
        [SetUp]
        public void Setup()
        {
            _triangle = new TriangleModel();
        }
        [Test]
        public void TestTriangleModel(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            _triangle = new TriangleModel(firstPoint, secondPoint, thirdPoint);
        }

        //==============================================================================================
        [TestCase(0, 1, 3, 4, 2, 4, true)]
        [TestCase(0, 1, 5, 12, -1, 4, true)]
        [TestCase(0, 1, 6, 4, 32, 4, false)]
        [TestCase(0, 1, 'a', 4, 2, 4, true)]
        [TestCase(0, 1, 3, null, 2, 4, false)]
        [TestCase(0, -112213123, 3, 4, 2311232, 4, false)]
        public void TestIsTriangle(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY, bool result)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            Assert.AreEqual(result, _triangle.IsTriangle(firstPoint, secondPoint, thirdPoint));
        }

        //==============================================================================================
        [TestCase(0, 1, 3, 4, 2, 4, true)]
        [TestCase(0, 1, 5, 12, -1, 4, true)]
        [TestCase(0, 1, 6, 4, 32, 4, false)]
        [TestCase(0, 1, 'a', 4, 2, 4, true)]
        [TestCase(0, 1, 3, null, 2, 4, false)]
        [TestCase(0, -112213123, 3, 4, 2311232, 4, false)]
        public void TestIsEquilateralTriangle(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY, bool result)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            _triangle.firstPoint = firstPoint;
            _triangle.secondPoint = secondPoint;
            _triangle.thirdPoint = thirdPoint;
            Assert.AreEqual(result, _triangle.IsEquilateralTriangle());
        }

        //==============================================================================================
        [TestCase(0, 1, 3, 4, 2, 4, true)]
        [TestCase(0, 1, 5, 12, -1, 4, true)]
        [TestCase(0, 1, 6, 4, 32, 4, false)]
        [TestCase(0, 1, 'a', 4, 2, 4, true)]
        [TestCase(0, 1, 3, null, 2, 4, false)]
        [TestCase(0, -112213123, 3, 4, 2311232, 4, false)]
        public void TestIsIsoscelesTriangle(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY, bool result)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            _triangle.firstPoint = firstPoint;
            _triangle.secondPoint = secondPoint;
            _triangle.thirdPoint = thirdPoint;
            Assert.AreEqual(result, _triangle.IsIsoscelesTriangle());
        }

        //==============================================================================================
        [TestCase(0, 1, 3, 4, 2, 4, true)]
        [TestCase(0, 1, 5, 12, -1, 4, true)]
        [TestCase(0, 1, 6, 4, 32, 4, false)]
        [TestCase(0, 1, 'a', 4, 2, 4, true)]
        [TestCase(0, 1, 3, null, 2, 4, false)]
        [TestCase(0, -112213123, 3, 4, 2311232, 4, false)]
        public void TestIsRightTriangle(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY, bool result)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            _triangle.firstPoint = firstPoint;
            _triangle.secondPoint = secondPoint;
            _triangle.thirdPoint = thirdPoint;
            Assert.AreEqual(result, _triangle.IsRightTriangle());
        }

        //==============================================================================================
        [TestCase(0, 1, 3, 4, 2, 4, true)]
        [TestCase(0, 1, 5, 12, -1, 4, true)]
        [TestCase(0, 1, 6, 4, 32, 4, false)]
        [TestCase(0, 1, 'a', 4, 2, 4, true)]
        [TestCase(0, 1, 3, null, 2, 4, false)]
        [TestCase(0, -112213123, 3, 4, 2311232, 4, false)]
        public void TestIsScaleneTriangle(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY, bool result)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            _triangle.firstPoint = firstPoint;
            _triangle.secondPoint = secondPoint;
            _triangle.thirdPoint = thirdPoint;
            Assert.AreEqual(result, _triangle.IsScaleneTriangle());
        }

        //==============================================================================================
        [TestCase(0, 1, 3, 4, 2, 4, true)]
        [TestCase(0, 1, 3, 4, 2, 4, 8.8481919625832735)]
        [TestCase(0, 1, 5, 12, -1, 4, 32)]
        [TestCase(0, 1, 6, 4, 32, 4, 300)]
        [TestCase(0, 1, 'a', 4, 2, 4, 'b')]
        [TestCase(0, 1, 3, null, 2, 4, -30)]
        [TestCase(0, -112213123, 3, 4, 2311232, 4, 10000)]
        public void TestCalculatePerimeter(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY, double perimeter)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            _triangle.firstPoint = firstPoint;
            _triangle.secondPoint = secondPoint;
            _triangle.thirdPoint = thirdPoint;
            Assert.AreEqual(perimeter, _triangle.calculatePerimeter());
        }

        //==============================================================================================
        [Test]
        public void TestTrowExceptionIfSideIsZero(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY,
            int thirdPointCoordinateX, int thirdPointCoordinateY)
        {
            Point firstPoint = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point thirdPoint = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            Assert.That(() => _triangle.TrowExceptionIfSideIsZero(firstPoint, secondPoint, thirdPoint),
            Throws.Exception
              .TypeOf<ArgumentNullException>()
              .With.Property("ParamName")
              .EqualTo($"Have a side value is 0, must more 0"));
        }
    }
}
