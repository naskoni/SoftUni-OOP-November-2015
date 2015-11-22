using System;

namespace _4.SoftwareUniversityLearningSystem
{
    abstract class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        protected Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student number should be > 0");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Student average grade should be in range 2 - 6.");
                }

                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, student number: {1}, average grade: {2:F2}", base.ToString(), this.StudentNumber, this.AverageGrade);
        }
    }
}
