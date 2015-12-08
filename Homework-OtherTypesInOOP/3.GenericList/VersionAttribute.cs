using System;

namespace _3.GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
    public class VersionAttribute : Attribute
    {
        private const string CannotBeNegative = "{0} number cannot be negative";

        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get { return this.major; }

            private set
            {
                ValidateValue(value, "Major");
                this.major = value;
            }
        }

        public int Minor
        {
            get { return this.minor; }

            private set
            {
                ValidateValue(value, "Minor");
                this.minor = value;
            }
        }

        private void ValidateValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    name, string.Format(CannotBeNegative, name));
            }
        }
    }
}
