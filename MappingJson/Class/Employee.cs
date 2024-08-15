using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MappingJson.Class
{
    public class Employee
    {
        [JsonIgnore]
        public int EmployeeId { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        public Employee() { }

        public Employee(int employeeId, string firstName, string lastName, string gender)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}
