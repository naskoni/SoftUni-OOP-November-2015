using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EnterNumbers
{
    class EnterNumbers
    {
        private const int Min = 2;
        private const int Max = 100;
        private const int NumbersCount = 10;

        static void Main(string[] args)
        {
            int[] numbers = new int[NumbersCount];
            int start = Min;
            int end = Max - NumbersCount;
            for (int i = 0; i < NumbersCount; i++)
            {                
                int currentNumber = ReadNumber(start, end);
                numbers[i] = currentNumber;
                start = currentNumber + 1;
                end++;
            }

            Console.WriteLine("Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();  
        }

        private static int ReadNumber(int start, int end)
        {
            Console.WriteLine($"{{Enter number in range {start}..{end} (inclusive)}}");
            bool isValudNumber = false;
            int number = 0;
            while (!isValudNumber)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < start || number > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    isValudNumber = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("The number entered is out of range, please try again.");
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("This is not a number, please try again.");
                }
            }            
            
            return number;
        }
    }
}
