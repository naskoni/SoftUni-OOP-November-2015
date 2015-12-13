using System;

namespace _3.AsynchronousTimer
{
    public class AsyncTimerExample
    {
        public static void Main()
        {
            Action<string> action = a =>
            {
                Console.WriteLine($"Print row - {a}");
            };
            var asyncTimer = new AsyncTimer(action, 10, 1000);
            asyncTimer.Run();
        }
    }
}
