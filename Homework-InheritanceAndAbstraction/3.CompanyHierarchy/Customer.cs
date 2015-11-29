using _3.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private const string PurchaseAmountErrorMessage = "Purchase amount must be positive number";

        private decimal purchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal purchaseAmount)
            : base(id, firstName, lastName)
        {
            this.PurchaseAmount = purchaseAmount;
        }

        public decimal PurchaseAmount
        {
            get { return this.purchaseAmount; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(PurchaseAmountErrorMessage);
                }

                this.purchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, purchase amount: {this.PurchaseAmount:C}";
        }
    }
}
