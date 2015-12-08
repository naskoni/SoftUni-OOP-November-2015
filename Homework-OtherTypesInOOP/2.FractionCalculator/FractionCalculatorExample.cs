using System;

namespace _2.FractionCalculator
{
    class FractionCalculatorExample
    {
        static void Main()
        {
            var fraction1 = new Fraction(22, 7);
            var fraction2 = new Fraction(40, 4);
            var result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);

            var fraction3 = new Fraction(long.MaxValue, long.MinValue);
            var fraction4 = new Fraction(long.MinValue, long.MaxValue);

            try
            {
                result = fraction3 + fraction4;
                Console.WriteLine(result);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                result = fraction3 - fraction4;
                Console.WriteLine(result);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var fraction5 = new Fraction(1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
