using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    interface ISalesEmployee : IEmployee
    {
        IList<ISale> Sales { get; }
    }
}
