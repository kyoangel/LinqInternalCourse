using LinqInternalCourse.Models;
using System.Collections.Generic;

namespace LinqInternalCourse
{
    public class WithoutLinq
    {
        public IEnumerable<Employee> GetEmployeesMonthSalaryGreaterThan150(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee.MonthSalary > 150)
                {
                    yield return employee;
                }
            }
        }

        public IEnumerable<Employee> GetEmployeesAgeGreaterThan25(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee.Age > 25)
                {
                    yield return employee;
                }
            }
        }
    }
}