using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.CSharpConcept
{
    public class Area
    {
        public static double AreaOfCircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }
        public static double AreaOfTriangle(double baseLength, double height)
        {
            double area = baseLength * height / 2;
            return area;
        }

        public static double AreaOfSquare(double sideLength)
        {
            double area = sideLength * sideLength;
            return area;
        }
    }
}
