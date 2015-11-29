namespace _3.CompanyHierarchy.Interfaces
{
    interface ICustomer : IPerson
    {
        decimal PurchaseAmount { get; }
    }
}
