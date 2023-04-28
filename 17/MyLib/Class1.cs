using System;

namespace GeometryLibrary
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        /// Checks if the triangle is valid
        /// </summary>
        /// <returns>True if the triangle is valid, false otherwise</returns>
        public bool IsValid()
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        /// <summary>
        /// Calculates the perimeter of the triangle
        /// </summary>
        /// <returns>The perimeter of the triangle</returns>
        public double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula
        /// </summary>
        /// <returns>The area of the triangle</returns>
        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        /// <summary>
        /// Determines the type of the triangle
        /// </summary>
        /// <returns>The type of the triangle (scalene, isosceles, equilateral)</returns>
        public string Type()
        {
            if (sideA == sideB && sideB == sideC)
            {
                return "equilateral";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                return "isosceles";
            }
            else
            {
                return "scalene";
            }
        }
    }

    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle
        /// </summary>
        /// <returns>The perimeter of the rectangle</returns>
        public double Perimeter()
        {
            return 2 * (length + width);
        }

        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        /// <returns>The area of the rectangle</returns>
        public double Area()
        {
            return length * width;
        }
    }
}