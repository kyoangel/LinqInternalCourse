using System;
using LinqInternalCourse.Models;
using System.Collections.Generic;

namespace LinqInternalCourse
{
    public static class YourOwnLinq
    {
        public static IEnumerable<T> KyoWhere<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            var enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate(current))
                {
                    yield return current;
                }
            }
        }

        [Obsolete]
        public static IEnumerable<Employee> GetEmployeesAgeGreaterThan25(IEnumerable<Employee> employees)
        {
            var enumerator = employees.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Age > 25)
                {
                    yield return enumerator.Current;
                }
            }
        }
    }
}