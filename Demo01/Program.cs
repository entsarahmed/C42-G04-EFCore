using Demo.Context;
using Microsoft.EntityFrameworkCore;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyG01DbContext dbContext = new CompanyG01DbContext();        

            var employees =dbContext.Employees.Where(E => E.Age > 20).ToList();


            //CompanyG01DbContext dbContext = new CompanyG01DbContext();
            ////try
            ////{
            ////    /////////
            ////}

            ////finally
            ////{
            ////    dbContext.Dispose();
            ////}



            dbContext.Database.Migrate();



        }
    }
}
