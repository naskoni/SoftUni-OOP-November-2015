using System;
using System.Collections.Generic;

namespace _1.CustomLinqExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(
            this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in collection)
            {
                bool condition = !predicate(item);
                if (condition)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate)
            where TSelector : IComparable<TSelector>
        {
            var result = new List<TSelector>();
            foreach (var item in collection)
            {
                result.Add(predicate(item));
            }

            var max = result[0];
            for (int i = 1; i < result.Count; i++)
            {
                if (result[i].CompareTo(max) > 0)
                {
                    max = result[i];
                }
            }

            return max;
        }
    }
}
