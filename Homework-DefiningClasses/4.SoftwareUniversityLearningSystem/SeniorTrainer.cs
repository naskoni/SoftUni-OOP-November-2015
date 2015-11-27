using System;
using _4.SoftwareUniversityLearningSystem.Interfaces;

namespace _4.SoftwareUniversityLearningSystem
{
    class SeniorTrainer : Trainer, IDelete
    {
        public SeniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string nameOfCourse)
        {
            Console.WriteLine("The course {0} has been deleted", nameOfCourse);
        }
    }
}
