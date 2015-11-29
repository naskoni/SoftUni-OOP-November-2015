using System;
using _2.Animals.Interfaces;

namespace _2.Animals
{
    abstract class Animal : ISoundProducible
    {
        private const string NameErrorMessage = "The field name cannot be empty!";
        private const string AgeErrorMessage = "Age must be positive number";

        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(NameErrorMessage);
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(AgeErrorMessage);
                }

                this.age = value;
            }
        }

        private Gender Gender { get; set; }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return $"I'm the {this.GetType().Name} {this.Name}, aged {this.Age}";
        } 
            
    }
}
