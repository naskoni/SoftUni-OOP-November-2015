using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.HumanStudentAndWorker
{
    class HumanStudentAndWorkerExamples
    {
        static void Main()
        {
            var students = new List<Student>() 
            { 
                new Student("Spiro", "Spirov", "fn911"),
                new Student("Kiro", "Kirov", "fn221"),
                new Student("Spiro", "Kirov", "fn331"),
                new Student("Kiro", "Spirov", "fn241"),
                new Student("Miro", "Mirov", "fn531"),
                new Student("Spiro", "Mirov", "fn661"),
                new Student("Miro", "Spirov", "fn751"),
                new Student("Kiro", "Mirov", "fn881"),
                new Student("Miro", "Kirov", "fn971"),
                new Student("Baba", "Yaga", "fn001"),
            };


            var workers = new List<Worker>()
            {
                new Worker("An", "Han", 100, 8),
                new Worker("Hon", "Mon", 120, 8),
                new Worker("Gun", "Kan", 1100, 4),
                new Worker("Yan", "Dzan", 101, 8),
                new Worker("Sam", "Ham", 200, 8),
                new Worker("Ven", "Yon", 1200, 2),
                new Worker("Sho", "Dzu", 600, 8),
                new Worker("Koh", "Moh", 400, 8),
                new Worker("Shan", "Sham", 500, 6),
                new Worker("Dzer", "Mer", 600, 4),
            };

            students.OrderBy(s => s.FacultyNumber)
                .ToList()
                .ForEach(Console.WriteLine);
            Console.WriteLine();

            workers.OrderByDescending(w => w.MoneyPerHour())
                .ToList()
                .ForEach(Console.WriteLine);
            Console.WriteLine();

            var allHumans = new List<Human>().Concat(students).Concat(workers);
            allHumans.OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
