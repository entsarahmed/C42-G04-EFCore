using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Entities
{
    // EF Cre Support 4 Ways For Mapping Classes(DbContext, Models) to Database(Tables, Views) 
    // 1. By Convension ( Default Behaviour)
    // 2. DataAnnotation (Set of Attributes Will Be used for Validations  )
    // 3. Fluent APIS ( Set of Methods ) -->  [ DbContext  : Override OnModelCreating( ) ]
    // 4. ConfigurationClass             --> [ Organize for 3rd Way Fluent API ]  



    /// 1. By Convension 
    /// Poco Class => [ Plain old c# (CLR) Object ] 
    ///
    ///class Employee
    ///
    ///{
    ///
    ///    public int Id { get; set; }         // Public Numeric Property Named "Id" || "EmployeeId" --> PrimaryKey [ Identity(1,1) ]
    ///
    ///    public string? EmpName { get; set; }   // ReferenceType : Allow Null [ Optional ]
    ///
    ///    public double Salary { get; set; }  // ValueType : Not Allow Null [ Required ]
    ///
    ///    public int? Age { get; set; }       // Nullable<int> ValueType : Allow Null [ Optional ]
    ///
    ///}

    ///2 Data Annotation 
    ///[Table("Employees" , Schema ="dbo" )]
    class Employee

    {

        [Key] // make property as a primarykey 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// (1,1) / TO make property use Identity Constriant ( 1,1 ) by Convension Start by 1 , Increment by 1  
        public int Id { get; set; }             // Public Numeric Property Named "Id" || "EmployeeId" --> PrimaryKey [ Identity(1,1) ]
       //[Required]
        [Column(TypeName = "varchar")]          // To make this property Will be Mapped to datatype "varchar" insteadof "nvarchar"
        [MaxLength(50)]                         // this Data Annotation For Validation 
        [StringLength(50, MinimumLength = 10)]  // this Data Annotation For Validation 
        public string? EmpName { get; set; }    // ReferenceType : Allow Null [ Optional ]
      
        #region OtherProperty

        [DataType(DataType.Currency)]           //This Data Annotation Just  for Display not to set salary with currency             

        [Column(TypeName = "Money")]            // To make this property Will be Mapped to datatype "Money" insteadof "Float"
        public double Salary { get; set; }      // ValueType : Not Allow Null [ Required ]

        [Range(22, 30)]                         // this DataAnnotation For Validation 
        public int? Age { get; set; }           // Nullable<int> ValueType : Allow Null [ Optional ]

        [EmailAddress]                          // this Data Annotation For Validation 
        //[DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Phone]                                 // this Data Annotation For Validation
        //[DataType(DataType.PhoneNumber)]    
        public string? PhoneNumber { get; set; }
        [PasswordPropertyText]
        [DataType(DataType.Password)]           // this Data Annotation For Validation
        public string? PassWord { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        public string Address { get; set; }
        [NotMapped]
        public double NetSalary => Salary-(Salary * .2);

        public double GetNetSalary => Salary- (Salary * .2);



        #endregion



    }
}

 
