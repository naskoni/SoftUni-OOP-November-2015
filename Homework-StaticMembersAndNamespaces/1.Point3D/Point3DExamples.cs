using System;

namespace _1.Point3D
{
    class Point3DExamples
    {
        static void Main()
        {
            var firstPoint = new Point3D(1, 2, 3);
            var secondPoint = new Point3D(4, 5, 6);

            Console.WriteLine("First Point: " + firstPoint);
            Console.WriteLine("Second Point: " + secondPoint);
            Console.WriteLine("Starting Point: " + Point3D.StartingPoint);
        }
    }
}
