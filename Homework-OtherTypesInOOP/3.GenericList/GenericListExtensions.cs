using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    public static class GenericListExtensions
    {
        public static T Min<T>(this IGenericList<T> list) where T : IComparable<T>
        {
            var min = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(min) < 0)
                {
                    min = list[i];
                }
            }

            return min;
        }

        public static T Max<T>(this IGenericList<T> list) where T : IComparable<T>
        {
            var max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
