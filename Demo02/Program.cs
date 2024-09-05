namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operation

            //using CompanyDbContext dbContext = new CompanyDbContext();
            // CRUD Operations

            // dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll; // Default Behaviour Of change Tracker 

            #region Insert
            //Employee E01 = new Employee() { EmpName = "Ahmed", Age = 22, Salary = 3_000, Email = "Ahmed@gmail.com" };
            //Employee E02 = new Employee() { EmpName = "sara",  Age = 20, Salary = 12_000, Email = "Sara@gmail.com" };

            //Console.WriteLine( dbContext.Entry(E01).State); // Detached

            //dbContext.Employees.Add(E01);
            //dbContext.Employees.Add(E02);
            ///// dbContext.Set<Employee>().Add(E01);
            ///// dbContext.Add(E01);
            ///// dbContext.Entry(E01).State= EntityState.Added;

            //Console.WriteLine(dbContext.Entry(E01).State); // Added


            //dbContext.SaveChanges(); // To save Changes in Database 


            //Console.WriteLine(dbContext.Entry(E01).State); // UnChanged
            //Console.WriteLine("========================================");

            //Console.WriteLine($"Employee 01  : {E01.Id}");
            //Console.WriteLine($"Employee 02  : {E02.Id}"); 
            #endregion

            #region Select [Retrieve]

            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var Employee = (from E in dbContext.Employees
            //                 where E.Id == 1
            //                 select E).AsTracking().FirstOrDefault(); //FirstOrDefault =>  Select Top(1) , SingleOrDefault() => Select top ( 2 )

            //    Console.WriteLine(Employee?.EmpName??"NA");

            //Console.WriteLine(dbContext?.Entry(Employee).State); //Tracking State =>  UnChanged 
            #endregion

            #region Update 
            //var Employee = (from E in dbContext.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();
            //if (Employee is not  null)
            //{
            //    Console.WriteLine ( dbContext.Entry(Employee).State ) ;// unchanged

            //    Employee.EmpName = "Hamada"; // Unpdate 

            //    Console.WriteLine(dbContext.Entry(Employee).State);// Modified

            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(Employee).State);// Unchanged 

            //}


            #endregion

            #region Delete
            ///  // Select Object
            ///  var employee = (from E in dbContext.Employees
            ///                 where E.Id == 1
            ///                 select E).FirstOrDefault();
            ///  //Check On Object 
            ///  if (employee != null)
            ///  {
            ///      Console.WriteLine(dbContext.Entry(employee).State); // Unchanged
            ///  
            ///  
            ///      dbContext.Employees.Remove(employee);
            ///      //  dbContext.Remove(employee);
            ///      //  dbContext.Set<Employee>().Remove(employee);
            ///      //  dbContext.Remove(employee);
            ///      //  dbContext.Entry(employee).State = EntityState.Deleted;
            ///  
            ///  
            ///      Console.WriteLine(dbContext.Entry(employee).State);// Deleted
            ///      dbContext.SaveChanges();
            ///      Console.WriteLine(dbContext.Entry(employee).State);// Unchanged
            ///  
            ///  
            ///  }

            #endregion

            ///CompanyDbContext dbContext = new CompanyDbContext();
            ///try
            ///{
            ///    // CRUD Operations 
            ///}
            ///finally
            ///{
            ///    dbContext.Dispose(); //[ Dispose | Release | Close ] DataBase Connection 
            ///}

            #endregion        }




        }
    }
}
