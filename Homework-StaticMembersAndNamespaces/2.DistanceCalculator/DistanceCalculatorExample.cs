using _1.Point3D;
using System;

namespace _2.DistanceCalculator
{
    class DistanceCalculatorExample
    {
        static void Main()
        {
            var firstPoint = new Point3D(1, 2, 3);
            var secondPoint = new Point3D(4, 5, 6);

            Console.WriteLine($"{DistanceCalculator.CalcDistance(firstPoint, secondPoint)}");
        }
    }
}
