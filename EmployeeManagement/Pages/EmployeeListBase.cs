using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using EmployeeManagementModels;

namespace EmployeeManagement.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
           await Task.Run( LoadEmployees);
          
        }
        private void LoadEmployees()
            {
            System.Threading.Thread.Sleep(3000);
                Employee e1 = new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Hastings",
                    Email = "David@pragimtech.com",
                    DOB = new DateTime(1980, 10, 5),
                    Gender = Gender.Male,
                    DepartmentID = 1,
                    PhotoPath = "https://www.pragimtech.com/blog/contribute/article_images/1220200316205520/mary.png"
                };

                Employee e2 = new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Sam",
                    LastName = "Galloway",
                    Email = "Sam@pragimtech.com",
                    DOB = new DateTime(1981, 12, 22),
                    Gender = Gender.Male,
                    DepartmentID = 2,
                    PhotoPath = "images/sam.jpg"
                };

                Employee e3 = new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Mary",
                    LastName = "Smith",
                    Email = "mary@pragimtech.com",
                    DOB = new DateTime(1979, 11, 11),
                    Gender = Gender.Female,
                    DepartmentID = 3,
                    PhotoPath = "images/mary.png"
                };

                Employee e4 = new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Sara",
                    LastName = "Longway",
                    Email = "sara@pragimtech.com",
                    DOB = new DateTime(1982, 9, 23),
                    Gender = Gender.Female,
                    DepartmentID =4,
                    PhotoPath = "images/sara.png"
                };

                Employees = new List<Employee> { e1, e2, e3, e4 };
            }
        }
    }