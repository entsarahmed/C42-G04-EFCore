using Demo.Data;
using Demo.Data.Migrations;
using Demo03.Data;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using ApplicationDbContext dbContext = new ApplicationDbContext();

            //CompanyDbcontextSeed.Seed(dbContext);

            #region Loading Navigational Properties
            #region Example 01

            //var employee =(from E in dbContext.Employees
            //              where E.Id ==1
            //             select E).FirstOrDefault();

            //if (employee is not null)
            //{
            //    // Get Data in Request and Related Data in Another Request




            //    Console.WriteLine($"Employee: Name = {employee.Name}, Department ={employee.Department?.Name ?? "NA"}");
            //}

            #endregion


            #region Example 02
            //var department =(from D in dbContext.Departments
            //                 where D.Id == 10
            //                 select D).FirstOrDefault();
            //if (department != null)
            //{


            //    Console.WriteLine($"Department: Id = {department.Id}, Name = {department.Name}");


            //    foreach(var employee in department.Employees)
            //        Console.WriteLine($"......Employee: Id = {employee.Id}, Name = {employee.Name}");
            //} 
            #endregion

            #endregion


            #region 1. Explicit Loading
            #region Example 01

            //var employee =(from E in dbContext.Employees
            //              where E.Id ==1
            //             select E).FirstOrDefault();

            //if (employee is not null)
            //{
            //    // Get Data in Request and Related Data in Another Request

            //    dbContext.Entry(employee).Reference(E => E.Department).Load(); // Loading Explicitly



            //    Console.WriteLine($"Employee: Name = {employee.Name}, Department ={employee.Department?.Name ?? "NA"}");
            //}

            #endregion



            #region Example 02
            //var department =(from D in dbContext.Departments
            //                 where D.Id == 10
            //                 select D).FirstOrDefault();
            //if (department != null)
            //{


            //    Console.WriteLine($"Department: Id = {department.Id}, Name = {department.Name}");


            //    dbContext.Entry(department).Collection(D => D.Employees).Load();//Explicit Loading
            //    foreach(var employee in department.Employees)
            //        Console.WriteLine($"......Employee: Id = {employee.Id}, Name = {employee.Name}");
            //} 
            #endregion
            #endregion


            #region 2. Eager Loading

            #region Example 01
            //                                            Eager Loading
            //var employee =(from E in dbContext.Employees.Include(E => E.Department)//.ThenInclude(D => D.Project)
            //             where E.Id ==1
            //            select E).FirstOrDefault();

            //if (employee is not null)
            //{
            ////    // Get Data in Request and Related Data in Another Request




            //   Console.WriteLine($"Employee: Name = {employee.Name}, Department ={employee.Department?.Name ?? "NA"}");
            //}

            #endregion


            #region Example 02
            //var department =(from D in dbContext.Departments.Include(D => D.Employees)
            //                 where D.Id == 10
            //                 select D).FirstOrDefault();
            //if (department != null)
            //{


            //    Console.WriteLine($"Department: Id = {department.Id}, Name = {department.Name}");


            //    foreach(var employee in department.Employees)
            //        Console.WriteLine($"......Employee: Id = {employee.Id}, Name = {employee.Name}");
            //} 
            #endregion

            #endregion


        }
    }
}
