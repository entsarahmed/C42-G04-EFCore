using Demo04.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext dbContext = new NorthwindContext();
            #region Execute Raw SQL

            //1. Execute Select Statement : FromSqlRow(), FromSqlInterpolated()

            //var Count = 4;
            //var Customer = dbContext.Customers.FromSqlRaw("Select Top({0}) * from Customers", Count);

            //foreach (var cust in Customer)
            //    Console.WriteLine($"{cust.CompanyName}");


            //2.Execute Insert, Update, Delete Statements: ExecuteSqlRaw(), ExecuteSqlInterpolated

            //  var categoryId = 1;
            //  dbContext.Database.ExecuteSqlRaw("Update Categories Set  Name = 'New' where CategoryID = {0}", categoryId);

            //dbContext.Database.ExecuteSqlRaw($"Update Categories Set  Name = 'New' where CategoryID = {categoryId}");

            #endregion


        }
    }
}
