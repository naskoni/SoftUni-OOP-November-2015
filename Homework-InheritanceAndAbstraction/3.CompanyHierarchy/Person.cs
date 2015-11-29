using _3.CompanyHierarchy.Interfaces;
using System;

namespace _3.CompanyHierarchy
{
    abstract class Person : IPerson
    {
        private const string FirstNameErrorMessage = "The field First name cannot be empty!";
        private const string LastNameErrorMessage = "The field Last name cannot be empty!";
        private const string IdErrorMessage = "ID must be positive number";

        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(IdErrorMessage);
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(FirstNameErrorMessage);
                }

                this.firstName = value;
            }
        }    

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(FirstNameErrorMessage);
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Id} {this.GetType().Name} {this.FirstName} {this.LastName}";
        }
    }
}
