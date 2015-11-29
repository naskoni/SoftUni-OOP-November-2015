namespace _3.CompanyHierarchy.Interfaces
{
    interface IEmployee : IPerson
    {
        decimal Salary { get; }

        Department DepartmentName { get; }
    }
}
