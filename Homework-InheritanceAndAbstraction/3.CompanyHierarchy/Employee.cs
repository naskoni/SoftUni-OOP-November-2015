using _3.CompanyHierarchy.Interfaces;
using System;

namespace _3.CompanyHierarchy
{
    abstract class Employee : Person, IEmployee
    {
        private const string salaryErrorMessage = "Salary must be positive number";

        private decimal salary;

        protected Employee(int id, string firstName, string lastName, decimal salary, Department departmentName)
            :base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.DepartmentName = departmentName;
        }

        public Department DepartmentName { get; }

        public decimal Salary
        {
            get { return this.salary; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(salaryErrorMessage);
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Salary: {this.Salary:C}, Department: {this.DepartmentName}";
        }
    }
}
