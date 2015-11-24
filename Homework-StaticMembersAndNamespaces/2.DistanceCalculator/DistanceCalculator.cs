using System;
using _1.Point3D;

namespace _2.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalcDistance(
            Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = firstPoint.X - secondPoint.X;
            double deltaY = firstPoint.Y - secondPoint.Y;
            double deltaZ = firstPoint.Z - secondPoint.Z;

            return Math.Sqrt(Math.Pow(deltaX, 2) +
                Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
        }
    }
}
