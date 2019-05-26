using ExpectedObjects;
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
		public void get_employee_age_greater_than_21()
		{
			var employees = RepositoryFactory.GetEmployees();
			// implement yourWhere
			var actual = YourOwnLinq.GetEmployeesAgeGreaterThan21(employees).ToList();

			var expected = new List<Employee>()
			{
				new Employee {Name = "Guy", Role = RoleType.Intern, MonthSalary = 140, Age = 22, WorkingYear = 0.3},
				new Employee {Name = "Vincent", Role = RoleType.Intern, MonthSalary = 150, Age = 22, WorkingYear = 0.3},
				new Employee {Name = "Kyo", Role = RoleType.Coach, MonthSalary = 250, Age = 33, WorkingYear = 2.1},
				new Employee {Name = "Amanda", Role = RoleType.CoachAssistant, MonthSalary = 200, Age = 25, WorkingYear = 2.0},
			};

			expected.ToExpectedObject().ShouldEqual(actual);
		}

		[TestMethod]
		public void get_employee_monthSalary_greater_than_120()
		{
			var employees = RepositoryFactory.GetEmployees();
			// implement GetEmployeesMonthSalaryBiggerThan120
			var actual = YourOwnLinq.GetEmployeesMonthSalaryBiggerThan120(employees).ToList();

			var expected = new List<Employee>()
			{
				new Employee {Name = "April", Role = RoleType.Intern, MonthSalary = 130, Age = 21, WorkingYear = 0.3},
				new Employee {Name = "Guy", Role = RoleType.Intern, MonthSalary = 140, Age = 22, WorkingYear = 0.3},
				new Employee {Name = "Vincent", Role = RoleType.Intern, MonthSalary = 150, Age = 22, WorkingYear = 0.3},
				new Employee {Name = "Kyo", Role = RoleType.Coach, MonthSalary = 250, Age = 33, WorkingYear = 2.1},
				new Employee {Name = "Amanda", Role = RoleType.CoachAssistant, MonthSalary = 200, Age = 25, WorkingYear = 2.0},
			};

			expected.ToExpectedObject().ShouldEqual(actual);
		}

		[TestMethod]
		public void get_product_owned_by_Prime_virus()
		{
			var products = RepositoryFactory.GetProducts();
			// implement GetEmployeesMonthSalaryBiggerThan120
			var actual = YourOwnLinq.GetProductOwnedByPrimeVirus(products).ToList();

			var expected = new List<Product>()
			{
				new Product {Id = 1, Cost = 11, Price = 110, TeamName = "PV"},
				new Product {Id = 2, Cost = 21, Price = 210, TeamName = "PV"},
				new Product {Id = 8, Cost = 18, Price = 780, TeamName = "PV"},
			};

			expected.ToExpectedObject().ShouldEqual(actual);
		}
	}
}