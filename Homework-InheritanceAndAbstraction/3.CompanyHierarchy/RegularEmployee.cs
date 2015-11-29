namespace _3.CompanyHierarchy
{
    abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(int id, string firstName, string lastName, decimal salary, Department departmentName)
            : base(id, firstName, lastName, salary, departmentName)
        {
        }
    }
}
