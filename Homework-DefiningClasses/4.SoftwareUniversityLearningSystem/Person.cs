using System;

namespace _4.SoftwareUniversityLearningSystem
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The field First name cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The field Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age should be in range 1 - 100.");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " age - " + this.age;
        }
    }
}
