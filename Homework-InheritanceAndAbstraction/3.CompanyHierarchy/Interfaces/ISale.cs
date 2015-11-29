using System;

namespace _3.CompanyHierarchy.Interfaces
{
    interface ISale
    {
        string ProductName { get; }

        DateTime Date { get; }

        decimal Price { get;  }
    }
}
