using GeometricShapes.Exceptions;
using GeometricShapes.Primitives;
using System;
using System.Drawing;
using Xunit.Sdk;
using static System.Net.Mime.MediaTypeNames;

namespace Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Area_triangle_with_sides_3_4_and_5_will_be_6()
        {
            var tiangle = new Triangle(3, 4, 5);

            double expected = 6;
            double actual = tiangle.CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_with_sides_3_4_and_5_is_rectangular()
        {
            var tiangle = new Triangle(3, 4, 5);
            Assert.True(tiangle.IsRectangular());
        }

        [Fact]
        public void Triangle_with_sides_3_3_and_5_is_not_rectangular()
        {
            var tiangle = new Triangle(3, 3, 5);
            Assert.False(tiangle.IsRectangular());
        }

        [Fact]
        public void Creating_triangle_with_side_0_throws_NotExistentTriangleException()
        {
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(0, 5, 5));
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(5, 0, 5));
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(5, 5, 0));
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(0, 0, 0));
        }

        [Fact]
        public void Creating_triangle_with_negative_side_throws_NotExistentTriangleException()
        {
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(-5, 5, 5));
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(5, -5, 5));
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(5, 5, -5));
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(-5, -5, -5));
        }

        [Fact]
        public void Creating_triangle_with_sides_2_5_and_10_throws_NotExistentTriangleException()
        {
            Assert.Throws<NotExistentTriangleException>(() => new Triangle(2, 5, 10));
        }
    }
}