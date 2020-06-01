using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{

    class Program
    {

        static void Main(string[] args)
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("Once uppon a time");
            Console.WriteLine(txt.Substring(5,12));

            IEnumerable<int> array = new int[]{ 2, 3, 5, 10, 6, 1, 20, 15 };

            Console.WriteLine("Sum : {0}",array.SumExtention());
            Console.WriteLine("Product: {0}",array.ProductExtention());
            Console.WriteLine("Min : {0}",array.MinExtention());
            Console.WriteLine("Max : {0}",array.MaxExtention());
            Console.WriteLine("Average : {0}",array.AverageExtention());
        }
    }
}
