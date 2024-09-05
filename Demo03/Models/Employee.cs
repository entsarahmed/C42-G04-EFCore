using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Demo.Models
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public int? DepartmentId { get; set; } //Foreign Key Column for work Relationship with Department Entity 

        // Navigation Property[One]   --> [Related Data]
        public virtual Department? Department { get; set; }= null;

    }
}
