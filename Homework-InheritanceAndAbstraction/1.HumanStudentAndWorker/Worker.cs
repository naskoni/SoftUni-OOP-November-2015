using System;
using _1.HumanStudentAndWorker.Interfaces;

namespace _1.HumanStudentAndWorker
{
    class Worker : Human, IMoneyPerHour
    {
        private const int WorkDaysInWeek = 5;
        private const string WeekSalaryErrorMessage = "Week salary must be positive number";
        private const string WorkHoursPerDayErrorMessage = "Work hours must be in range [0..12]";

        private decimal weekSalary;
        private double workHoursPerDay;
        
        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {                
                if (value < 0)
                {
                    throw new ArgumentException(WeekSalaryErrorMessage);
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(WorkHoursPerDayErrorMessage);
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return WeekSalary / (decimal)(WorkHoursPerDay * WorkDaysInWeek);
        }

        public override string ToString()
        {
            return string.Format("Worker: {0}, Money per hour: {1:C})",
                base.ToString(), this.MoneyPerHour());
        }
    }
}
