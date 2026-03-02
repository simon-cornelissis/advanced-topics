using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class LinqExtensions
    {

        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }


        public static List<T> ToList<T>(this IEnumerable<T> source)
        {
            return new List<T>(source);

        }
    }
}
