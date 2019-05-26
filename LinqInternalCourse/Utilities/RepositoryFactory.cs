using System.Collections.Generic;
using LinqInternalCourse.Enums;
using LinqInternalCourse.Models;

namespace LinqInternalCourse.Utilities
{
    internal partial class RepositoryFactory
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

        public static IEnumerable<Product> GetProducts()
        {
	        return new List<Product>
	        {
		        new Product {Id = 1, Cost = 11, Price = 110, TeamName = "PV"},
		        new Product {Id = 2, Cost = 21, Price = 210, TeamName = "PV"},
		        new Product {Id = 3, Cost = 31, Price = 310, TeamName = "BC"},
		        new Product {Id = 4, Cost = 41, Price = 410, TeamName = "Odd-e"},
		        new Product {Id = 5, Cost = 51, Price = 510, TeamName = "GC"},
		        new Product {Id = 6, Cost = 61, Price = 610, TeamName = "DF"},
		        new Product {Id = 7, Cost = 71, Price = 710, TeamName = "Mi"},
		        new Product {Id = 8, Cost = 18, Price = 780, TeamName = "PV"},
	        };
        }

        public static IEnumerable<ColorBall> GetBalls()
        {
	        return new List<ColorBall>
	        {
		        new ColorBall{Color=Color.Blue, Size="L", Prize=200},
		        new ColorBall{Color=Color.Purple, Size="L", Prize=350},
		        new ColorBall{Color=Color.Yellow, Size="S", Prize=300},
		        new ColorBall{Color=Color.Purple, Size="S", Prize=500},
		        new ColorBall{Color=Color.Purple, Size="L", Prize=450},
		        new ColorBall{Color=Color.Yellow, Size="M", Prize=500},
	        };
        }
    }
}