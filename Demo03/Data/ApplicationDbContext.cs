using Demo.Configurations;
using Demo.Data.Migrations;
using Demo.Models;
using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        

       =>     optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = .; Database = ApplicationCompany; Trusted_Connection = true ; TrustServerCertificate = true; Encrypt=true");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Fluent APIS for each  and every Model

           //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
           //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());




           
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeDepartments>  EmployeeDepartmentsView { get; set; }


    }
}
