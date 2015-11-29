using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy
{
    class CompanyHierarchyExamples
    {
        static void Main()
        {
            var employees = new List<Employee>()
            {
                new Manager(001, "Kiro", "Spirov", 111111, Department.Production),
                new Manager(007, "Miro", "Kirov", 111113, Department.Marketing),
                new SalesEmployee(999, "Pesho", "Peshev", 340, Department.Sales),
                new SalesEmployee(899, "Ivan", "Ivanov", 370, Department.Accounting),
                new Developer(111, "Baba", "Yaga", 1000, Department.Production),
                new Developer(111, "Baba", "Marta", 2000, Department.Accounting),
            };

            foreach (var e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
