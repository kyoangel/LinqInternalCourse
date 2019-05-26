using System.Collections.Generic;
using LinqInternalCourse.Enums;
using LinqInternalCourse.Models;

namespace LinqInternalCourse.Utilities
{
    internal class RepositoryFactory
    {
        public static IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee {Name = "Steven", Role = RoleType.Intern, MonthSalary = 100, Age = 20, WorkingYear = 0.3},
                new Employee {Name = "Ben", Role = RoleType.Intern, MonthSalary = 110, Age = 20, WorkingYear = 0.3},
                new Employee {Name = "Sherry", Role = RoleType.Intern, MonthSalary = 120, Age = 21, WorkingYear = 0.3},
                new Employee {Name = "April", Role = RoleType.Intern, MonthSalary = 130, Age = 21, WorkingYear = 0.3},
                new Employee {Name = "Guy", Role = RoleType.Intern, MonthSalary = 140, Age = 22, WorkingYear = 0.3},
                new Employee {Name = "Vincent", Role = RoleType.Intern, MonthSalary = 150, Age = 22, WorkingYear = 0.3},
                new Employee {Name = "Kyo", Role = RoleType.Coach, MonthSalary = 250, Age = 33, WorkingYear = 2.1},
                new Employee {Name = "Amanda", Role = RoleType.CoachAssistant, MonthSalary = 200, Age = 25, WorkingYear = 2.0},
            };
        }
    }
}