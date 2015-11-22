using System;

namespace _4.SoftwareUniversityLearningSystem
{
    abstract class CurrentStudent : Student
    {
        private string currentCourse;

        protected CurrentStudent(string firstName, string lastName, int age,
            int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            
            get 
            {
                return this.currentCourse;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The field Course name cannot be empty.");
                }

                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, current course: {1}", base.ToString(), this.CurrentCourse);
        }
    }
}
