using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle.Elements
{
    class TriangleModel
    {
        private Point _firstPoint;
        private Point _secondPoint;
        private Point _thirdPoint;

        public Point firstPoint { get => _firstPoint ; set => _firstPoint = value; }
        public Point secondPoint { get => _secondPoint; set => _secondPoint = value; }
        public Point thirdPoint { get => _thirdPoint; set => _thirdPoint = value; }

        public TriangleModel()
        {
            firstPoint = new Point(0, 0);
            secondPoint = new Point(0, 1);
            thirdPoint = new Point(1, 0);
        }

        public TriangleModel(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            if (IsTriangle(firstPointInput, secondPointInput, thirdPointInput) == false)
                throw new ArgumentException($"Triangle with points: A={firstPointInput}, B={secondPointInput} and C={thirdPointInput} does not exist");
            firstPoint = firstPointInput;
            secondPoint = secondPointInput;
            thirdPoint = thirdPointInput;
        }
        private bool IsTriangle(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            return firstPointInput.calculeDistance(secondPointInput) < thirdPointInput.calculeDistance(secondPointInput) + thirdPointInput.calculeDistance(firstPointInput);
        }
        public void toString()
        {
            Console.Write("#1: ");
            firstPoint.toString();
            Console.Write("#2: ");
            secondPoint.toString();
            Console.Write("#3: ");
            thirdPoint.toString();
        }
    }
}
