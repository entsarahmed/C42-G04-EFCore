using Demo.Data;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo03.Data
{
    internal class CompanyDbcontextSeed
    {
        public static void Seed(ApplicationDbContext dbContext)
        {
            if (dbContext.Departments.Any())
            {
                var departmentsData = File.ReadAllText("./Demo/Data/DataSeed/departments.json");
                var departments = JsonSerializer.Deserialize<List<Department>>(departmentsData);


                if (departments?.Count > 0)
                {
                    foreach (var department in departments)
                    {
                        dbContext.Departments.Add(department);
                    }
                    dbContext.SaveChanges();

                }
            }

            if (dbContext.Employees.Any())
            {
                var employeesData = File.ReadAllText("./Demo/Data/DataSeed/employees.json");
                var employees = JsonSerializer.Deserialize<List<Employee>>(employeesData);


                if (employees?.Count > 0)
                {
                    foreach (var employee in employees)
                    {
                        dbContext.Employees.Add(employee);
                    }
                    dbContext.SaveChanges();

                }
            }


        }
    }
}
