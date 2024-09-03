using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Demo.Entities
{

    //Ef Core Supports 4 Ways for Mapping Classes(DbContext, Models) to Database(Tables, Views)

    // => only property -no Implement interface --> represent table 

    ///EF Core Supports 4 Ways for Mapping
    ///1. By Convension (Default Behaviour) => no  effort - no anything
   

    /// <summary>
    /// //POCO  Class
    ///  Plain OLD C# (CLR) Object => object no found behaviour and functionality
    /// </summary>
    /// 

    //All property represent column in table




    ///1. By Convension(Default Behaviour)

     internal class Employee
    {
      public int Id { get; set; } //Public Numeric  property  "Id" || EntityId => EmployeeId"  --> PK Identity (1, 1)) 

       public string? EmpName { get; set; } //ReferenceType : Allow Null [Optional]
    
        public double Salary { get; set; }  //ValueType : Not Allow Null [Required]
   
       public int? Age { get; set; }//Nullable<int>  : Allow Null [Optional]


    }







}
