using System.Collections.Generic;

namespace System.Linq
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int, bool> action)
        {
            var list = source.ToList();
            
            for (int i = 0; i < list.Count; i++)
            {
                action(list[i], i, i == list.Count - 1);
            }
        }
    }
}
