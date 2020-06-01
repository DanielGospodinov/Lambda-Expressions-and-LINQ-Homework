using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    public static class IEnumerableExtention
    {
        public static T SumExtention<T> (this IEnumerable<T> array)
        {
            dynamic sum = 0;

            foreach (var element in array)
            {
                sum += element;
            }

            return sum;
        }

        public static T ProductExtention<T>(this IEnumerable<T> array)
        {
            dynamic product = 1;

            foreach (var element in array)
            {
                product *= element;
            }

            return product;
        }

        public static T MinExtention<T> (this IEnumerable<T> array)
        {
            dynamic min = array.First();

            foreach (var element in array)
            {
                if(min > element)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T MaxExtention<T>(this IEnumerable<T> array)
        {
            dynamic max = array.First();

            foreach (var element in array)
            {
                if (max < element)
                {
                    max = element;
                }
            }

            return max;
        }

        public static T AverageExtention<T> (this IEnumerable<T> array)
        {
            dynamic sum = 0;

            foreach (var element in array)
            {
                sum += element;
            }

            return sum/array.Count();
        }
    }
}
