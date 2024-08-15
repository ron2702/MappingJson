using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MappingJson.Class
{
    public class JsonFileReader
    {
        public List<Employee> ReadEmployeesFromJson(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();

                var employeeList = JsonSerializer.Deserialize<List<Employee>>(json);

                return employeeList ?? new List<Employee>();
            }
        }
    }
}
