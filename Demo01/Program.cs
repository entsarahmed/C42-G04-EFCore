using Demo.Context;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyG01DbContext dbContext = new CompanyG01DbContext();        




            //CompanyG01DbContext dbContext = new CompanyG01DbContext();
            ////try
            ////{
            ////    /////////
            ////}

            ////finally
            ////{
            ////    dbContext.Dispose();
            ////}




        }
    }
}
