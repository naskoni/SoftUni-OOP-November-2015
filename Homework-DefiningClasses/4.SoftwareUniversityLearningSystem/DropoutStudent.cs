using System;

namespace _4.SoftwareUniversityLearningSystem
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age,
            int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The field Dropout reason cannot be null or empty.");
                }

                this.dropoutReason = value;
            }
        }

        public void ReApply()
        {
            Console.WriteLine("{0}, dropout reason: {1}", base.ToString(), this.DropoutReason);
        }    
    }
}