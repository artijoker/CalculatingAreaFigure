using GeometricShapes.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.Primitives
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new NotExistentTriangleException();

            if (sideA >= (sideB + sideC) || sideC >= (sideB + sideA) || sideB >= (sideA + sideC))
                throw new NotExistentTriangleException();

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double result = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(result * (result - SideA) * (result - SideB) * (result - SideC));
        }

        public bool IsRectangular()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
                Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }

    }
}
