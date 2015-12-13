namespace _2.InterestCalculator
{
    public delegate double CalculateInterest(double sum, double interest, int years);

    public class InterestCalculator
    {
        private readonly CalculateInterest calcInterestDelegate;
        private double sum;
        private double interest;
        private int years;

        public InterestCalculator(double sum, double interest, int years,             CalculateInterest calcInterestDelegate)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.calcInterestDelegate = calcInterestDelegate;
        }

        private double Sum
        {
            get { return this.sum; }
            set
            {
                Validator.ValidateNumber(value, nameof(sum));
                this.sum = value;
            }
        }

        private double Interest
        {
            get { return this.interest; }
            set
            {
                Validator.ValidateNumber(value, nameof(interest));
                this.interest = value;
            }
        }

        private int Years
        {
            get { return this.years; }
            set
            {
                Validator.ValidateNumber(value, nameof(years));
                this.years = value;
            }
        }

        public override string ToString()
        {
            return $"{this.calcInterestDelegate(this.Sum, this.Interest, this.Years):F4}";
        }
    }
}
