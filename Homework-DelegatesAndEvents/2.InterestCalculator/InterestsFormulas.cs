using System;

namespace _2.InterestCalculator
{
    public static class InterestsFormulas
    {
        private const int N = 12;

        public static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + (interest / 100) * years);
        }

        public static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * Math.Pow((1 + (interest / 100) / N), years * N);
        }
    }
}
