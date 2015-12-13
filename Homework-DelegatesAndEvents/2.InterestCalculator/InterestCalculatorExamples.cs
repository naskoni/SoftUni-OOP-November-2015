using System;

namespace _2.InterestCalculator
{
    public class InterestCalculatorExamples
    {
        static void Main()
        {
            var compoundInterest = new InterestCalculator(500, 5.6, -10, InterestsFormulas.GetCompoundInterest);
            Console.WriteLine(compoundInterest);

            var simpleInterest = new InterestCalculator(2500, 7.2, 15, InterestsFormulas.GetSimpleInterest);
            Console.WriteLine(simpleInterest);
        }
    }
}
