using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftwareUniversityLearningSystem
{
    class SeniorTrainer : Trainer
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
