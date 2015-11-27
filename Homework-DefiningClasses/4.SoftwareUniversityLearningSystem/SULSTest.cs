using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftwareUniversityLearningSystem
{
    class SULSTest
    {
        static void Main()
        {
            List<Person> SULSdata = new List<Person>()
            {
                new SeniorTrainer("Spiro", "Spirov", 33),
                new JuniorTrainer("Kiro", "Kirov", 22),
                new GraduateStudent("Pesho", "Peshov", 77, 000001, 3.33),
                new GraduateStudent("Gosho", "Goshev", 77, 000002, 4.23),
                new DropoutStudent("Baba", "Yaga", 88, 000003, 6.00, "To fly more."),
                new DropoutStudent("Ivan", "Petrov", 18, 000006, 2.00, "No reason."),
                new OnsiteStudent("Yan", "Hon", 31, 000013, 3.50, "OOP", 2),
                new OnsiteStudent("Tzun", "Gvan", 19, 000019, 4.41, "OOP", 0),
                new OnlineStudent("Maria", "Georgieva", 21, 000119, 2.90, "OOP"),
                new OnlineStudent("Smilen", "Svilenov", 45, 000231, 3.80, "OOP"),
            };

            SULSdata.OfType<CurrentStudent>()
                .OrderBy(s => s.AverageGrade)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            SULSdata.OfType<DropoutStudent>()
                .ToList()
                .ForEach(s => s.ReApply());
        }
    }
}
