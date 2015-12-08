using System;
using System.Collections.Generic;
using System.Linq;
using _01.GalacticGPS;

namespace _3.GenericList
{
    class GenericListExamples
    {
        static void Main()
        {
            IGenericList<int> numbers = new GenericList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            Console.WriteLine(numbers);
            Console.WriteLine("Min: " + numbers.Min());
            Console.WriteLine("Max: " + numbers.Max());

            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            numbers.RemoveAt(2);
            Console.WriteLine(numbers);

            numbers.Clear();
            Console.WriteLine(numbers);

            try
            {
                numbers.RemoveAt(2);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            IGenericList<Location> locations = new GenericList<Location>();
            locations.Add(new Location(2, 3, Planet.Jupiter));
            locations.Add(new Location(35, 35.3, Planet.Saturn));
            locations.Add(new Location(12, 2, Planet.Venus));
            Console.WriteLine(locations);

            locations.RemoveAt(0);
            Console.WriteLine(locations);
        }
    }
}
