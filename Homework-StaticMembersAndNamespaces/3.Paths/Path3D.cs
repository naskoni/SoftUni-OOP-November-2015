using _1.Point3D;
using System.Collections.Generic;
using System;

namespace _3.Paths
{
    public class Path3D
    {
        public Path3D(params Point3D[] points) : this()
        {
            this.Path = new List<Point3D>();
            this.AddPoints(points);
        }

        private Path3D() { }

        public List<Point3D> Path { get; set; }

        private void AddPoints(Point3D[] points)
        {
            foreach (var point in points)
            {
                this.Path.Add(point);
            }
        }
    }
}
