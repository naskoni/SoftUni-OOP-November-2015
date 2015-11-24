using _1.Point3D;
using System;

namespace _3.Paths
{
    class PathsExample
    {
        private const string File = @"../../path.xml";

        static void Main()
        {
            var path = new Path3D(
                new Point3D(1, 2, 3),
                new Point3D(4, 5, 6),
                new Point3D(7, 8, 9));

            Storage.SavePath(path, File);
            Path3D pathLoaded = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, pathLoaded.Path));
        }        
    }
}
