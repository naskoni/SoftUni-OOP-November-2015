using System;
using _4.SoftwareUniversityLearningSystem.Interfaces;

namespace _4.SoftwareUniversityLearningSystem
{
    abstract class Trainer : Person, ICreate
    {
        protected Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        { 
        }

        public void CreateCourse(string nameOfCourse)
        {
            Console.WriteLine("The course {0} has been created", nameOfCourse);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
