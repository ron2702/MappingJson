using MappingJson.Class;
using MappingJson.Controller;
using MappingJson.Service;
using Microsoft.Extensions.DependencyInjection;

// This will call the Startup class and configure the services
var startup = new Startup();
var serviceProvider = startup.ConfigureServices();

var employeeController = serviceProvider.GetService<EmployeeController>();
employeeController?.ProcessAndSaveEmployees("MOCK_DATA.json");

Console.ReadKey();
