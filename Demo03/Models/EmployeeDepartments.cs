using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Models
{
    //[Keyless]
    //[Index()]
    public class EmployeeDepartments
    {
        public int  EmployeeCode { get; set; }
        public string EmployeeName {  get; set; }=null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set;}=null!;


        
    }
}
