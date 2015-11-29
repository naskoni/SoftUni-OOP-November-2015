using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    interface IManager : IEmployee
    {
        IEnumerable<IEmployee> Employees { get; }

        void AddEmployee(IEmployee employee);

        void RemoveEmployee(IEmployee employee);
    }
}
