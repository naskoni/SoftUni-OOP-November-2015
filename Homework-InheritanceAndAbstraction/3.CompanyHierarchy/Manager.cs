using _3.CompanyHierarchy.Interfaces;
using System.Collections.Generic;
using System;

namespace _3.CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        private const string EmployeeError = "This employee cannot be added.";

        private readonly IList<IEmployee> employees = new List<IEmployee>();

        public Manager(int id, string firstName, string lastName, decimal salary, Department departmentName)
            : base(id, firstName, lastName, salary, departmentName)
        {
        }

        public IEnumerable<IEmployee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(IEmployee employee)
        {
            if (employee.DepartmentName != this.DepartmentName)
            {
                throw new InvalidOperationException(EmployeeError);
            }

            this.employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            this.employees.Remove(employee);
        }
    }
}
    