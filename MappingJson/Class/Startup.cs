using MappingJson.Controller;
using MappingJson.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingJson.Class
{
    public class Startup
    {
        public ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
            .AddSingleton<ConsoleAppDatabase>()
            .AddSingleton<EmployeeService>()
            .AddSingleton<EmployeeController>()
            .AddSingleton<JsonFileReader>()
            .BuildServiceProvider();
        }
    }
}
