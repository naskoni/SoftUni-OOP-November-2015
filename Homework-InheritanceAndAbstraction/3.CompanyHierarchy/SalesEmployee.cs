using _3.CompanyHierarchy.Interfaces;
using System.Collections.Generic;

namespace _3.CompanyHierarchy
{
    class SalesEmployee : RegularEmployee
    {
        private readonly IList<ISale> sales = new List<ISale>();

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department departmentName)
            : base(id, firstName, lastName, salary, departmentName)
        {
        }

        public IList<ISale> Sales
        {
            get { return this.sales; }
        }
    }
}
