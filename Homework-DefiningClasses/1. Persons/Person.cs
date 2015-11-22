using System;

namespace _1.Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        private const int MinLimit = 1;
        private const int MaxLimit = 100;

        public Person(string name, int age, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null) {}     

        public string Name 
        {
            get { return this.name; }

            set 
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The field name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < MinLimit || value > MaxLimit)
                {
                    throw new ArgumentException(string.Format("The field age must be in range {0} - {1}!", MinLimit, MaxLimit));
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
                {
                    throw new ArgumentException("This is not a valid email!");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person: name - {0}, age - {1}, email - {2}",
                this.Name, this.Age, this.Email ?? "don't have");
        }
    }
}
