using MappingJson.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingJson.Service
{
    public class EmployeeService
    {
        private readonly ConsoleAppDatabase _dbContext;

        public EmployeeService(ConsoleAppDatabase dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveEmployees(List<Employee> employees)
        {
            try
            {
                _dbContext.Employees?.AddRange(employees);
                _dbContext.SaveChanges();
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving data: {ex.Message}");
            }
        }

        public void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Person name: {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
