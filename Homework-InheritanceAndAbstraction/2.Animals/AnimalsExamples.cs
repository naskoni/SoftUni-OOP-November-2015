using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Animals
{
    class AnimalsExamples
    {
        static void Main()
        {
            var animals = new List<Animal>()
            {
                new Kitten("Mira", 4),
                new Kitten("Sara", 2),
                new Tomcat("Tom", 1),
                new Tomcat("Riffy", 3),
                new Frog("Kermit", 3, Gender.Male),
                new Frog("Jaborana", 1, Gender.Female),
                new Dog("Elza", 3, Gender.Female),
                new Dog("Johnny", 5, Gender.Male),
                new Dog("Rex", 2, Gender.Male),
            };

            animals.GroupBy(a => a.GetType().Name)
                .Select(group => new
                {
                    Species = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderBy(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine($"{group.Species} - average age: {group.AverageAge:F2}"));
        }
    }
}
