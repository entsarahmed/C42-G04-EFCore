using Demo.Entities;
using Demo01.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Context
{

    //Connect SQL Server Service
    /// <summary>
    /// ////////////////////////////// All Configure  ////// NameSpace//////////////////////  Package /////*********
    /// </summary>
    internal class CompanyG01DbContext : DbContext/*Microsoft.EntityFrameworkCore*/ /*Microsoft.EntityFrameWorkCore.SqlServer         which SQL     /Database Provider*/

    {
/*          prameter Call constructor chain on Parameter in base 
        public CompanyG01DbContext():base()// make chaining //////////By Default Founded
        {

        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
            // optionsBuilder.UseSqlServer("Data Source = DESKTOP-7IBRQJ0; Initial Catalog = CompanyG01; Integrated Security = True");

        =>    optionsBuilder.UseSqlServer("Server = DESKTOP-7IBRQJ0; Database = CompanyG01; Trusted_Connection = True; TrustServerCertificate=Yes;");

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Product> Products { get; set; }

       

    }
}
