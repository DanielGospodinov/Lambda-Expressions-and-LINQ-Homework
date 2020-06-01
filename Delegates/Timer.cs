using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegates
{
    public delegate void PrintText();
    class Timer
    {
        private long duration;
        private int interval;
        private PrintText printText;
        
        public Timer(long duration, int interval, PrintText printText)
        {
            this.duration = duration;
            this.interval = interval;
            this.printText = printText;
        }

        public long Duration
        {
            set { this.duration = value; }
            get { return this.duration; }
        }

        public int Interval
        {
            set { this.interval = value; }
            get { return this.interval; }
        }

        public PrintText PrintText
        {
            set { this.printText = value; }
            get { return this.printText; }
        }

        public void Execute()
        {
            for (int i = 0; i < this.duration; i++)
            {
                Thread.Sleep(this.interval);
                this.PrintText();
            }
        }

        public static void Print()
        {
            Console.WriteLine("Text!!!");
        }
    }
}
