using System;
using LinqInternalCourse.Models;
using System.Collections.Generic;

namespace LinqInternalCourse
{
    public static class YourOwnLinq
    {
        public static IEnumerable<Employee> GetEmployeesMonthSalaryBiggerThan150(IEnumerable<Employee> employees, Func<Employee, bool> predicate)
        {
            var enumerator = employees.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

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