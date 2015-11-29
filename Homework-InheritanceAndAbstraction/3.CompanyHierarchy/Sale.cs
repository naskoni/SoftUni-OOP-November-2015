using _3.CompanyHierarchy.Interfaces;
using System;

namespace _3.CompanyHierarchy
{
    class Sale : ISale
    {
        private const string ProductNameErrorMessage = "The field Product name cannot be empty!";
        private const string PriceErrorMessage = "Price must be positive number";

        private string productName;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }

            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(ProductNameErrorMessage);
                }

                this.productName = value;
            }
        }

        public DateTime Date { get;  }        

        public decimal Price
        {
            get { return this.price; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(PriceErrorMessage);
                }

                this.price = value;
            }            
        }

        public override string ToString()
        {
            return $"{this.ProductName}, price: {this.Price:C}, sold: {this.Date}";
        }
    }
}
