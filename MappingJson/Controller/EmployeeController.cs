using MappingJson.Class;
using MappingJson.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingJson.Controller
{
    public class EmployeeController
    {
        private readonly EmployeeService _employeeService;
        private readonly JsonFileReader _jsonFileReader;

        public EmployeeController(EmployeeService employeeService, JsonFileReader jsonFileReader)
        {
            _employeeService = employeeService;
            _jsonFileReader = jsonFileReader;
        }

        public void ProcessAndSaveEmployees(string jsonFilePath)
        {
            var employees = _jsonFileReader.ReadEmployeesFromJson(jsonFilePath);

            if (employees != null)
            {
                _employeeService.PrintEmployees(employees);
                _employeeService.SaveEmployees(employees);
            }
            else
            {
                Console.WriteLine("No employees found in the JSON file.");
            }
        }
    }
}
