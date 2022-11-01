using GeometricShapes.Exceptions;
using GeometricShapes.Primitives;
using System;
using System.Drawing;
using Xunit.Sdk;
using static System.Net.Mime.MediaTypeNames;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void Area_circle_with_radius_1_is_equal_to_PI()
        {
            var circle = new Circle(1);

            double expected = Math.PI;
            double actual = circle.CalculateArea();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Area_circle_with_radius_1_is_equal_to_78_539816339744831()
        {
            var circle = new Circle(5);

            double expected = 78.539816339744831;
            double actual = circle.CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Creating_circle_with_negative_radius_throws_CircleRadiusNegativeException()
        {
            Assert.Throws<NegativeCircleRadiusException>(() => new Circle(-1));
        }
    }
}