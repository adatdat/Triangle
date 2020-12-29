using System;
using NUnit.Framework;

namespace Triangle.Test
{
    [TestFixture]
    public class PointUnitTest
    {
        private Point _point;
        [SetUp]
        public void Setup()
        {
            _point = new Point();
        }
        public void Setup(int coordinateX, int coordinateY)
        {
            _point = new Point(coordinateX, coordinateY);
        }
        [TestCase(0, 0, 1, 0, 1)]
        //[TestCase(0, 0, 1, 1, 1.41421356237)]
        //[TestCase(-1, -2, 1, 0, 8)]
        //[TestCase('a', 0, 1, 0, 1)]
        //[TestCase(0, null, 1, 0, 1)]
        //[TestCase(0, 0, 1, -1010021, 1)]
        public void TestCalculateDistance(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY, double distance)
        {
            _point.coordinateX = firstPointCoordinateX;
            _point.coordinateY = firstPointCoordinateY;
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Assert.AreEqual(distance, _point.calculateDistance(secondPoint));
        }
        [TestCase(0, 0, 0, 0, true)]
        //[TestCase(21, 42, 21, 54, true)]
        //[TestCase('a', 0, 1, 0, false)]
        //[TestCase(0, null, 1, 0, true)]
        //[TestCase(0, 0, 1, -1010021, false)]
        public void TestIsZeroValueDistance(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY, bool result)
        {
            _point.coordinateX = firstPointCoordinateX;
            _point.coordinateY = firstPointCoordinateY;
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Assert.AreEqual(result, _point.isZeroValueDistance(secondPoint));
        }
        [TestCase(0, 0, 0, 0, true)]
        //[TestCase(21, 42, 21, 54, true)]
        //[TestCase('a', 0, 1, 0, false)]
        //[TestCase(0, null, 1, 0, true)]
        //[TestCase(0, 0, 1, -1010021, false)]
        public void TestComparerPoint(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY, bool result)
        {
            _point.coordinateX = firstPointCoordinateX;
            _point.coordinateY = firstPointCoordinateY;
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Assert.AreEqual(result, _point.comparerPoint(secondPoint));
        }
    }
}
