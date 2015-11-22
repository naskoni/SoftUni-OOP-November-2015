using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PcCatalog
{
    class Component
    {
        private String name;
        private String details;
        private decimal price;

        public Component(String name, String details, decimal price) 
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(String name, decimal price)
            : this(name, null, price) 
        {
        }


        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("The field name cannot be empty");
                }

                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field details cannot be empty");
                }

                this.details = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The field price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.details == null)
            {
                sb.AppendLine("Component: " + this.Name + ", price: " + this.Price + " lv.");
            }
            else
            {
                sb.AppendLine("Component: " + this.Name + ", " + this.Details + ", price: " + this.Price + " lv.");
            }

            return sb.ToString();
        }
    }
}
