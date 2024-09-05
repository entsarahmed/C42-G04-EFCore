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

    // internal class Employee
    //{
    //  public int Id { get; set; } //Public Numeric  property  "Id" || EntityId => EmployeeId"  --> PK Identity (1, 1)) 

    //   public string? EmpName { get; set; } //ReferenceType : Allow Null [Optional]

    //    public double Salary { get; set; }  //ValueType : Not Allow Null [Required]

    //   public int? Age { get; set; }//Nullable<int>  : Allow Null [Optional]


    //}




    //2. Data Annotations (Set Of Attributes)
    // [Table("Employees",Schema ="dbo")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }//(1,1)

        [Required(ErrorMessage = "Name is Required!!")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Length(10,50)]
        [MinLength(10)]
       // [StringLength(50, MinimumLength = 10)]
        public string? EmpName { get; set; } //ReferenceType : Allow Null [Optional]

        [Column(TypeName = "decimal(12,12)")]
        [DataType(DataType.Currency)]

        //[Column(TypeName = "money")]
        public double Salary { get; set; }  //ValueType : Not Allow Null [Required]

        [Range(22, 60)]
        [AllowedValues(20,30,40,50,60)]
        [DeniedValues(10,15)]
        public int? Age { get; set; }//Nullable<int>  : Allow Null [Optional]


        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [NotMapped]
        public double NetSalary =>  Salary - (Salary * .2); 

    }








}
