using System;

namespace _4.SoftwareUniversityLearningSystem
{
    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber,
            double averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of visits should be positive");
                }

                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, number of visits: {1}", base.ToString(), this.NumberOfVisits);
        }    
    }
}
