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



        }
    }
}
