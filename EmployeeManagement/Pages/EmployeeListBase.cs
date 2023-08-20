using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using EmployeeManagementModels;

namespace EmployeeManagement.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }


        private void LoadEmployees()
        {

        }
    }
}
