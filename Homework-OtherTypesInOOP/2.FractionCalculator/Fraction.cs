using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.FractionCalculator
{
    public struct Fraction
    {
        private const string DenominatorZeroErrorMessage = "The denominator cannot be 0";
        private const string OutOfRangeMessage = "The operation {0} is impossible, because nominator or denominator of the new fraction will be out of range {1}..{2}";

        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; private set; }

        public long Denominator
        {
            get { return this.denominator; }

            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException(DenominatorZeroErrorMessage);
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            try
            {
                var numerator = checked((fr1.Numerator * fr2.Denominator) + (fr1.Denominator * fr2.Numerator));
                var denominator = checked(fr1.Denominator * fr2.Denominator);
                return new Fraction(numerator, denominator);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException(string.Format(
                    OutOfRangeMessage, "addition", long.MinValue, long.MaxValue));
            }
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            try
            {
                long numerator = checked((fr1.Numerator * fr2.Denominator) - (fr1.Denominator * fr2.Numerator));
                long denominator = checked(fr1.Denominator * fr2.Denominator);
                return new Fraction(numerator, denominator);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException(string.Format(
                    OutOfRangeMessage, "subtraction", long.MinValue, long.MaxValue));
            }
        }


        public override string ToString()
        {
            return ((decimal)this.Numerator / this.Denominator).ToString();
        }
    }
}
