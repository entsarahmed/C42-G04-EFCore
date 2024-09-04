using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Context
{
    static class SQLDataTypes
    {
        public static string Varchar => "varchar";
    }


    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// Send the DataInfo of Connection of DataBase [Server, Database , trusted-Connection , TrustServerCertificate]
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Company ; Trusted_Connection   = true ; TrustServerCertificate=True ");// if you Connect windows Authentication 
        }
        /// Public object Member property of type DbSet<Employee> => by Convension Dbset make a table [ Creation table ]
        ///
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent APIs for Each and every Model
            //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            //modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            /// modelBuilder.Entity<Department>()
            ///     .HasMany(D => D.Employees)
            ///     .WithOne(E => E.Department)
            ///     .HasForeignKey(E => E.DepartmentId)
            ///     .OnDelete(DeleteBehavior.Cascade);
            ///
            /// modelBuilder.Entity<Employee>()
            ///     .HasOne(E => E.Department)
            ///     .WithMany(D => D.Employees)
            ///     .HasForeignKey(E => E.DepartmentId)
            ///     .OnDelete(DeleteBehavior.Cascade);
            ///

            /// We can Make Fluent APIs Method If We Make Only one Navgiational Property 
            ///modelBuilder.Entity<Student>()
            ///    .HasMany(S => S.Courses)
            ///    .WithMany(c => c.Students);
            ///
            ///modelBuilder.Entity<Course>()
            ///    .HasMany(c => c.Students)
            ///    .WithMany(S => S.Courses);







        }






    public DbSet<Employee> Employees { get; set; }// Create table Employees by Using ByConvension Way
        public DbSet<Department> Departments { get; set; }








    }
}
