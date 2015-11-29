using System;

namespace _1.HumanStudentAndWorker
{
    abstract class Human
    {
        private const string FirstNameErrorMessage = "The field First name cannot be empty!";
        private const string LastNameErrorMessage = "The field Last name cannot be empty!";

        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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

            set
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
            return this.FirstName + " " + this.LastName;
        }
            
    }
}
