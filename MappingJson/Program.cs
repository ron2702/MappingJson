using MappingJson.Class;
using System.Text.Json;

var personList = new List<Employee>();

using (StreamReader r = new StreamReader("MOCK_DATA.json"))
{
    string json = r.ReadToEnd();
    personList = JsonSerializer.Deserialize<List<Employee>>(json);
}

if (personList != null && personList.Count > 0 )
{
    foreach(Employee person in personList)
    {
        Console.WriteLine($"Person name {person.FirstName} {person.LastName}");
    }
}

Console.WriteLine($"Saving Data....");

var db = new ConsoleAppDatabase();
db.Employees?.AddRange(personList);
db.SaveChanges();

Console.WriteLine($"Data Saved");
Console.Read();