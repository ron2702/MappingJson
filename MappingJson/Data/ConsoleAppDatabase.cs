using MappingJson.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConsoleAppDatabase : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MappingJsonApp;Trusted_Connection=True;TrustServerCertificate=True");
    }

    public DbSet<Employee>? Employees { get; set; }
}
