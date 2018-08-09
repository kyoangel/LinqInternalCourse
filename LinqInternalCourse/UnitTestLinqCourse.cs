﻿using ExpectedObjects;
using LinqInternalCourse.Enums;
using LinqInternalCourse.Models;
using LinqInternalCourse.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqInternalCourse
{
    [TestClass]
    public class UnitTestLinqCourse
    {
        [TestMethod]
        public void get_employee_age_greater_than_25()
        {
            var employees = RepositoryFactory.GetEmployees();
            // implement GetEmployeesAgeGreaterThan25
            var actual = YourOwnLinq.GetEmployeesAgeGreaterThan25(employees).ToList();

            var expected = new List<Employee>()
            {
                new Employee {Name = "Joe", Role = RoleType.Engineer, MonthSalary = 100, Age = 44, WorkingYear = 2.6},
                new Employee {Name = "Tom", Role = RoleType.Engineer, MonthSalary = 140, Age = 33, WorkingYear = 2.6},
                new Employee {Name = "Kevin", Role = RoleType.Manager, MonthSalary = 380, Age = 55, WorkingYear = 2.6},
                new Employee {Name = "Bas", Role = RoleType.Engineer, MonthSalary = 280, Age = 36, WorkingYear = 2.6},
                new Employee {Name = "Mary", Role = RoleType.OP, MonthSalary = 180, Age = 26, WorkingYear = 2.6},
                new Employee {Name = "Joey", Role = RoleType.Engineer, MonthSalary = 250, Age = 40, WorkingYear = 2.6},
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void get_employee_monthSalary_greater_than_150()
        {
            var employees = RepositoryFactory.GetEmployees();
            // implement GetEmployeesMonthSalaryBiggerThan150
            var actual = YourOwnLinq.GetEmployeesMonthSalaryBiggerThan150(employees).ToList();

            var expected = new List<Employee>()
            {
                new Employee {Name = "Kevin", Role = RoleType.Manager, MonthSalary = 380, Age = 55, WorkingYear = 2.6},
                new Employee {Name = "Bas", Role = RoleType.Engineer, MonthSalary = 280, Age = 36, WorkingYear = 2.6},
                new Employee {Name = "Mary", Role = RoleType.OP, MonthSalary = 180, Age = 26, WorkingYear = 2.6},
                new Employee {Name = "Joey", Role = RoleType.Engineer, MonthSalary = 250, Age = 40, WorkingYear = 2.6},
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}