using Demo.Data;
using Demo.Data.Migrations;
using Demo.Models;
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



            #region 3. Lazy Loading

            //Decrease Count of Request on Server
            //Implicitly Loading
            #region Example 01

            var employee = (from E in dbContext.Employees
                            where E.Id ==1
                            select E).FirstOrDefault();

            if (employee is not null)
            {
                //    // Get Data in Request and Related Data in Another Request




                Console.WriteLine($"Employee: Name = {employee.Name}, Department ={employee.Department?.Name ?? "NA"}");
            }

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

            ///                             make inner join   
            #region LINQ - Join Operators [Join() - GroupJoin()]//Make join then Grouping

            #region Inner Join
            //var Result = from D in dbContext.Departments
            //             join E in dbContext.Employees
            //             on D.Id equals E.DepartmentId
            //             select new
            //             {

            //                 EmployeeId = E.Id,
            //                 EmployeeName = E.Name,
            //                 DepartmentId = D.Id,
            //                 DepartmentName = D.Name,


            //             };

            //Result =dbContext.Departments.Join(dbContext.Employees,
            //    D => D.Id,
            //    E => E.DepartmentId,
            //    (D, E) => new
            //    {
            //        EmployeeId = E.Id,
            //        EmployeeName = E.Name,
            //        DepartmentId = D.Id,
            //        DepartmentName = D.Name,

            //    });

            //foreach ( var item in Result )
            //    Console.WriteLine($"Employee { item.EmployeeName},Department: {item.DepartmentName}");

            #endregion

            #region Join Operators - GroupJoin
            #region Example01
            //var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
            //                                             D => D.Id,
            //                                             E => E.DepartmentId,
            //                                             (D, Employees) => new
            //                                             {
            //                                                 Department=D,
            //                                                 Employees
            //                                             }).Where(X => X.Employees.Count() > 0);




            //Result = from D in dbContext.Departments
            //         join E in dbContext.Employees
            //         on D.Id equals E.DepartmentId into Emps
            //         select new
            //         {

            //             Department = D,
            //             Employees = Emps,

            //         } into X
            //         where X.Employees.Count() > 0
            //         select X;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Department: Id = {item.Department.Id}, Name = { item.Department}");

            //foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($"Employee: Id =  {emp.Id}, Name = {emp.Name}");
            //    }

            //} 
            #endregion



            #region Example02

            //var Result = dbContext.Employees.GroupJoin(dbContext.Departments,
            //                                                       E => E.DepartmentId,
            //                                                       D => D.Id,

            //                                                       (Employee, Departments) => new
            //                                                       {
            //                                                           Employee,
            //                                                           Departments,
            //                                                       }

            //                                                       ).Where(X => X.Departments.Count() > 0);

            //Result =from E in dbContext.Employees
            //        join D in dbContext.Departments
            //        on E.DepartmentId equals D.Id into Depts

            //        select new
            //        {
            //            Employee = E,
            //            Departments = Depts,

            //        } into X
            //        where X.Departments.Count()>0
            //        select X;
            //foreach(var item in Result)
            //{
            //    Console.WriteLine($" Employee: Id = {item.Employee.Id}, Name = { item.Employee.Name}");
            //    foreach (var department in item.Departments)
            //        Console.WriteLine($"Department Id : {department.Id}, Name= {department.Name}");
            //}
            #endregion





            #endregion



            #region Left Outer Join

            #region Example01
            //var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
            //                                           D => D.Id,
            //                                           E => E.DepartmentId,
            //                                           (Department, Employees) => new
            //                                           {
            //                                               Department,
            //                                               Employees = Employees.Count() == 0 ? Employees:(new Employee[1] { null!}).AsEnumerable()

            //                                           }).SelectMany(X => X.Employees,(X,Employee) => new {X.Department,Employee});



            //Result =from D in dbContext.Departments
            //        join E in dbContext.Employees
            //        on D.Id equals E.DepartmentId into Employees
            //        select new
            //        {
            //            Department = D,
            //            Employees = Employees.DefaultIfEmpty()
            //        } into X
            //        from Employee in X.Employees
            //        select new { X.Department, Employee };
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine($"Department: Id {Item.Department.Id} Name = {Item.Employee.Name ?? "No Employee" }");
            //}


            #endregion

            #region Example 02
            //var Result = dbContext.Employees.GroupJoin(dbContext.Departments,
            //    E => E.DepartmentId,
            //    D => D.Id,
            //    (Employee, Departments) => new
            //    {
            //        Employee,
            //        Departments = Departments.DefaultIfEmpty()
            //    }
            //    ).SelectMany(X => X.Departments,(X,Department) => new {X.Employee,Department});

            //Result = from E in dbContext.Employees
            //         join D in dbContext.Departments
            //         on E.DepartmentId equals D.Id into Departments
            //         select new
            //         {
            //             Employee = E,
            //             Departments = Departments.DefaultIfEmpty()
            //         } into X
            //         from Department in X.Departments
            //         select new
            //         {
            //             X.Employee,
            //             Department,
            //         };




            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Employee: {item.Employee.Name}, Department: {item.Department?.Name ?? "No Department" }");
            //} 
            #endregion
            #endregion


            #region Cross Join

            //var Result = from E in dbContext.Employees
            //             from D in dbContext.Departments
            //             select new
            //             {
            //                 Employee = E,
            //                 Department = D
            //             };
            //Result  =dbContext.Employees.SelectMany(E => dbContext.Departments.Select(D => new
            //{
            //    Employee = E,
            //    Department = D

            //}));

            //foreach (var item in Result)
            //    Console.WriteLine($"Employee: {item.Employee.Name}, Department: {item.Department.Name}");

            #endregion


            #endregion


            
            #region View Mapping
        var Result = dbContext.EmployeeDepartmentsView;
            foreach (var item in Result)
                Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentName}");

            #endregion



        }
    }
}
