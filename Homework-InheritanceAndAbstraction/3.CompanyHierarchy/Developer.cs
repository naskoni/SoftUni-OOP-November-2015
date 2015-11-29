using _3.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        private readonly IList<IProject> projects = new List<IProject>();

        public Developer(int id, string firstName, string lastName, decimal salary, Department departmentName)
            : base(id, firstName, lastName, salary, departmentName)
        {
        }

        public IList<IProject> Projects
        {
            get { return this.projects; }
        }
    }
}
