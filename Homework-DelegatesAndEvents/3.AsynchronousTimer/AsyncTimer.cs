using System;
using System.Threading;

namespace _3.AsynchronousTimer
{
    public class AsyncTimer
    {
        private int ticks;
        private int timeInterval;

        public AsyncTimer(Action<string> action, int ticks, int timeInterval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.TimeInterval = timeInterval;
        }

        public Action<string> Action { get; private set; }

        public int Ticks
        {
            get { return this.ticks; }

            private set
            {
                Validator.ValidateNumber(value, nameof(ticks));
                this.ticks = value;
            }
        }

        public int TimeInterval
        {
            get { return this.timeInterval; }

            private set
            {
                Validator.ValidateNumber(value, nameof(timeInterval));
                this.timeInterval = value;
            }
        }

        public void Run()
        {
            var parallel = new Thread(this.Execute);
            parallel.Start();
        }

        private void Execute()
        {
            for (int i = 1; i <= this.ticks; i++)
            {
                Thread.Sleep(this.timeInterval);
                Action($"{i}");
            }
            ;
        }
    }
}
