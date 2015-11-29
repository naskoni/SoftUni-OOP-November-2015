using System;
using System.Text.RegularExpressions;

namespace _1.HumanStudentAndWorker
{
    class Student : Human
    {
        private const string FacultyNumberErrorMessage = "Faculty number must contain only " +
                        "latin letters and digits with lenght in range [5..10]";
        
        private string facultyNumber;
        
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        { 
            get { return this.facultyNumber; }
            set 
            {
                value = value ?? "";

                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]{5,10}$"))
                {
                    throw new ArgumentException(FacultyNumberErrorMessage);
                }

                this.facultyNumber = value;
            } 
        }

        public override string ToString()
        {
            return "Student: " + base.ToString() + ", Faculty number: " + this.FacultyNumber;
        }
    }
}
