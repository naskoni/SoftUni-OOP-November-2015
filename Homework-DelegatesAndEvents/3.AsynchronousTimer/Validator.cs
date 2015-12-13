using System;

namespace _3.AsynchronousTimer
{
    public static class Validator
    {
        public static void ValidateNumber(dynamic value, string nameOfProperty)
        {
            if (value < 0)
            {
                throw new ArgumentException($"The field {nameOfProperty} cannot be negative");
            }
        }
    }
}