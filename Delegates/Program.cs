using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(4, 1000, Timer.Print);
            timer.Execute();
        }
    }
}
